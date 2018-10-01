using FlightManagement.Domain;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace FlightManagement.DAL
{
    public class CargoRepo : ICargoRepo
    {
        private readonly IDBO _dBO;
        public CargoRepo(IDBO _dBO)
        {
            this._dBO = _dBO;
        }
        public int DeleteCargo(int cargoId)
        {
            string sqlQuery = "Delete from Cargo where Id = @Id";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@Id", cargoId)
            };
            return _dBO.IUD(sqlQuery, param, CommandType.Text);
        }

        public List<Cargo> GetAllCargo()
        {
            string sqlQuery = "Select * from Cargo";
            DataTable dataTable = _dBO.GetTable(sqlQuery, null, CommandType.Text);
            List<Cargo> listCargo = new List<Cargo>();
            if (dataTable.Rows.Count > 0)
            {
                listCargo = dataTable.AsEnumerable().Select(m => new Cargo()
                {
                    Id = m.Field<int>("Id"),
                    CargoItem = m.Field<string>("CargoItem"),
                }).ToList();
            }
            return listCargo;
        }

        public List<Cargo> GetCargoById(string cargoId)
        {
            string sqlQuery = "Select * from Cargo where CargoItem Like @Name";
            SqlParameter[] param = new SqlParameter[]
           {
                new SqlParameter("@Name", cargoId +"%")
           };
            DataTable dataTable = _dBO.GetTable(sqlQuery, param, CommandType.Text);
            List<Cargo> listCargo = new List<Cargo>();
            if (dataTable.Rows.Count > 0)
            {
                listCargo = dataTable.AsEnumerable().Select(m => new Cargo()
                {
                    Id = m.Field<int>("Id"),
                    CargoItem = m.Field<string>("CargoItem"),
                }).ToList();
            }
            return listCargo;
        }

        public int SaveUpdateCargo(Cargo cargo)
        {
            if (cargo.Id > 0)
            {
                string sqlQuery2 = "Update Cargo set CargoItem = @Name where Id = @Id";
                SqlParameter[] param2 = new SqlParameter[]
                {
                new SqlParameter("@Id", cargo.Id),
                new SqlParameter("@Name", cargo.CargoItem)
                };
                return _dBO.IUD(sqlQuery2, param2, CommandType.Text);
            }
            else
            {
                string sqlQuery = "Insert into Cargo(CargoItem) values(@Name)";
                SqlParameter[] param = new SqlParameter[]
                {
                  new SqlParameter("@Name", cargo.CargoItem)
                };
                return _dBO.IUD(sqlQuery, param, CommandType.Text);
            }
        }
    }
}
