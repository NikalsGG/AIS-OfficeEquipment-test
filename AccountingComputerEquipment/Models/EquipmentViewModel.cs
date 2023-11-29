using Microsoft.AspNetCore.Mvc.Rendering;

namespace AccountingComputerEquipment.Models
{
    public class EquipmentViewModel
    {
        public IEnumerable<User> User { get; set; }
        public SelectList Equipments { get; set; }
        public string SerialNumber { get; set; }
    }
}
