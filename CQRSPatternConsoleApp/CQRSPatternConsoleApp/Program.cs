﻿using System;
using CQRSPatternConsoleApp.Commands;
using CQRSPatternConsoleApp.Queries;
using CQRSPatternConsoleApp.Repositories;

namespace CQRSPatternConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            var employeeCommand = new EmployeeCommands(new EmployeeCommandsRepository());

            employeeCommand.SaveEmployeeData(new Models.Employee
            {
                Id = 200,
                FirstName = "Jane",
                LastName = "Smith",
                Street = "150 Toronto Street",
                City = "Toronto",
                PostalCode = "j1j1j1",
                DateOfBirth = new DateTime(2002, 2, 2)
            });

            Console.WriteLine("Employee data stored");
            // Query the Employee Domain to get data
            var employeeQuery = new EmployeeQueries(new EmployeeQueriesRepository());
            var employee = employeeQuery.FindByID(100);
            Console.WriteLine($"Employee ID:{employee.Id}, Name:{employee.FullName}, Address:{employee.Address}, Age:{employee.Age}");
            Console.ReadKey();

        }
    }
}
