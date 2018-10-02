using FlightManagement.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace FlightManagement.DAL
{
    public class PlaneBookRepo : IPlaneBookRepo
    {
        private readonly IDBO _dBO;
        public PlaneBookRepo(IDBO _dBO)
        {
            this._dBO = _dBO;
        }
        public int Cancelbooking(string custName)
        {
            string sqlQuery = "Delete from PlaneBook where CustomerId = (Select Id from Customer where Name = @CustName)";
            SqlParameter[] param = new SqlParameter[]
             {
                new SqlParameter("@CustName", custName)
             };
            return _dBO.IUD(sqlQuery, param, CommandType.Text);
        }

        public List<PlaneBook> GetAllBooking()
        {
            string sqlQuery = @"SELECT PlaneBook.PlaneId, Plane.PlaneName, Plane.PlaneType, Cargo.CargoItem, PlaneBook.BookedBy, PlaneBook.CustomerId, Customer.Name AS [CustomerName], PlaneBook.Id AS [BookId], PlaneBook.Departure, PlaneBook.Arrival
                                FROM PlaneBook LEFT JOIN Plane ON PlaneBook.PlaneId = Plane.Id
								LEFT JOIN Cargo ON PlaneBook.CargoId = Cargo.Id
                                LEFT JOIN Customer ON PlaneBook.CustomerId = Customer.Id";
            DataTable dataTable = _dBO.GetTable(sqlQuery, null, CommandType.Text);
            List<PlaneBook> listPlaneBook = new List<PlaneBook>();
            if (dataTable.Rows.Count > 0)
            {
                listPlaneBook = dataTable.AsEnumerable().Select(m => new PlaneBook()
                {
                    PlaneList = new Plane()
                    {
                        Id = m.Field<int>("PlaneId"),
                        PlaneName = m.Field<string>("PlaneName"),
                        PlaneType = m.Field<string>("PlaneType")
                    },
                    CustomerList = new Customer()
                    {
                        Id = m.Field<int?>("CustomerId"),
                        Name = m.Field<string>("CustomerName"),
                    },
                    CargoList = new Cargo()
                    {
                        CargoItem = m.Field<string>("CargoItem"),
                    },
                    Id = m.Field<int>("BookId"),
                    Departure = m.Field<DateTime>("Departure"),
                    Arrival = m.Field<DateTime?>("Arrival"),
                    BookedBy = m.Field<string>("BookedBy")
                }).ToList();
            }
            return listPlaneBook;
        }
        public List<PlaneBook> GetAllBookingCurrentDate(string departureDate)
        {
            string sqlQuery = @"SELECT PlaneBook.PlaneId, Plane.PlaneName, Plane.PlaneType, Cargo.CargoItem, PlaneBook.BookedBy, PlaneBook.CustomerId, Customer.Name AS [CustomerName], PlaneBook.Id AS [BookId], PlaneBook.Departure, PlaneBook.Arrival
                                FROM PlaneBook LEFT JOIN Plane ON PlaneBook.PlaneId = Plane.Id
								LEFT JOIN Cargo ON PlaneBook.CargoId = Cargo.Id
                                LEFT JOIN Customer ON PlaneBook.CustomerId = Customer.Id
                                Where CAST(Departure AS date) = @DepartureDate";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@DepartureDate", departureDate)
            };
            DataTable dataTable = _dBO.GetTable(sqlQuery, param, CommandType.Text);
            List<PlaneBook> listPlaneBook = new List<PlaneBook>();
            if (dataTable.Rows.Count > 0)
            {
                listPlaneBook = dataTable.AsEnumerable().Select(m => new PlaneBook()
                {
                    PlaneList = new Plane()
                    {
                        Id = m.Field<int>("PlaneId"),
                        PlaneName = m.Field<string>("PlaneName"),
                        PlaneType = m.Field<string>("PlaneType")
                    },
                    CustomerList = new Customer()
                    {
                        Id = m.Field<int?>("CustomerId"),
                        Name = m.Field<string>("CustomerName"),
                    },
                    CargoList = new Cargo()
                    {
                        CargoItem = m.Field<string>("CargoItem"),
                    },
                    Id = m.Field<int>("BookId"),
                    Departure = m.Field<DateTime>("Departure"),
                    Arrival = m.Field<DateTime?>("Arrival"),
                    BookedBy = m.Field<string>("BookedBy")
                }).ToList();
            }
            return listPlaneBook;
        }

        public List<PlaneBook> GetBookingByCustName(string custName, string departureDate)
        {
            string sqlQuery = @"SELECT PlaneBook.PlaneId, Plane.PlaneName, Plane.PlaneType, Cargo.CargoItem, PlaneBook.BookedBy, PlaneBook.CustomerId, Customer.Name AS [CustomerName], PlaneBook.Id AS [BookId], PlaneBook.Departure, PlaneBook.Arrival
                                FROM PlaneBook LEFT JOIN Plane ON PlaneBook.PlaneId = Plane.Id
								LEFT JOIN Cargo ON PlaneBook.CargoId = Cargo.Id
                                LEFT JOIN Customer ON PlaneBook.CustomerId = Customer.Id
                                Where CAST(Departure AS date) = @DepartureDate AND BookedBy Like @CustName";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@CustName", custName +"%"),
                new SqlParameter("@DepartureDate", departureDate)
            };
            DataTable dataTable = _dBO.GetTable(sqlQuery, param, CommandType.Text);
            List<PlaneBook> listPlaneBook = new List<PlaneBook>();
            if (dataTable.Rows.Count > 0)
            {
                listPlaneBook = dataTable.AsEnumerable().Select(m => new PlaneBook()
                {
                    PlaneList = new Plane()
                    {
                        Id = m.Field<int>("PlaneId"),
                        PlaneName = m.Field<string>("PlaneName"),
                        PlaneType = m.Field<string>("PlaneType")
                    },
                    CustomerList = new Customer()
                    {
                        Id = m.Field<int?>("CustomerId"),
                        Name = m.Field<string>("CustomerName"),
                    },
                    CargoList = new Cargo()
                    {
                        CargoItem = m.Field<string>("CargoItem"),
                    },
                    Id = m.Field<int>("BookId"),
                    Departure = m.Field<DateTime>("Departure"),
                    Arrival = m.Field<DateTime?>("Arrival"),
                    BookedBy = m.Field<string>("BookedBy")
                }).ToList();
            }
            return listPlaneBook;
        }

        public int SaveUpdateBookingCust(PlaneBook planeBook)
        {
            DataTable dataTable = CheckBookStatus(planeBook.PlaneId, planeBook.Departure);
            if (dataTable.Rows.Count > 0)
            {
                if (planeBook.Id > 0)
                {
                    string sqlQuery2 = "Update PlaneBook set PlaneId = @PlaneId, BookedBy = @BookedBy, CustomerId = @CustomerId, Departure = @Departure, Arrival = @Arrival where Id = @Id";
                    SqlParameter[] param2 = new SqlParameter[]
                    {
                   new SqlParameter("@Id", planeBook.Id),
                   new SqlParameter("@BookedBy", planeBook.BookedBy),
                   new SqlParameter("@PlaneId", planeBook.PlaneId),
                   new SqlParameter("@CustomerId", planeBook.CustomerId),
                   new SqlParameter("@Departure", planeBook.Departure),
                   new SqlParameter("@Arrival", planeBook.Arrival)
                    };
                    return _dBO.IUD(sqlQuery2, param2, CommandType.Text);
                }
                else
                {
                    string sqlQuery = "Insert into PlaneBook(BookedBy, PlaneId, CustomerId, Departure, Arrival) values(@BookedBy, @PlaneId, @CustomerId, @Departure, @Arrival)";
                    SqlParameter[] param = new SqlParameter[]
                    {
                   new SqlParameter("@BookedBy", planeBook.BookedBy),
                   new SqlParameter("@PlaneId", planeBook.PlaneId),
                   new SqlParameter("@CustomerId", planeBook.CustomerId),
                   new SqlParameter("@Departure", planeBook.Departure),
                   new SqlParameter("@Arrival", planeBook.Arrival)
                    };
                    return _dBO.IUD(sqlQuery, param, CommandType.Text);
                }
            }
            else
            {
                return 0;
            }
        }

        public int SaveUpdateBookingCargo(PlaneBook planeBook)
        {
            if (planeBook.Id > 0)
            {
                string sqlQuery2 = "Update PlaneBook set BookedBy = @BookedBy, PlaneId = @PlaneId, CargoId = @CargoId, Departure = @Departure where Id = @Id";
                SqlParameter[] param2 = new SqlParameter[]
                {
                   new SqlParameter("@Id", planeBook.Id),
                   new SqlParameter("@BookedBy", planeBook.BookedBy),
                   new SqlParameter("@PlaneId", planeBook.PlaneId),
                   new SqlParameter("@CargoId", planeBook.CargoId),
                   new SqlParameter("@Departure", planeBook.Departure)
                };
                return _dBO.IUD(sqlQuery2, param2, CommandType.Text);
            }
            else
            {
                string sqlQuery = "Insert into PlaneBook(BookedBy, PlaneId, CargoId, Departure) values(@BookedBy, @PlaneId, @CargoId, @Departure)";
                SqlParameter[] param = new SqlParameter[]
                {
                   new SqlParameter("@BookedBy", planeBook.BookedBy),
                   new SqlParameter("@PlaneId", planeBook.PlaneId),
                   new SqlParameter("@CargoId", planeBook.CargoId),
                   new SqlParameter("@Departure", planeBook.Departure)
                };
                return _dBO.IUD(sqlQuery, param, CommandType.Text);
            }
        }

        public DataTable CheckBookStatus(int PlaneId, DateTime departureTime)
        {
            string sqlQuery = @"SELECT Id FROM PLANEBOOK WHERE PlaneId = @PlaneId AND Departure = @DepartureTime";
            SqlParameter[] param = new SqlParameter[]
            {
                   new SqlParameter("@PlaneId", PlaneId),
                   new SqlParameter("@DepartureTime", departureTime)
            };
            return _dBO.GetTable(sqlQuery, param, CommandType.Text);
        }
    }
}
