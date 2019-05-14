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
            return _structureRepository.SelectStructureList(code,level);
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
    }
}