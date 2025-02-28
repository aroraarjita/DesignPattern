using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CQRSPatternConsoleApp.DTOs;
using CQRSPatternConsoleApp.Repositories;

namespace CQRSPatternConsoleApp.Queries
{
    class EmployeeQueries : IEmployeeQueries
    {
        private readonly IEmployeeQueriesRepository _repository;

        public EmployeeQueries(IEmployeeQueriesRepository repository)
        {
            _repository = repository;
        }


        public EmployeeDTO FindByID(int employeeID)
        {
            var emp = _repository.GetById(employeeID);
            return new EmployeeDTO
            {
                Id = emp.Id,
                FullName = emp.FirstName + " " + emp.LastName,
                Address = emp.Street + " " + emp.City + " " + emp.PostalCode,
                Age = Convert.ToInt32(Math.Abs(((DateTime.Now - emp.DateOfBirth).TotalDays) / 365)) - 1
            };
        }
    }
}
