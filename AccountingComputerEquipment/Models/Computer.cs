using System.ComponentModel.DataAnnotations;

namespace AccountingComputerEquipment.Models
{
    public class Computer : Device
    {
        public string SerialNumber { get; set; }
        public DateTime BuildDate { get; set; }
        public string CPU { get; set; }
        public string GPU { get; set; }
        public string RAM { get; set; }
        public string Motherboard { get; set; }
        public string HDD { get; set; }
        public string LANCard { get; set; }
        public string DVD { get; set; }
        public string PSU { get; set; } // Блок питания
    }
}
