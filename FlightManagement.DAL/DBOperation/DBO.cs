using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace FlightManagement.DAL
{
    public class DBO : IDBO
    {
        private AppSettingsReader aps;
        private string connectionString;

        public DBO()
        {
            aps = new AppSettingsReader();
            connectionString = aps.GetValue("myconnection", typeof(string)).ToString();
        }

        private SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection(connectionString);
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            return con;
        }

        public int IUD(string sql, SqlParameter[] param, CommandType cmdType)
        {
            using (SqlConnection con = GetConnection())
            {

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = cmdType;

                if (param != null)
                {
                    cmd.Parameters.AddRange(param);
                }
                try
                {
                    return cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                    throw ex;
                }

            }
        }


        public DataTable GetTable(string sql, SqlParameter[] param, CommandType cmdType)
        {
            using (SqlConnection con = GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.CommandType = cmdType;
                    if (param != null)
                    {
                        cmd.Parameters.AddRange(param);
                    }
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }
    }
}
