﻿using Data.Entities;
using Service.Interfaces.Employee.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interfaces
{
    public interface IEmployeeService
    {
        EmployeeDto GetById(int? id);
        IEnumerable<EmployeeDto> GetAll();
        void Add(EmployeeDto employee);
        void Update(EmployeeDto employee);
        void Delete(EmployeeDto employee);
        IEnumerable<EmployeeDto> GetEmployeeByName(string name);

    }
}