using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CQRSPatternConsoleApp.Models;

namespace CQRSPatternConsoleApp.Repositories
{
    public interface IEmployeeQueriesRepository
    {
        Employee GetById(int id);

    }
}
