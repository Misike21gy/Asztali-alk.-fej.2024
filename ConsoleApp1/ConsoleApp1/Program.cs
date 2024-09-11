using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            a = 0;
            Console.WriteLine("Összeadó program");
            Console.WriteLine("Ez a program két ön által megadott számot összead");
            Console.WriteLine("Adja meg az első számot:");
            try
            {
                a = Convert.ToDouble(Console.ReadLine());
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Adja meg az második számot:");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("A két szám összege: {0} és a duplája: {1}", a + b, (a+b)*2);
            Console.ReadKey();
        }
    }
}
