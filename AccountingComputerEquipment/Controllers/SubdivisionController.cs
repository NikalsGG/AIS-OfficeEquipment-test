using AccountingComputerEquipment.Data;
using AccountingComputerEquipment.Models;
using Microsoft.AspNetCore.Mvc;

namespace AccountingComputerEquipment.Controllers
{
    public class SubdivisionController : Controller
    {
        private readonly ApplicationDbContext _db;
        public SubdivisionController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Subdivision> objSubdevisionList = _db.Subdivisions;
            return View(objSubdevisionList);
        }
        public IActionResult Create() // GET
        {
            return View();
        }
    }
}
