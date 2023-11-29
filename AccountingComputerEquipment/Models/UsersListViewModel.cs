using Microsoft.AspNetCore.Mvc.Rendering;

namespace AccountingComputerEquipment.Models
{
    public class UsersListViewModel
    {
        public IEnumerable<User> Users { get; set; }
        public SelectList Subdivisions { get; set; }
        public SelectList Positions { get; set; }
        //public SelectList Branchs { get; set; }
        public SelectList Computers { get; set; }
        public SelectList UserOperatingSystems { get; set; }
        public SelectList Monitors { get; set; }
        public string Name { get; set; }
    }
}
