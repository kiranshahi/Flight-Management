using System.Data;
using System.Data.SqlClient;

namespace FlightManagement.DAL
{
    public interface IDBO
    {
        int IUD(string sql, SqlParameter[] param, CommandType cmdType);
        DataTable GetTable(string sql, SqlParameter[] param, CommandType cmdType);
    }
}
