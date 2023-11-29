namespace AccountingComputerEquipment.Models
{
    public class Software
    {
        public int SoftwareId { get; set; }
        public string SoftwareName { get; set; }
        public int ComputerId { get; set; }
        public Computer Computer { get; set; }
        //public List<Computer> Computers { get; set; }
        //public Software()
        //{
        //    Computers = new List<Computer>();
        //}
    }
}
