namespace Data.Repositories
{
    public class MainRepository
    {
        public static EmployeeRepository EmployeeRepository = new EmployeeRepository();
        public static StructureRepository StructureRepository = new StructureRepository();
        public static TestConnectionRepository TestConnectionRepository = new TestConnectionRepository();
    }
}