using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Test_PTUDCSDL
{
    internal class Database
    {
        private static SqlConnection connection =new SqlConnection("Data Source=21AK22-COM\\SERVER;Initial Catalog=QuanLyHangHoa;Integrated Security=True");

        public static void Execute(string cmd,Dictionary<String,object> parameters=null) {
            connection.Open();
            SqlCommand command = new SqlCommand(cmd, connection);
            if (parameters != null) {
                foreach(string key in parameters.Keys) command.Parameters.Add(new SqlParameter(key, parameters[key]));
            }
            command.ExecuteNonQuery();
            connection.Close();
        }

        public static DataTable Query(string cmd, Dictionary<String, object> parameters = null)
        {
            connection.Open();
            SqlCommand command = new SqlCommand(cmd, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            if (parameters != null)
            {
                foreach (string key in parameters.Keys) command.Parameters.Add(new SqlParameter(key, parameters[key]));
            }
            adapter.Fill(table);
            connection.Close();
            return table;
        }
    }
}
