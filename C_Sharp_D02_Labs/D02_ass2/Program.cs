using System;

namespace D02_ass2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Phrase : ");
            string word = Console.ReadLine();
            string [] arr = word.Split(" ");
            string cword = "";
            for (int i = arr.Length - 1; i >= 0; i--)
                //Console.WriteLine(arr[i]);
                cword += arr[i] + " ";
            Console.WriteLine(cword);
        }
    }
}
