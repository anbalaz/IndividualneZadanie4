﻿using Data.Models;
using Data.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace Service
{
    public class MainFrmService
    {
        private StructureRepository _structureRepository = MainRepository.StructureRepository;
        private EmployeeRepository _employeeRepository = MainRepository.EmployeeRepository;

        public List<Structure> GetStructuresList(int code, OrganizationLevel level)
        {
            return _structureRepository.SelectStructureList(code, level);
        }

        public List<Employee> GetEmployeesList(int code)
        {
            return _employeeRepository.SelectEmployeesList(code);
        }

        public List<Employee> GetEmployeesList()
        {
            return _employeeRepository.SelectEmployeesList();
        }

        public Employee GetEmployee(int code)
        {
            return _employeeRepository.SelectEmployee(code);
        }

        public Structure GetStructure(int code)
        {
            return _structureRepository.SelectStructure(code);
        }

        public List<Structure> GetStructuresList()
        {
            return _structureRepository.SelectStructureList();
        }

        public List<Structure> GetStructuresList(OrganizationLevel level) 
        {
            return _structureRepository.SelectStructureList().Where(structure=>structure.Level== level).ToList();
        }

        public bool UpdateStructure(Structure structure, int previousDirectorId)
        {
            return _structureRepository.UpdateStructure(structure, previousDirectorId);
        }

        public bool InsertStructure(Structure structure)
        {
            return _structureRepository.InsertStructure(structure);
        }

        public bool InsertEmployee(Employee employee)
        {
            return _employeeRepository.InsertEmployee(employee);
        }

        public List<Employee> GetEveryEmployeeWhoIsNotDirector(int code)
        {
            List<Structure> structures = GetStructuresList();
            List<Employee> employees = GetEmployeesList();

            for (int i = 0; i < employees.Count; i++)
            {
                foreach (var structure in structures)
                {
                    if (structure.Employee != null && employees[i].ID == structure.Employee.ID && structure.Code != code)
                    {
                        employees.Remove(employees[i--]);
                        break;
                    }
                }
            }
            return employees;
        }

        public int GenerateCode()
        {
            if (GetStructuresList().Count != 0)
            {
                return GetStructuresList().Max(structure => structure.Code) + 1;
            }
            else
            {
                return 1000;
            }
        }
    }
}