using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTuts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 12;
            const string y = "Help";
            bool a = true;
            char c = '$';
            ushort i = 15;
            double w = Convert.ToDouble(x)+.255;
            string s = "234.565";
            decimal f = Convert.ToDecimal(s);
            

            Console.WriteLine(c+y+i+x+a);
            Console.WriteLine(w+"\t"+f);
            Console.WriteLine("Done");
            Console.Beep();
           
        }
    }
}
