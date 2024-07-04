using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionPattern
{
    public interface IDataAccessLayer
    {
        void saveData(string data); 
    }
}
