using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    class Service2 : IService
    {
        public void Serve()
        {
            Console.WriteLine("Service2 Called!");
        }
    }
}
