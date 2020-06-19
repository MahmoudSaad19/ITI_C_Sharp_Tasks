using System;
using System.Collections.Generic;
using System.Text;

namespace D04_ass
{
    static class _My_Math
    {
        ///7. Write a program with a Math class that has four methods:
        ///Add, Subtract, Multiply, and Divide, each of which takes two parameters.
        ///Call each method from Main ( ).
        ///8. Modify the program from Exercise 7 
        ///so that you do not have to create an instance of Math 
        ///to call the four methods
        ///
        public static double Add(double a, double b) { return a+b;}
        public static double Subtract (double a , double b) { return a-b; }
        public static double Multiply (double a , double b) { return a*b; }
        public static double Divide (double a , double b) 
        {
            b = b == 0 ? 1 : b;
            return a/b; 
        }


    }
}
