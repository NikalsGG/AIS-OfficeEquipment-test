using Microsoft.AspNetCore.Mvc.Rendering;
using System.Reflection;

namespace AccountingComputerEquipment.Models
{
    public class HardwareViewModel
    {
        public User User { get; set; }
        public List<PCMonitor> PCMonitors { get; set; }
        public List<Computer> Computers { get; set; }
        public List<Software> Softwares { get; set; }
        public UserOperatingSystem UserOperatingSystem { get; set; }

    }
}
