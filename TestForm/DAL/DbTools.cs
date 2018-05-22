using System;
using System.Data;
using System.Data.SqlClient;

namespace TestForm.DAL
{
    public class DbTools : IDbTools
    {
        public string ConnectionString { get; }

        public DbTools(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        public DataTable GetDataTable(string sql)
        {
            var dt = new DataTable();

            using (var con = new SqlConnection(ConnectionString))
            {
                con.Open();

                var sqlCommand = new SqlCommand(sql, con);

                var sda = new SqlDataAdapter(sqlCommand);

                sda.Fill(dt);
            }

            return dt;
        }

        public DataTable ExecuteSqlDataTable(string sql, params object[] prms)
        {
            var dt = new DataTable();

            using (var con = new SqlConnection(ConnectionString))
            {
                con.Open();

                var sqlCommand = new SqlCommand(sql, con);

                for (int index = 0; index * 2 < prms.Length; index++)
                {
                    var paramName = prms[index].ToString();
                    var paramValue = prms[index + 1];

                    if (paramValue == null)
                        paramValue = DBNull.Value;

                    sqlCommand.Parameters.AddWithValue(paramName, paramValue);
                }

                var sda = new SqlDataAdapter(sqlCommand);

                sda.Fill(dt);
            }

            return dt;
        }

        public int ExecuteSql(string sql, params object[] prms)
        {
            using (var con = new SqlConnection(this.ConnectionString))
            {
                con.Open();

                var sqlCommand = new SqlCommand(sql, con);

                for (int index = 0; index < prms.Length; index += 2)
                {
                    var paramName = prms[index].ToString();
                    var paramValue = prms[index + 1];

                    if (paramValue == null)
                        paramValue = DBNull.Value;

                    sqlCommand.Parameters.AddWithValue(paramName, paramValue);
                }

                var id = Convert.ToInt32(sqlCommand.ExecuteScalar());
                //int id = 47;
                con.Close();

                return id;
            }
        }
    }
}
