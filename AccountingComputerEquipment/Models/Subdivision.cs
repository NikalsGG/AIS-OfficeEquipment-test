namespace AccountingComputerEquipment.Models
{
    public class Subdivision
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<User> Users { get; set; }
        public Subdivision()
        {
            Users = new List<User>();
        }
    }
}
