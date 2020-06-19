﻿using System;
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

            #region Diplay Data

            //3. Diplay Data with 2 Ways 

            #region 3.1 Connected Mode ( Read only )

            sql.Open();
            int data = sqlCommand1.ExecuteReader().FieldCount;
            Console.WriteLine(data);
            sql.Close();

            #endregion

            #region DisConnected Mode ( Read & Write for Local copy of DB )

            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand1);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            Console.WriteLine("______________________________Table Data_____________________________ ");
            Console.WriteLine();
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                foreach (var item in dataTable.Rows[i].ItemArray)
                {
                    Console.Write($" {item}  \t");
                }
                Console.WriteLine();
            }
            

            Console.ReadLine();
            #endregion

            #endregion

        }



    }
}