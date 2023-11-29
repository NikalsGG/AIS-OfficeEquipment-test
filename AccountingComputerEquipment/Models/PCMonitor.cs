namespace AccountingComputerEquipment.Models
{
    public class PCMonitor /*: Device*/
    {
        public int PCMonitorId { get; set; }
        public string MonitorName { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
