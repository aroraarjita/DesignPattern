using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    class Client
    {
        private IService _service;

        public Client(IService service)
        {
            _service = service;
        }

        public void ServeMethod()
        {
            this._service.Serve();
        }
    }
}
