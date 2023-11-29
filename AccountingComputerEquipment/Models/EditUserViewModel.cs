using Microsoft.AspNetCore.Mvc.Rendering;

namespace AccountingComputerEquipment.Models
{
    public class EditUserViewModel
    {
        public User User { get; set; }
        public Computer Computer { get; set; }
    }
}
