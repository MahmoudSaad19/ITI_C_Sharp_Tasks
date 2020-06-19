using System;

namespace D04_ass
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Point3D P = new Point3D(10, 10, 10);
            Console.WriteLine(P.ToString());

            string word = (string) P;
            Console.WriteLine(word);

            Console.WriteLine("\n________________________________________\n");

            Point3D p1, p2;
            Console.WriteLine("Enter First point Coordinates : ");
            int a, b, c;

            do
            {
                Console.Write("X : ");
            } while (!int.TryParse(Console.ReadLine(), out a) || a<0);
            do
            {
                Console.Write("Y : ");
            } while (!int.TryParse(Console.ReadLine(), out b) || b<0);
            do
            {
                Console.Write("Z : ");
            } while (!int.TryParse(Console.ReadLine(), out c) || c<0);
            p1 = new Point3D(a, b, c);

            Console.WriteLine("Enter Second point Coordinates : ");

            do
            {
                Console.Write("X : ");
            } while (!int.TryParse(Console.ReadLine(), out a) || a<0);
            do
            {
                Console.Write("Y : ");
            } while (!int.TryParse(Console.ReadLine(), out b) || b<0);
            do
            {
                Console.Write("Z : ");
            } while (!int.TryParse(Console.ReadLine(), out c) || c<0);
            p2 = new Point3D(a, b, c);

            Console.WriteLine(p1);
            Console.WriteLine(p2);

            if (p1.Equals("p2"))
                Console.WriteLine("P1 EQ P2");
            else
                Console.WriteLine("P1 NEQ 'p2'");
            Console.WriteLine("\n________________________________________\n");

            //Point3D points2 = new Point3D[2];// { p1, p2 }; wrong code 
            Point3D[] points =  { p1, p2 };
            
            Array.Sort(new Point3D[2]);
            Console.WriteLine("After Sorting : ");
            foreach (var i in points)
                Console.WriteLine(i);
            Console.WriteLine("\n________________________________________\n");

            Console.WriteLine($"5+6 = {_My_Math.Add(5,6)}");
            Console.WriteLine($"5-6 = {_My_Math.Subtract(5,6)}");
            Console.WriteLine($"5*6 = {_My_Math.Multiply(5,6)}");
            Console.WriteLine($"5/6 = {_My_Math.Divide(5,6)}");
            Console.WriteLine("\n________________________________________\n");

            NetworkInterfaceController ob1 = NetworkInterfaceController.controllerObj;


            


            Duration D = new Duration(1, 10, 15);
            Console.WriteLine($" D =   {D}");
             
            Duration D1 = new Duration(3600);
            Console.WriteLine($" D1 =   {D1}");

            Duration D2 = new Duration(7800);
            Console.WriteLine($" D2 =   {D2}");

            Duration D3 = new Duration(666);
            Console.WriteLine($" D3 =   {D3}");
            Console.WriteLine("\n________________________________________\n");

          
            
            //DateTime Obj = (DateTime)D1

            D3 = D1 + D2;
            Console.WriteLine($"D3 = D1 + D2 \n{D3}");
            D3 = D1 + 7800;
            Console.WriteLine($"D3 = D1 + 7800 \n{D3}");
            D3 = 666 + D3;
            Console.WriteLine($"D3 = 666 + D3 \n{D3}");

            D3 = D1++;
            Console.WriteLine($"D3 = D1++(Increase One Minute) \n{D3}");

            D3 = --D2;
            Console.WriteLine($"D3 = --D2 (Decrease One Minute) \n{D3}");

            D1 -=D2;            
            Console.WriteLine($"D1 =- D2  \n{D1}");

            Console.WriteLine($" D1 > D2 {D1 > D2 } ");
            Console.WriteLine($" D1 <= D2 {D1 <= D2 } ");

            if (D1)
                Console.WriteLine("D1 has a value.");
            else
                Console.WriteLine("D1 has no value.");
                
            DateTime Obj = (DateTime)D2;
            Console.WriteLine($"D2 = {D2}");
            Console.WriteLine($"DateTime obj = {Obj}");

            
            DateTime date = new DateTime(2020, 1, 1, 0, 10, 59);
            Console.WriteLine(date);








        }
    }
}
