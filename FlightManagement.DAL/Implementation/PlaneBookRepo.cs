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
            string sqlQuery = @"SELECT PlaneBook.PlaneId, Plane.PlaneName, Plane.PlaneType, PlaneBook.CustomerId, Customer.Name AS [CustomerName], PlaneBook.Id AS [BookId], PlaneBook.BookFor
                                FROM PlaneBook INNER JOIN Plane ON PlaneBook.PlaneId = Plane.Id
                                INNER JOIN Customer ON PlaneBook.CustomerId = Customer.Id";
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
                        Id = m.Field<int>("CustomerId"),
                        Name = m.Field<string>("CustomerName"),
                    },
                    Id = m.Field<int>("BookId"),
                    BookFor = m.Field<DateTime>("BookFor")
                }).ToList();
            }
            return listPlaneBook;
        }

        public List<PlaneBook> GetBookingByCustName(string custName)
        {
            string sqlQuery = @"SELECT PlaneBook.PlaneId, Plane.PlaneName, Plane.PlaneType, PlaneBook.CustomerId, Customer.Name AS [CustomerName], PlaneBook.Id AS [BookId], PlaneBook.BookFor
                                FROM PlaneBook INNER JOIN Plane ON PlaneBook.PlaneId = Plane.Id
                                INNER JOIN Customer ON PlaneBook.CustomerId = Customer.Id Where Customer.Name Like @CustName";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@CustName", custName +"%")
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
                        Id = m.Field<int>("CustomerId"),
                        Name = m.Field<string>("CustomerName"),
                    },
                    Id = m.Field<int>("BookId"),
                    BookFor = m.Field<DateTime>("BookFor")
                }).ToList();
            }
            return listPlaneBook;
        }

        public int SaveUpdateBooking(PlaneBook planeBook)
        {
            if (planeBook.Id > 0)
            {
                string sqlQuery2 = "Update PlaneBook set PlaneId = @PlaneId, CustomerId = @CustomerId, BookFor = @BookFor where Id = @Id";
                SqlParameter[] param2 = new SqlParameter[]
                {
                new SqlParameter("@Id", planeBook.Id),
                new SqlParameter("@PlaneId", planeBook.PlaneList.Id),
                 new SqlParameter("@CustomerId", planeBook.CustomerList.Id),
                  new SqlParameter("@BookFor", planeBook.BookFor)
                };
                return _dBO.IUD(sqlQuery2, param2, CommandType.Text);
            }
            else
            {
                string sqlQuery = "Insert into PlaneBook(PlaneId, CustomerId, BookFor) values(@PlaneId, @CustomerId, @BookFor)";
                SqlParameter[] param = new SqlParameter[]
                {
                new SqlParameter("@PlaneId", planeBook.PlaneList.Id),
                 new SqlParameter("@CustomerId", planeBook.CustomerList.Id),
                  new SqlParameter("@BookFor", planeBook.BookFor)
                };
                return _dBO.IUD(sqlQuery, param, CommandType.Text);
            }
        }
    }
}
