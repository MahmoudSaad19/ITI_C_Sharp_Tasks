﻿using System;
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
            //var data3 = Arr.Where(p => p.Length )
            foreach (var item in Arr)
            {
                Console.WriteLine($"{item} , {item.Length}");
            }
        }
    }
}
