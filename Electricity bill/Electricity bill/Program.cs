using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Electricity_bill


{ class Program
            {
                static void Main(string[] args)
        {
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your Fathername");
            string Fname = Console.ReadLine();
            Console.WriteLine("Enter Consumer id");
            string Consumerid = Console.ReadLine();
            Console.WriteLine("Enter Adress");
            string Adress = Console.ReadLine();

            Console.WriteLine("Enter Electric Units consumed");

            float unit = float.Parse(Console.ReadLine());

            float bill;
            if (unit <100)
                    {
                        bill =unit = 7f;
                Console.ReadLine();
            }
                    else if (unit <= 200)
                    {
                       Console.WriteLine (bill = unit = 12.34f);
                Console.ReadLine();
            }
                    else if ( unit <= 250)
                    {
                        Console.WriteLine(bill = unit = 19.75f);
                Console.ReadLine();
            }
                    else if (unit > 250 ||unit<=500)
                    {
                        bill = unit = 20.33f;
                Console.ReadLine();
            }
            else { bill = 21.7f; }
            double CurrentBill = (bill);
                    double surcharge = 58.14*36;
                    double Tvfee = bill / 2 * 20;
                    double Gst = (bill + 74.4) * 2;
                    double Meterrent = (bill + 100) * 3;
                    double costofelectricity = (bill + 50) * 1;
                    
                    bill =Convert.ToInt32( bill + surcharge + Tvfee + Gst + Meterrent + costofelectricity);
                    Console.WriteLine("your Bill for unit {0} is Rs {1}", unit, bill, Tvfee, Gst);
            Console.ReadLine();
            Console.WriteLine(name);
            Console.WriteLine(Fname);
            Console.WriteLine(Consumerid);
            Console.WriteLine(Adress);
            Console.WriteLine(CurrentBill);
            Console.ReadLine();
                }

            }
        }

    
   
   
    
    

