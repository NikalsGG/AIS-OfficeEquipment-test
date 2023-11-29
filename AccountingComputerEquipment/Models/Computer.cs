using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;

namespace AccountingComputerEquipment.Models
{
    public class Computer
    {
        //Компьютер
        public int? ComputerId { get; set; }
        public int? ComputerInventoryNumber { get; set; }
        public string? ComputerSerialNumber { get; set; }
        public string? ComputerName { get; set; }
        public string? UserSystemName { get; set; }
        public string? ComputerIp { get; set; }
        public string? CPU { get; set; }
        public string? GPU { get; set; }
        public string? RAM { get; set; }
        public string? Motherboard { get; set; }
        public string? HDD { get; set; }
        public string? LANCard { get; set; }
        public string? DVD { get; set; }
        public string? PSU { get; set; } 
        public int UserOperatingSystemId { get; set; }
        public UserOperatingSystem UserOperatingSystem { get; set; }
        public string? Softwares { get; set; }
        
        
        //Принтер
        public int? PrinterInventoryNumber { get; set; }
        public string? PrinterSerialNumber { get; set; }
        public string? PrinterName { get; set; }
        public string? PrinterIp{ get; set; }
        public string? PrinterType { get; set; }
        
        
        //Монитор
        public int? PCMonitorInventoryNumber { get; set; }
        public string? PCMonitorSerialNumber { get; set; }
        public string? PCMonitorName { get; set; }
        
        
        //Планшет
        public int? TabletInventoryNumber { get; set; }
        public string? TabletSerialNumber { get; set; }
        public string? TabletName { get; set; }
        
        
        //Пользователь
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
