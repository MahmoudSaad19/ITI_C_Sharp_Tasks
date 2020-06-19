using System;
using System.Collections.Generic;

namespace Delegate_Assignment
{
    //a.User Defined Delegate Datatype

    public delegate string delgateUserDefined(Book b);

    class Program
    {
        static void Main(string[] args)
        {
            string[] authors = { "Tony Stark", "Elon Mask", "Steve Jobs " };
            List<Book> books = new List<Book>();
            DateTime date = new DateTime();
            books.Add(new Book("123", "How to make an electric car ", authors, date.AddYears(1999), 200));
            books.Add(new Book("456", "Iron man Suit Secrets ", authors, date.AddYears(2200), 2000));
            books.Add(new Book("789", "Apple success story in a nut shell ", authors, date.AddYears(1992), 350));
            books.Add(new Book("1912", "The fruit that changed the world ", authors, date.AddYears(1990), 400));
            books.Add(new Book("10120", "How to make your own Jarvis", authors, date.AddYears(2100), 5000));
            books.Add(new Book("4558", "Space X in a nut shell ", authors, date.AddYears(2030), 250));


            //a.User Defined Delegate Datatype
            delgateUserDefined ptr;
            ptr = new delgateUserDefined(BookFunctions.GetAuthors);
            LibraryEngine.ProcessBooks(books, ptr);

            Console.WriteLine();
            Console.WriteLine();
            //b.BCL Delegates
            Func<Book, string> funcPtr = BookFunctions.GetPrice;
            funcPtr = BookFunctions.GetTitle;
            LibraryEngine.ProcessBooks(books, funcPtr);


            Console.WriteLine();
            Console.WriteLine();

            //c.Anonymous Method(GetISBN)
            LibraryEngine.ProcessBooks<Book,string>(books, 
            delegate (Book book)
            {
                return $"Book ISBN is {book.ISBN} ";
            });

            Console.WriteLine();
            Console.WriteLine();

            //d.Lambda Expression(GetPublicationDate)
            LibraryEngine.ProcessBooks<Book, string>(books,
                b => b.PublicationDate.ToString() );

                                                              
        }
    }

    public class LibraryEngine
    {
        //public static void ProcessBooks(List<Book> bList
        //, delgateUserDefined fPtr)
        //{
        //    foreach (Book B in bList)
        //    {
        //        Console.WriteLine(fPtr(B));
        //    }
        //}

        public static void ProcessBooks<T>(List<T> bList,
            delgateUserDefined fPtr) where T : Book 
        {
            foreach (var B in bList)
            {
                Console.WriteLine(fPtr(B));
            }
        }

        internal static void ProcessBooks<T,S>(List<T> books,
            Func<T, S> funcPtr)
        {
            foreach (var B in books)
            {
                Console.WriteLine(funcPtr(B));
            }
        }

    }


    // Considering the Code Below , Write Down the Body of all Listed
    //    Methods and Properties ,
    //you need to Define fPtr as the following cases:
    //a.User Defined Delegate Datatype
    //b.BCL Delegates
    //c.Anonymous Method(GetISBN)
    //d.Lambda Expression(GetPublicationDate)


}
