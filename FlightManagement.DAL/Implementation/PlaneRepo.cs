using FlightManagement.Domain;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace FlightManagement.DAL
{
    public class PlaneRepo : IPlaneRepo
    {
        private readonly IDBO _dBO;
        public PlaneRepo(IDBO _dBO)
        {
            this._dBO = _dBO;
        }
        public int DeletePlane(int planeId)
        {
            string sqlQuery = "Delete from Plane where Id = @Id";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@Id", planeId)
            };
            return _dBO.IUD(sqlQuery, param, CommandType.Text);
        }

        public List<Plane> GetAllPlanes()
        {
            string sqlQuery = "Select * from Plane";
            DataTable dataTable = _dBO.GetTable(sqlQuery, null, CommandType.Text);
            List<Plane> listPlane = new List<Plane>();
            if (dataTable.Rows.Count > 0)
            {
                listPlane = dataTable.AsEnumerable().Select(m => new Plane()
                {
                    Id = m.Field<int>("Id"),
                    PlaneName = m.Field<string>("PlaneName"),
                    PlaneType = m.Field<string>("PlaneType"),
                    Capacity = m.Field<int>("Capacity"),
                    PassengerNumber = m.Field<int>("PassengerNumber"),
                }).ToList();
            }
            return listPlane;
        }

        public List<Plane> GetPlanesById(string planeId)
        {
            string sqlQuery = "Select * from Plane where PlaneName Like @Name";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@Name", planeId +"%")
            };
            DataTable dataTable = _dBO.GetTable(sqlQuery, param, CommandType.Text);
            List<Plane> listPlane = new List<Plane>();
            if (dataTable.Rows.Count > 0)
            {
                listPlane = dataTable.AsEnumerable().Select(m => new Plane()
                {
                    Id = m.Field<int>("Id"),
                    PlaneName = m.Field<string>("PlaneName"),
                    PlaneType = m.Field<string>("PlaneType"),
                    Capacity = m.Field<int>("Capacity"),
                    PassengerNumber = m.Field<int>("PassengerNumber"),
                }).ToList();
            }
            return listPlane;
        }

        public int SaveUpdatePlane(Plane plane)
        {
            if (plane.Id > 0)
            {
                string sqlQuery2 = "Update Plane set PlaneName = @PlaneName, PlaneType = @PlaneType, Capacity = @Capacity, PassengerNumber = @PassengerNumber where Id = @Id";
                SqlParameter[] param2 = new SqlParameter[]
                {
                new SqlParameter("@Id", plane.Id),
                new SqlParameter("@PlaneName", plane.PlaneName),
                 new SqlParameter("@PlaneType", plane.PlaneType),
                  new SqlParameter("@Capacity", plane.Capacity),
                   new SqlParameter("@PassengerNumber", plane.PassengerNumber)
                };
                return _dBO.IUD(sqlQuery2, param2, CommandType.Text);
            }
            else
            {
                string sqlQuery = "Insert into Plane(PlaneName, PlaneType, Capacity, PassengerNumber) values(@PlaneName, @PlaneType, @Capacity, @PassengerNumber)";
                SqlParameter[] param = new SqlParameter[]
                {
                new SqlParameter("@PlaneName", plane.PlaneName),
                 new SqlParameter("@PlaneType", plane.PlaneType),
                  new SqlParameter("@Capacity", plane.Capacity),
                   new SqlParameter("@PassengerNumber", plane.PassengerNumber)
                };
                return _dBO.IUD(sqlQuery, param, CommandType.Text);
            }
        }
    }
}
