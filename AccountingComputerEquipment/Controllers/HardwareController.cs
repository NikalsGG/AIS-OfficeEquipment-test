using AccountingComputerEquipment.Data;
using AccountingComputerEquipment.Models;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace AccountingComputerEquipment.Controllers
{
    public class HardwareController : Controller
    {
        private readonly ApplicationDbContext _db;
        public HardwareController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index(int? itemId)
        {
            if (itemId == null || itemId == 0)
            {
                return NotFound();
            }

            var userFromDB = _db.Users.Find(itemId);

            if (userFromDB == null)
            {
                return NotFound();
            }

            return View(userFromDB);
        }

        //public IActionResult UserProfile()
        //{
        //    // Получите текущего пользователя и связанные с ним объекты
        //    User currentUser = GetCurrentUser(); // Здесь вы должны получить текущего пользователя из вашей системы аутентификации

        //    // Здесь вы должны получить мониторы, компьютеры и принтеры, связанные с текущим пользователем
        //    List<PCMonitor> userMonitors = GetMonitorsForUser(currentUser);
        //    List<Computer> userComputers = GetComputersForUser(currentUser);
        //    List<Printer> userPrinters = GetPrintersForUser(currentUser);

        //    // Создайте модель представления
        //    UserViewModel model = new UserViewModel
        //    {
        //        User = currentUser,
        //        Monitors = userMonitors,
        //        Computers = userComputers,
        //        Printers = userPrinters
        //    };

        //    return View(model);
        //}
    }
}
