namespace Data.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public string Title { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAdress { get; set; }
        public Structure FirmStructure { get; set; }
    }
}