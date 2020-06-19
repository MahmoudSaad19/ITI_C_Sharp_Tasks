using System;

namespace D03_ass_test_ref
{
    class Program
    {

        ///Ref Type , By Value
        public static int SumArray(int[] MyArr)
        {
            Console.WriteLine($"MyArr val {MyArr.GetHashCode()}");

            int Sum = 0;
            for (int i = 0; i < MyArr?.Length; i++)
                Sum += MyArr[i];
            return Sum;
        }

        //Ref Type, By ref
        public static int SumArray(ref int[] MyArr)
        {
            Console.WriteLine($"MyArr ref {MyArr.GetHashCode()}");

            int Sum = 0;
            for (int i = 0; i < MyArr?.Length; i++)
                Sum += MyArr[i];
            return Sum;
        }

        static void Main(string[] args)
        {
            lvl2 dd = new lvl2("Owner");
            test test1 = new test();
            test test2 = new test(10, "Saed", dd);
            test test3 = new test(6,"wael",dd);

            test[] tests = { test1,test2,test3};
            //Console.WriteLine(tests.GetHashCode());

            //fref(ref test3, ref test2);
            fval(test3, test2);


            //Console.WriteLine(test1.GetHashCode());
            //test1.see();
            Console.WriteLine(test2.GetHashCode());
            test2.see();
            Console.WriteLine(test3.GetHashCode());
            test3.see();
            

            int[] Arr = { 1, 2, 3, 4, 5 };
            //Console.WriteLine($"MyArr {Arr.GetHashCode()}");

            //Console.WriteLine(SumArray(Arr));

            //Console.WriteLine(SumArray(ref Arr));
        }

        public static void fref(ref test t , ref test d)
        {
            Console.WriteLine("inside ref :");
            Console.WriteLine(t.GetHashCode());
            Console.WriteLine(d.GetHashCode());

            t = d;
            Console.WriteLine(t.GetHashCode());
            Console.WriteLine(d.GetHashCode());

            Console.WriteLine("end ref :");


        }

        public static void fval(test t ,test d)
        {
            Console.WriteLine("inside val :");
            Console.WriteLine(t.GetHashCode());
            Console.WriteLine(d.GetHashCode());

            t = d;
            Console.WriteLine(t.GetHashCode());
            Console.WriteLine(d.GetHashCode());
            Console.WriteLine("end val :");

        }
    }

   

    struct test
    {
        int att1;
        string att2;
        lvl2 lvl ;

        public test(int att1, string att2 , lvl2 lvl2)
        {
            this.att1 = att1;
            this.att2 = att2;
            lvl = lvl2;
        }

        public override string ToString()
        {
            return att2 +" : "+ att1;
        }

        public void see ()
        {
            Console.WriteLine(att2);
            //Console.WriteLine(lvl);
        }
    }

    struct lvl2
    {
        string word;

        public lvl2 (string w)
        {
            word = w;
        }

        public override string ToString()
        {
            return word;
        }
    }

}
