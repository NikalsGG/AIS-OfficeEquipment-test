using AccountingComputerEquipment.Data;
using AccountingComputerEquipment.Models;
using Microsoft.AspNetCore.Mvc;

namespace AccountingComputerEquipment.Controllers
{
    public class UserController : Controller
    {
        private readonly ApplicationDbContext _db;

        public UserController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<User> objUserList = _db.Users;
            return View(objUserList);
        }
    }
}
