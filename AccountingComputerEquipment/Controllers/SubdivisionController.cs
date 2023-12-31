﻿using AccountingComputerEquipment.Data;
using AccountingComputerEquipment.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Subdivision subdivision) // POST
        {
            if (ModelState.IsValid)
            {
                _db.Subdivisions.Add(subdivision);
                _db.SaveChanges();
                TempData["success"] = "Subdivision created successfully.";
                return RedirectToAction("Index");
            }
            return View(subdivision);
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if(id == null || id == null)
            {
                return NotFound();
            }

            var subdivisionFromDb = _db.Subdivisions.Find(id);

            if(subdivisionFromDb == null)
            {
                return NotFound();
            }

            return View(subdivisionFromDb);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Subdivision subdivision)
        {
            if(ModelState.IsValid)
            {
                _db.Subdivisions.Update(subdivision);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(subdivision);
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if(id == null || id == 0)
            {
                return NotFound();
            }

            var subdivisionFromDb = _db.Subdivisions.Find(id);

            if(subdivisionFromDb == null)
            {
                return NotFound();
            }

            return View(subdivisionFromDb);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePOST(int? id)
        {
            var obj = _db.Subdivisions.Find(id);

            if(obj == null)
            {
                return NotFound();
            }

            _db.Subdivisions.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
