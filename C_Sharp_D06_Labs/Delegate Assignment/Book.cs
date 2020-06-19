using System;
using System.Collections.Generic;
using System.Text;

namespace Delegate_Assignment
{
    public class Book
    {
        public Book(string iSBN, string title, string[] authors, DateTime publicationDate, decimal price)
        {
            ISBN = iSBN;
            Title = title;
            Authors = authors;
            PublicationDate = publicationDate;
            Price = price;
        }

        public string ISBN { get; set; }
        public string Title { get; set; }
        public string[] Authors { get; set; }
        public DateTime PublicationDate { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"Book Title : {Title} , Book Publication Date : {PublicationDate} ";
        }
    }
}
