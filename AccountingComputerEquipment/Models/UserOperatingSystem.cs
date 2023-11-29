using AccountingComputerEquipment.Data;
using Microsoft.IdentityModel.Tokens;

namespace AccountingComputerEquipment.Models
{
    public class UserOperatingSystem
    {
        public int UserOperatingSystemId { get; set; }
        public string UserOperatingSystemName { get; set; }
        public int InstallCount => Computers.Count;
        public List<Computer> Computers { get; set; }
        public UserOperatingSystem()
        {
            Computers = new List<Computer>();
        }

        public int GetInstallCount()
        {
            return Computers.Count(/*computer => computer.UserOperatingSystemId == UserOperatingSystemId*/);
        }

        //    public int OSCount(ApplicationDbContext context)
        //    {
        //        int count = 0;

        //        if(UserOperatingSystemId == null)
        //        {
        //            return count;  
        //        }

        //        var userOs = context.UserOperatingSystems.SingleOrDefault(u => u.UserOperatingSystemId == userOSId);

        //        if (userOs != null)
        //        {
        //            userOs.Computers = context.Computers.Where(c => c.UserOperatingSystem.UserOperatingSystemName == userOs.UserOperatingSystemName).ToList();

        //            count = userOs.Computers.Count();
        //        }


        //        return count;
        //    }
    }
}
