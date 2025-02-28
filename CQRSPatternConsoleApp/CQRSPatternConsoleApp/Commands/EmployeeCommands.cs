﻿using CQRSPatternConsoleApp.Models;
using CQRSPatternConsoleApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSPatternConsoleApp.Commands
{
    public class EmployeeCommands : IEmployeeCommands
    {
        private readonly IEmployeeCommandsRepository _repository;
        public EmployeeCommands(IEmployeeCommandsRepository repository)
        {
            _repository = repository;
        }

        public void SaveEmployeeData(Employee employee)
        {
            _repository.SaveEmployee(employee);
        }
    }
}
