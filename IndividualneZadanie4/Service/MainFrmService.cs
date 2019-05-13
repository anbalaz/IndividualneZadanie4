using Data.Models;
using Data.Repositories;
using System.Collections.Generic;

namespace Service
{
    public class MainFrmService
    {
        private StructureRepository _structureRepository = new StructureRepository();
        private EmployeeRepository _employeeRepository = new EmployeeRepository();

        public List<Structure> GetStructuresList(int code,OrganizationLevel level)
        {
            return _structureRepository.SelectEmployeeList(code,level);
        }

        public List<Employee> GetEmployeesList(int code)
        {
            return _employeeRepository.SelectEmployeesList(code);
        }
    }
}