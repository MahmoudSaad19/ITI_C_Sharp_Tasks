using System;
using System.Collections.Generic;
using System.Text;

namespace Delegate_Assignment
{
    public class BookFunctions
    {
        public static string GetTitle(Book B)
        {
            return $"Book Title is : {B.Title}";
        }
        public static string GetAuthors(Book B)
        {
            string str = "";
            foreach (var item in B?.Authors)
            {
                str += item + " ,";
            }

            return $"Book Authors are  : ( {str} )";

        }
        public static string GetPrice(Book B)
        {
            return $"Book Price is : {B.Price}";
        }
    }
}
