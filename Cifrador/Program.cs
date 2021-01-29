using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    { public static string clave;
        static void Main(string[] args)
        {
            clave = Clave.LoadValues();
            Console.WriteLine(clave);
            Console.ReadKey();
        }
    }
}
