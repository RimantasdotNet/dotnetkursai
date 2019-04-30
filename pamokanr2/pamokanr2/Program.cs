using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pamokanr2
{
    class Program
    {
        static void Main(string[] args)
        {
            string vardas;
           
            Console.WriteLine("PLEASE ENTER Name");
            vardas = (Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("{0} {0}{0} {0}", vardas);
            Console.ReadLine();

        }
    }
}
