namespace Data.Models
{
    public class Structure
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Code { get; set; }
        public OrganizationLevel Level { get; set; }
        public Employee Employee { get; set; }
        public Structure FirmStructure { get; set; }
    }
}