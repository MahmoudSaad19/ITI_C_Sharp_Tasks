using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using static Lab.ListGenerators;

namespace Lab
{
    class Program
    {
        static void countOfLinqFunctions ()
        {
            Int16 counter = 1;
            MethodInfo[] methods = typeof(Enumerable).GetMethods();
            HashSet<string> listOfNames = new HashSet<string>();
            foreach (var method in methods)
                listOfNames.Add(method.Name);

            foreach (var name in listOfNames)
                Console.WriteLine($"{counter++}) {name}");
        }

        static void Main(string[] args)
        {
            ///LINQ - Restriction Operators
            
            //1. Find all products that are out of stock.
            var data = ProductList.Where(p => p.UnitsInStock == 0);
            foreach (var item in data)
            {
                Console.WriteLine(item);
            }
                        
            //2. Find all products that are in stock and cost more than 3.00 per unit.
            var data2 = ProductList.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3);
            foreach (var item in data2)
            {
                Console.WriteLine(item);
            }

            //3. Returns digits whose name is shorter than their value.
            string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            var data3 = Arr.Where((p, i) => p.Length < i);
            foreach (var item in data3)
            {
                Console.WriteLine(item);
            }

            ///LINQ - Element Operators

            //1. Get first Product out of Stock 
            Console.WriteLine(
                ( from P in ProductList
                where P.UnitsInStock == 0
                select P).FirstOrDefault()
                );

            //2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned.
            Console.WriteLine( $"Product is : { ProductList.Where(p => p.UnitPrice > 1000).FirstOrDefault()}");

            //3. Retrieve the second number greater than 5 
            int[] Arr2 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            Console.WriteLine(Arr2.Where(i => i > 5).Skip(1).FirstOrDefault());

            ///LINQ - Set Operators
            ///
            //1. Find the unique Category names from Product List
            var dataset = ProductList.Select(p => p.Category).Distinct();
            foreach (var item in dataset)
            {
                Console.WriteLine(item);
            }

            //2. Produce a Sequence containing the unique first letter from both product and customer names.
            var seq1 = ProductList.Select(p => p.ProductName.First());
            var seq2 = CustomerList.Select(c => c.CompanyName.First());

            foreach (var item in seq2.Union(seq1))
            {
                Console.WriteLine(item);
            }

            //3. Create one sequence that contains the common first letter from both product and customer names.
            foreach (var item in seq1.Intersect(seq2).Distinct())
            {
                Console.WriteLine(item);
            }

            //4. Create one sequence that contains the first letters of product names that are not also first letters of customer names.
            foreach (var item in seq1.Except(seq2))
            {
                Console.WriteLine(item);
            }

            //5. Create one sequence that contains the last Three Characters in each names of all customers and products, including any duplicates
            var seq3 = ProductList.Select(p =>p.ProductName.Substring(p.ProductName.Length-3));
            foreach (var item in seq3)
            {
                Console.WriteLine(item);
            }

            ///LINQ - Aggregate Operators
            ///
            //1. Uses Count to get the number of odd numbers in the array
            int[] Arr3 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            Console.WriteLine(Arr3.Count(i => i % 2 != 0));

            //2. Return a list of customers and how many orders each has.
            var data4 = CustomerList.Select(c => $"{c} ::: Orders Count = {c.Orders.Count()}");
            foreach (var item in data4)
            {
                Console.WriteLine(item);
            }

            //3. Return a list of categories and how many products each has
            var data5 = ProductList.Select(p => $"{p.Category} , products {ProductList.Where(p2 => p2.Category == p.Category).Count()}").Distinct();
            foreach (var item in data5)
            {
                Console.WriteLine(item);
            }

            //4. Get the total of the numbers in an array.
            int[] Arr5 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            Console.WriteLine($"total Sum = {Arr5.Sum()} , total Count = {Arr5.Count()} or {Arr5.Length}");

            //5. Get the total number of characters of all words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).

            /************************************************************************/

            //6.Get the total units in stock for each product category.
            var dataset2 = from p in ProductList
                           where p.UnitsInStock > 0
                           group p by p.Category;

            foreach (var item in dataset2)
            {
                Console.WriteLine($"{item.Key} , {item.Count()}");
            }

        }
    }
}
