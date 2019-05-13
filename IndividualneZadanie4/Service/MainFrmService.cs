using Data.Models;
using Data.Repositories;
using System.Collections.Generic;

namespace Service
{
    public class MainFrmService
    {
        private StructureRepository _structureRepository = new StructureRepository();

        public List<Structure> GetStructuresList(int code,OrganizationLevel level)
        {
            return _structureRepository.SelectEmployeeList(code,level);
        }

        //public 
    }
}
