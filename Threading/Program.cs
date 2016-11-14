using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Threading
{
    class Program
    {
        static void One() { Print("One"); }
        static void Two() { Print("Two"); }
        static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(One));
            Thread t2 = new Thread(new ThreadStart(Two));

            t1.Start();
            t2.Start();

            Print("Main");


            Console.ReadKey();
        }
        static void Print(string param)
        {
            for(int i = 0; i <= 100; i++)
            {
                Console.WriteLine(param + ": " + i.ToString());
            }
        }

    }
}
