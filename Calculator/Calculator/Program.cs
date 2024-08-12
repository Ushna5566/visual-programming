using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{ 
    class Solution
    {
        public double Subtraction(double a, double b)
        {
            double Result = a + b;
            Console.WriteLine(Result);
            return Result;
        }
        public double Addition(double a, double b)
        {
            double Result = a - b;
            Console.WriteLine(Result);
            return Result;
        }
        public double Multiplication(double a, double b)
        {
            double Result = a * b;
            Console.WriteLine(Result);
            return Result;
        }
        public double Division(double a, double b)
        {
            double Result = a / b;
            Console.WriteLine(Result);
            return Result;
        }
        public double Modulus(double a, double b)
        {
            double Result = a % b;
            Console.WriteLine(Result);
            return Result;
        }
    }
    internal class Program
    {
      
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter value one");
            double a =Convert.ToDouble( Console.ReadLine());
            Console.WriteLine("Please enter value two");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please Select opr -,+,*,/,%");
            string opr = Console.ReadLine();
           


            Solution s = new Solution();
            s.Addition(a ,b);
            s.Subtraction(a ,b);
            s.Multiplication(a, b);
            s.Division(a, b);
            s.Modulus(a, b);
            Console.ReadLine();
            if (opr =="-")
            {
                s.Subtraction(a, b);
            }

            else if (opr == "+")
            {
                s.Addition(a, b);

            }
            else if (opr == "*")
            {
                s.Multiplication(a, b);

            }
            else if (opr == "/")
            {
                s.Division(a, b);

            }
            else if (opr == "%")
            {
                s.Modulus(a, b);

            }



        }
    }
}
