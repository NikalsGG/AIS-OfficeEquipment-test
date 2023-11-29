using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;

namespace AccountingComputerEquipment.Models
{
    public class Computer/* : Device*/ //Комментарий убери гений
    {
        public int? ComputerId { get; set; }
        public int? ComputerInventoryNumber { get; set; }
        public string? ComputerSerialNumber { get; set; }
        public string? ComputerName { get; set; }

        //
        public string? UserSystemName { get; set; }
        //

        public string? ComputerIp { get; set; }
        //public DateTime BuildDate { get; set; }
        public string? CPU { get; set; }
        public string? GPU { get; set; }
        public string? RAM { get; set; }
        public string? Motherboard { get; set; }
        public string? HDD { get; set; }
        public string? LANCard { get; set; }
        public string? DVD { get; set; }
        public string? PSU { get; set; } // Блок питания

        // СДЕЛАЙ ТИПЫ ПРИНТЕРОВ
        public int? PrinterInventoryNumber { get; set; }
        public string? PrinterSerialNumber { get; set; }
        public string? PrinterName { get; set; }
        public string? PrinterIp{ get; set; }
        public /*PrinterType*/string? PrinterType { get; set; }

        public int? PCMonitorInventoryNumber { get; set; }
        public string? PCMonitorSerialNumber { get; set; }
        public string? PCMonitorName { get; set; }

        public int? TabletInventoryNumber { get; set; }
        public string? TabletSerialNumber { get; set; }
        public string? TabletName { get; set; }

        // добавить характеристики для сервера, CPU, ОЗУ и т.д.
        public int? ServerInventoryNumber { get; set; }
        public string? ServerSerialNumber { get; set; }
        public string? ServerName { get; set; }
        public string? ServerIp { get; set; }

        public int UserOperatingSystemId { get; set; }
        public UserOperatingSystem UserOperatingSystem { get; set; }

        public string? Softwares { get; set; }

        public bool IsDecommissioned { get; set; } = false;
        //public List<Software> Softwares { get; set; }
        //public List<UserOperatingSystem> UserOperatingSystems { get; set; }

        //

        //public List<User> Users { get; set; }
        public Computer()
        {
            //Softwares = new List<Software>();
        }
        public int UserId { get; set; }
        public User User { get; set; }
    }
    //public enum PrinterType
    //{
    //    Laser,
    //    Inkjet,
    //    DotMatrix,
    //    Thermal,
    //    Other
    //}
}
