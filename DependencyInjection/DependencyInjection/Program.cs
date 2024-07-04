using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating object
            Service1 s1 = new Service1();

            //passing dependency
            Client c1 = new Client(s1);
            c1.ServeMethod();

            Service2 s2 = new Service2();
            c1 = new Client(s2);
            c1.ServeMethod();

            Console.ReadLine();

        }
    }
}
