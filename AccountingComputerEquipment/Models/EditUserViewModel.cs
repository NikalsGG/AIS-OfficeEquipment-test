using Microsoft.AspNetCore.Mvc.Rendering;

namespace AccountingComputerEquipment.Models
{
    public class EditUserViewModel
    {
        public User User { get; set; }
        public Computer Computer { get; set; }
        //
        public UserOperatingSystem UserOperatingSystem { get; set; }
        //
        public SelectList Positions { get; set; } // Добавлено свойство Positions
        public SelectList Subdivisions { get; set; } // Добавлено свойство Subdivisions
    }
}
