using AccountingComputerEquipment.Data;
using AccountingComputerEquipment.Models;
using Microsoft.AspNetCore.Mvc;

namespace AccountingComputerEquipment.Controllers
{
    public class PositionController : Controller
    {
        private readonly ApplicationDbContext _db;
        public PositionController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Position> objPositionList = _db.Positions;
            return View(objPositionList);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Position position)
        {
            if(ModelState.IsValid)
            {
                _db.Positions.Add(position);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(position);
        }
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null || id == null)
            {
                return NotFound();
            }

            var positionFromDb = _db.Positions.Find(id);

            if (positionFromDb == null)
            {
                return NotFound();
            }

            return View(positionFromDb);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Position position)
        {
            if (ModelState.IsValid)
            {
                _db.Positions.Update(position);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(position);
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var positionFromDb = _db.Positions.Find(id);

            if (positionFromDb == null)
            {
                return NotFound();
            }

            return View(positionFromDb);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePOST(int? id)
        {
            var obj = _db.Positions.Find(id);

            if (obj == null)
            {
                return NotFound();
            }

            _db.Positions.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}
