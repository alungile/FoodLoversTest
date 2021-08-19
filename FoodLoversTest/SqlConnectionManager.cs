using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodLoversTest
{
    public class SqlConnectionManager
    {   
        public static SqlConnection GetConnectionString()
        {
            //? Create a new connection object
            var connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            return connection;
        }
    }
}
