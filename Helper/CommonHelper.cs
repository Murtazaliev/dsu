using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Threading.Tasks;

namespace DguSite
{
    public class CommonHelper
    {
        private static CommonHelper instance;

        private CommonHelper()
        { }

        public static CommonHelper getInstance()
        {
            if (instance == null)
                instance = new CommonHelper();
            return instance;
        }


        public async Task<DataTable> GetDataTableAsync(string Command, string TableName = null)
        {
            try
            {
                var dataTable = new DataTable();
                using (SqlConnection sqlConnection = new SqlConnection(getConnectionString()))
                {
                    sqlConnection.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = sqlConnection;
                    cmd.CommandText = Command;
                    using (var dataReader = await cmd.ExecuteReaderAsync())
                    {
                        dataTable.Load(dataReader);
                        dataReader.Close();
                        dataTable.TableName = TableName;
                        cmd.Dispose();
                        dataTable.Dispose();
                    }
                    sqlConnection.Close();
                }
                return dataTable;
            }
            catch (Exception e)
            {
                return null;
            }
        }
        string Value { get; set; }
        public async Task<string> GetDBValueAsync(string Command, string TableName = null)
        {
            try
            {
                
                using (SqlConnection sqlConnection = new SqlConnection(getConnectionString()))
                {
                    sqlConnection.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = sqlConnection;
                    cmd.CommandText = Command;
                    using (var dataReader = await cmd.ExecuteReaderAsync())
                    {
                        if (dataReader.Read())
                        {
                            Value = dataReader["num"].ToString();
                            dataReader.Close();
                            cmd.Dispose();
                        }
                    }
                    sqlConnection.Close();
                }
                return Value;
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public string getConnectionString()
        {
            return "Server=192.168.116.233;Database=dsu.ru;User ID=sa;Password=@sql2016";
        }
    }
}
