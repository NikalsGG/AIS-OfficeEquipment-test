namespace AccountingComputerEquipment.Models
{
    public class Position
    {
        public int Id { get; set; }
        public string PositionName { get; set; }
        public List<User> Users { get; set; }
        public Position()
        {
            Users = new List<User>();
        }
    }
}
