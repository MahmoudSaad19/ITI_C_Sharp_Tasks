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
            #region Databse Connection

            //1. Establish Databse Connection 
            SqlConnection sql = new SqlConnection();

            sql.ConnectionString = ConfigurationManager.ConnectionStrings["SRC1"].ConnectionString;
            #endregion

            #region SQL Statments

            //2. Add Query Command you want to run on Database 
            SqlCommand sqlCommand1 = new SqlCommand("Select * from Products",sql);
            sqlCommand1.CommandType = CommandType.Text;
            #endregion


            //3. Diplay Data with 2 Ways 
            DataTable readerTable = new DataTable();
            int data = sqlCommand1.ExecuteReader().FieldCount;
            Console.WriteLine(data);
            SqlDataAdapter dataAdapter = new SqlDataAdapter();

        }



    }
}
