using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace ATMMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Account open");
         
            Console.WriteLine("Log in Account");
            string Log = Console.ReadLine();
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Your Account Number");
            string Account = Console.ReadLine();
            Console.WriteLine("password");
            int password = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your Current balance");
            string balance = Console.ReadLine();
            Console.WriteLine("Deposit or Withdraw");
            string depositorwithdraw  = Console.ReadLine();
            Console.WriteLine("Enter Your Deposit Amount");
            string Amount = Console.ReadLine();
            Console.WriteLine("Total balance");
            string Total = Console.ReadLine();
           
                Console.ReadLine();

        }
    }
}


    
   



