using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;

namespace AccountingComputerEquipment.Models
{
    public class User
    {
        // [Editable(false)]
        public int UserId { get; set; }
        public string? FullName { get; set; }
        public string? InternalPhone { get; set; }
        public string? Email { get; set; }
        
        public int? PositionId { get; set; }
        public Position Position { get; set; }
        public int? SubdivisionId { get; set; }
        public Subdivision Subdivision { get; set; }
        public List<Computer> Computers { get; set; }
        
        public User()
        {
            Computers = new List<Computer>();
        }
    }
}
