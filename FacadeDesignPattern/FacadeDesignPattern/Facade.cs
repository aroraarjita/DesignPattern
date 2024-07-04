using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPattern
{
  
    public class Facade
    {
        private readonly SubSystem1 _subsystem1;
        private readonly Subsystem2 _subsystem2;
        private readonly Subsystem3 _subsystem3;

        public Facade()
        {
            _subsystem1 = new SubSystem1();
            _subsystem2 = new Subsystem2();
            _subsystem3 = new Subsystem3();
        }


        public void Operation()
        {
            _subsystem1.Operation1();
            _subsystem2.Operation4();
            _subsystem3.Operation6();
        }
    }
}
