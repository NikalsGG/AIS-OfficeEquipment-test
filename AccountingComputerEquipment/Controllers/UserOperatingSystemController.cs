using AccountingComputerEquipment.Data;
using AccountingComputerEquipment.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace AccountingComputerEquipment.Controllers
{
    public class UserOperatingSystemController : Controller
    {
        private readonly ApplicationDbContext _db;

        public UserOperatingSystemController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<UserOperatingSystem> objUserOSList = _db.UserOperatingSystems;
            return View(objUserOSList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Create(UserOperatingSystem userOperatingSystem)
        {
            if (ModelState.IsValid)
            {
                _db.UserOperatingSystems.Add(userOperatingSystem);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(userOperatingSystem);
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var userOSFromDb = _db.UserOperatingSystems.Find(id);

            if (userOSFromDb == null)
            {
                return NotFound();
            }

            return View(userOSFromDb);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(UserOperatingSystem userOperatingSystem)
        {
            //var userOSFromDb = _db.UserOperatingSystems.Find(userOperatingSystem.UserOperatingSystemId);

            if (ModelState.IsValid)
            {
                _db.UserOperatingSystems.Update(userOperatingSystem);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(userOperatingSystem);
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var userOSFromDb = _db.UserOperatingSystems.Find(id);

            if (userOSFromDb == null)
            {
                return NotFound();
            }

            return View(userOSFromDb);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePOST(int? id)
        {
            var obj = _db.UserOperatingSystems.Find(id);

            if (obj == null)
            {
                return NotFound();
            }

            _db.UserOperatingSystems.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
