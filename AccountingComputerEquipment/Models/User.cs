using Microsoft.Identity.Client;

namespace AccountingComputerEquipment.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        // позиция в компании
        public int? PositionId { get; set; }
        public Position Position { get; set; }

        // подразделение в компании
        public int? SubdivisionId { get; set; }
        public Subdivision Subdivision { get; set; }
    }
}
