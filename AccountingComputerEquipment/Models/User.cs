using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;

namespace AccountingComputerEquipment.Models
{
    public class User
    {
        [Editable(false)]
        public int UserId { get; set; }
        public string? FullName { get; set; }
        //public string Surname { get; set; }
        //public string MiddleName { get; set; }
        public string? InternalPhone { get; set; }
        public string? Email { get; set; }

        // филиал
        //public int? BranchId { get; set; }
        //public Branch Branch { get; set; }

        // позиция в компании
        public int? PositionId { get; set; }
        public Position Position { get; set; }

        // подразделение в компании
        public int? SubdivisionId { get; set; }
        public Subdivision Subdivision { get; set; }

        //public int ComputerId { get; set; }
        //public Computer Computer { get; set; }

        public List<Computer> Computers { get; set; }
        public List<PCMonitor> Monitors { get; set; }
        public User()
        {
            Computers = new List<Computer>();
            Monitors = new List<PCMonitor>();
        }
    }
}
