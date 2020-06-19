using System;

namespace D02_ass1
{
    class Program
    {
        static int[] arr = { 7, 0, 0, 0, 5, 6, 7, 5, 0, 7, 5, 3 };

        static void Main(string[] args)
        {
            #region Logic
            ///define array 
            ///loop backward to print array
            ///compare both elements 
            ///check for equality 
            ///calclate differnece  
            #endregion

            //7	0	0	0	5	6	7	5	0	7	5	3
            Console.WriteLine("Enter a value : ");
            int userinput = int.Parse( Console.ReadLine());
            //Console.WriteLine(userinput);
            getDistance(userinput);

            #region demo
            //for ( int v=0; v<arr.Length; v++)
            //{
            //    for (int i=arr.Length-1; i>=0 ; i--)
            //    {
            //        Console.WriteLine($" {arr[v]} compare to {arr[i]} is :  {arr[v]==arr[i]}");
            //        if (arr[v] == arr[i])
            //            Console.WriteLine($"_______ Distance is {i-v+1}");
            //    }
            //}
            //Console.WriteLine(i); 
            #endregion
        }

        static void getDistance (int w)
        {
            int v,i;
            for (v = 0; v < arr.Length; v++)
            {
                if (arr[v] == w)
                    break;  
            }
            if (v < arr.Length)
            {
                for (i = arr.Length - 1; i >= 0; i--)
                {
                    if (arr[v] == arr[i])
                        break;
                }
                if (i >0 && v != i)
                    Console.WriteLine($"Max Distance is {i - v - 1}");
                else
                    Console.WriteLine("No match ");
            }
            else
                Console.WriteLine("Not found.");          

        }
    }
}
