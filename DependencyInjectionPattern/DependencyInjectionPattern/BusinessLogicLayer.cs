using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionPattern
{
    public class BusinessLogicLayer
    {
        private readonly IDataAccessLayer _dataAccessLayer;

       public BusinessLogicLayer(IDataAccessLayer dataAccessLayer)
        {
            _dataAccessLayer = dataAccessLayer;
        }

        public void SaveData(string data) {

            _dataAccessLayer.saveData(data);
        }

    }

}
