using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            int c = 0;
            Console.Write("First Number ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("First Number - ", a);
            Console.Write("Second Number ");
            b = Convert.ToInt32(Console.ReadLine());
            c = a - b;
            Console.Write("{0} - {1} = {2}", a,b,c);
            Console.ReadKey();
            
            //Jonny was here 
        }
    }
}
