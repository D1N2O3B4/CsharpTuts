using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTuts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = Math.Pow(2,3);    

            //string y = Console.ReadLine();

            /*bool a = true;

            const char c = '$';

            ushort i = 15;

            double w = Convert.ToDouble(x)+.255;

            string s = "234.565";

            decimal f = Convert.ToDecimal(s);

            string z = "true";

            bool b = Convert.ToBoolean(z);

            Random Rondo = new Random();
            int var = Rondo.Next(1,999);

            string acr = "WE will :";
            acr = acr.Replace(" ", "y");
            
            Console.WriteLine(acr);

            switch (i) { 
                case 10:
                    Console.WriteLine("Yeah ten");
                    break;
                case 11:
                    Console.WriteLine("Eleven i have to go and ....");
                    break;
                case 15:
                    Console.WriteLine("Its 15");
                    break;
                default: 
                    Console.WriteLine("Not found");
                    break;
            
            }
            Console.WriteLine(c+y+i+x+a);
            Console.WriteLine(w+"\t"+f+"\t"+b);
            Console.WriteLine(f.GetType());
            Console.WriteLine("you just typed "+y);
            Console.WriteLine(var);*/
            //Console.Beep();
            Console.WriteLine("INPUT NUMBER:");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num-1; j++) { 
                Console.Write("@");
                }
                Console.WriteLine();
            }
           
        }
    }
}
