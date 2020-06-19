using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace ConsoleAppFWADO
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection sql = new SqlConnection();
            sql.ConnectionString = ConfigurationManager
            SqlCommand sqlCommand1 = new SqlCommand();

            SqlDataAdapter dataAdapter = new SqlDataAdapter();

        }



    }
}
