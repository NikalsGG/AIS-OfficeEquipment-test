using System.ComponentModel.DataAnnotations;

namespace AccountingComputerEquipment.Models
{
    public abstract class Device
    {
        [Key]
        public int DeviceId { get; set; }
        public int InventoryNumber { get; set; }
        public string SerialNumber { get; set; }
        public DateTime PurchaseDate { get; set; }
        //public int UserId { get; set; }
        //public User User { get; set; }
    }
}
