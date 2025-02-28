using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CQRSPatternConsoleApp.DTOs;

namespace CQRSPatternConsoleApp.Queries
{
     interface IEmployeeQueries
    {
       public EmployeeDTO FindByID(int employeeId);
    }
}
