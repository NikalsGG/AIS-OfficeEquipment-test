using AccountingComputerEquipment.Data;
using AccountingComputerEquipment.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Reflection;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace AccountingComputerEquipment.Controllers
{
    public class UserController : Controller
    {
        ApplicationDbContext db;
        public UserController(ApplicationDbContext context)
        {
            db = context;
            // добавляем начальные данные
            //if (db.Subdivisions.Count() == 0)
            //{

            //    PCMonitor monitor1 = new PCMonitor
            //    {
            //        MonitorName = "AOC"
            //    };

            //    Software software1 = new Software
            //    {
            //        SoftwareName = "SAP Enterprise V8.2",
            //    };
            //    Software software2 = new Software
            //    {
            //        SoftwareName = "Office 2016",
            //    };

            //    UserOperatingSystem win10 = new UserOperatingSystem
            //    {
            //        UserOperatingSystemName = "Windows 10",
            //    };
            //    UserOperatingSystem win7 = new UserOperatingSystem
            //    {
            //        UserOperatingSystemName = "Windows 7",
            //    };

            //    Computer computer1 = new Computer
            //    {
            //        ComputerInventoryNumber = 7986100,
            //        ComputerSerialNumber = "Z981567",
            //        ComputerName = "Имя_компьютера_1",
            //        UserSystemName = "SuperBoy",
            //        ComputerIp = "190.180.128.251",
            //        CPU = "Intel Core i7",
            //        GPU = "NVIDIA GeForce RTX 3080",
            //        RAM = "32GB DDR4",
            //        Motherboard = "ASUS Prime Z590",
            //        HDD = "2TB HDD",
            //        LANCard = "Intel Gigabit Ethernet",
            //        DVD = "DVD-RW Drive",
            //        PSU = "750W",
            //        PrinterInventoryNumber = 7989200,
            //        PrinterSerialNumber = "Z8693456",
            //        PrinterName = "HP M826F",
            //        PrinterIp = "190.180.128.506",
            //        //Type = PrinterType.Laser,
            //        PrinterType = "Лазерный",
            //        PCMonitorInventoryNumber = 7986500,
            //        PCMonitorSerialNumber = "Z56784510",
            //        PCMonitorName = "AOC 24 PRO MASTER",
            //        TabletInventoryNumber = 7987300,
            //        TabletSerialNumber = "Z6789876A",
            //        TabletName = "Xiaomi A5-A984F",
            //        ServerInventoryNumber = 7989800,
            //        ServerSerialNumber = "Z09789L",
            //        ServerName = "KRONWERK",
            //        ServerIp = "190.180.128.100",
            //        UserOperatingSystem = win10,
            //        Softwares = "MS Office 2016 Lotus SAP",
            //        IsDecommissioned = false
            //    };

            //    Computer computer7 = new Computer
            //    {
            //        ComputerInventoryNumber = 7986100,
            //        ComputerSerialNumber = "Z981567",
            //        //ComputerName = "Имя_компьютера_1",
            //        UserSystemName = "SuperBoy",
            //        ComputerIp = "190.180.128.251",
            //        CPU = "Intel Core i7",
            //        GPU = "NVIDIA GeForce RTX 3080",
            //        RAM = "32GB DDR4",
            //        Motherboard = "ASUS Prime Z590",
            //        HDD = "2TB HDD",
            //        LANCard = "Intel Gigabit Ethernet",
            //        DVD = "DVD-RW Drive",
            //        PSU = "750W",
            //        PrinterInventoryNumber = 7989200,
            //        PrinterSerialNumber = "Z8693456",
            //        PrinterName = "HP M826F",
            //        PrinterIp = "190.180.128.506",
            //        //Type = PrinterType.Laser,
            //        PrinterType = "Лазерный",
            //        PCMonitorInventoryNumber = 7986500,
            //        PCMonitorSerialNumber = "Z56784510",
            //        PCMonitorName = "AOC 24 PRO MASTER",
            //        TabletInventoryNumber = 7987300,
            //        TabletSerialNumber = "Z6789876A",
            //        TabletName = "Xiaomi A5-A984F",
            //        ServerInventoryNumber = 7989800,
            //        ServerSerialNumber = "Z09789L",
            //        ServerName = "KRONWERK",
            //        ServerIp = "190.180.128.100",
            //        UserOperatingSystem = win7,
            //        IsDecommissioned = true
            //    };

            //    Computer computer2 = new Computer
            //    {
            //        ComputerName = "Имя_компьютера_2",
            //        //BuildDate = new DateTime(2023, 9, 15),
            //        CPU = "AMD Ryzen 9",
            //        GPU = "NVIDIA GeForce RTX 3070",
            //        RAM = "16GB DDR4",
            //        Motherboard = "MSI B450 Tomahawk",
            //        HDD = "1TB SSD",
            //        LANCard = "Realtek Ethernet",
            //        DVD = "No DVD Drive",
            //        PSU = "650W"/*,*/
            //        //InventoryNumber = 54321,
            //        //SerialNumber = "XYZ789",
            //        //PurchaseDate = new DateTime(2023, 9, 15),
            //        //Чтобы то что в комментах, сработало, сделай наследование в классе Computer от Device
            //    };

            //    //Branch branch1 = new Branch { BranchName = "Речицкие электрические сети" };
            //    //Branch branch2 = new Branch { BranchName = "Гомельские электрические сети" };

            //    Position a = new Position { PositionName = "Ведущий инженер" };
            //    Position b = new Position { PositionName = "Ведущий долбоеб" };
            //    Position c = new Position { PositionName = "Microsoft" };
            //    Position d = new Position { PositionName = "Apple" };

            //    Subdivision oracle = new Subdivision { Name = "Служба автоматизированных систем управления" };
            //    Subdivision google = new Subdivision { Name = "Залупа" };
            //    Subdivision microsoft = new Subdivision { Name = "Microsoft" };
            //    Subdivision apple = new Subdivision { Name = "Apple" };

            //    User user1 = new User { FullName = "Иван Паршуткин Андреевич", /*InternalPhone = "(5381)340",*/ Email = "Почта",/* Branch = branch1,*/ Position = a, Subdivision = oracle };
            //    User user2 = new User { FullName = "Вася", InternalPhone = "(7777)777", Email = "Почта", /*Branch = branch2,*/ Position = b, Subdivision = oracle };
            //    //User user3 = new User { FullName = "Никита", InternalPhone = "(5381)340", Email = "Почта", /*Branch = branch1,*/ Position = a, Subdivision = oracle };
                
            //    user1.Computers.Add(computer1);
            //    user2.Computers.Add(computer7); 
            //    user1.Monitors.Add(monitor1);

            //    //Software[] softwares = new Software[] { software1, software2 };
            //    //computer1.Softwares.AddRange(softwares);


            //    // Добавьте компьютеры в контекст базы данных
            //    db.UserOperatingSystems.AddRange(win10);
            //    //db.Softwares.AddRange(software1, software2);
            //    db.Monitors.AddRange();
            //    db.Computers.AddRange(computer1/*, computer2*/);
            //    db.Positions.AddRange(a, b, c, d);
            //    db.Subdivisions.AddRange(oracle, microsoft, google, apple);
            //    db.Users.AddRange(user1,user2/*,user3*//*, user2, user3, user4, user5, user6, user7, user8*/);
            //    db.SaveChanges();
            //}
        }
        public ActionResult Index(int? company, int? position, /*int?branch,*/ string name)
        {
            IQueryable<User> users = db.Users.Include(p => p.Subdivision).Include(p => p.Position)/*.Include(p => p.Branch)*//*.Include(p => p.Computer)*/;
            
            if (company != null && company != 0)
            {
                users = users.Where(p => p.SubdivisionId == company);
            }
            if(position != null && position != 0)
            {
                users = users.Where(p => p.PositionId == position);
            }
            //if (branch != null && branch != 0)
            //{
            //    users = users.Where(p => p.BranchId == branch);
            //}
            if (!String.IsNullOrEmpty(name))
            {
                users = users.Where(p => p.FullName.Contains(name));
            }

            List<Subdivision> companies = db.Subdivisions.ToList();
            List<Position> positions = db.Positions.ToList();
            //List<Branch> branches = db.Branches.ToList();
            // устанавливаем начальный элемент, который позволит выбрать всех
            companies.Insert(0, new Subdivision { Name = "Все", Id = 0 });
            positions.Insert(0, new Position { PositionName = "Все", Id = 0 });
            //branches.Insert(0, new Branch { BranchName = "Все", BranchId = 0 });


            UsersListViewModel viewModel = new UsersListViewModel
            {
                Users = users.ToList(),
                Subdivisions = new SelectList(companies, "Id", "Name"),
                Positions = new SelectList(positions, "Id", "PositionName"),
                //Branchs = new SelectList(branches, "BranchId", "BranchName"),
                Name = name
            };
            return View(viewModel);
        }
        public IActionResult Create()
        {
            SelectList subdivisions = new SelectList(db.Subdivisions, "Id", "Name");
            SelectList positions = new SelectList(db.Positions, "Id", "PositionName");
            SelectList userOperatingSystems = new SelectList(db.UserOperatingSystems, "UserOperatingSystemId", "UserOperatingSystemName");
            //SelectList branchs = new SelectList(db.Branches, "BranchId", "BranchName");

            ViewBag.Subdivisions = subdivisions;
            ViewBag.Positions = positions;
            ViewBag.UserOperatingSystems = userOperatingSystems;
            //ViewBag.Branchs = branchs;
            
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(User user, Computer computer) //(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();

            computer.UserId = user.UserId;
            db.Computers.Add(computer); //(user)
            db.SaveChanges();
            //TempData["success"] = "User created successfully.";
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int? itemId)
        {
            if (itemId == null)
            {
                return NotFound();
            }

            // Находим в бд футболиста
            User user = db.Users
                .Include(u => u.Computers)
                .FirstOrDefault(u => u.UserId == itemId);

            //Computer computer = user?.Computers.FirstOrDefault();

            if (user != null)
            {
                EditUserViewModel viewModel = new EditUserViewModel
                {
                    User = user,
                    Computer = user.Computers.FirstOrDefault(),
                    Positions = new SelectList(db.Positions, "Id", "PositionName"), // Замените на свои реальные названия свойств
                    Subdivisions = new SelectList(db.Subdivisions, "Id", "Name"), // То же самое здесь
                };

                ViewBag.Positions = viewModel.Positions;
                ViewBag.Subdivisions = viewModel.Subdivisions;

                //// Создаем список команд для передачи в представление
                //SelectList subdivisions = new SelectList(db.Subdivisions, "Id", "Name"/*, user.SubdivisionId*/);
                //SelectList positions = new SelectList(db.Positions, "Id", "PositionName"/*, user.PositionId*/);
                //SelectList userOperatingSystems = new SelectList(db.UserOperatingSystems, "UserOperatingSystemId", "UserOperatingSystemName");
                ////SelectList branchs = new SelectList(db.Branches, "BranchId", "BranchName", user.BranchId);
                //ViewBag.Subdivisions = subdivisions as IEnumerable<SelectListItem>;
                //ViewBag.Positions = positions;
                //ViewBag.UserOperatingSystems = userOperatingSystems;
                ////ViewBag.Branchs = branchs;
                return View(viewModel); /*user*/
            }
            return RedirectToAction("Index");
        }


        [HttpPost]
        public IActionResult Edit(EditUserViewModel editedModel)
        {
            if (ModelState.IsValid)
            {
                // Применяем изменения в базе данных
                db.Update(editedModel.User);
                db.Update(editedModel.Computer);
                db.SaveChanges();

                return RedirectToAction("Index"); // Перенаправляем пользователя после успешного редактирования
            }

            // Если ModelState не прошел валидацию, возвращаем пользователя на страницу редактирования с ошибками
            return View(editedModel);
        }


        public User GetUserById(int? userId)
        {
            return db.Users.Find(userId);
        }

        public Computer GetComputerById(int? computerId)
        {
            return db.Computers.Find(computerId);
        }

        public void SaveChanges()
        {
            db.SaveChanges();
        }

        [HttpGet]
        public IActionResult EditComputer(int? itemId)
        {
            if (itemId != null)
            {
                Computer computer = db.Computers.FirstOrDefault(p => p.ComputerId == itemId);
                if (computer != null)
                    return View(computer);
            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult EditComputer(EditUserViewModel editUserViewModel)
        {
            if (editUserViewModel.Computer.ComputerId == 0)
            {
                db.Computers.Add(editUserViewModel.Computer);
            }
            else
            {
                var entity = db.Computers.Attach(editUserViewModel.Computer);
                db.Entry(editUserViewModel.Computer).State = EntityState.Modified;
            }
            db.SaveChanges();
            return RedirectToAction("Index");

            //db.Computers.Update(computer);
            //db.SaveChanges();
            //return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int? itemId)
        {
            if (itemId == null)
            {
                return NotFound();
            }

            User userFromDb = db.Users.Find(itemId);
            Computer computerFromDb = db.Computers.Find(userFromDb.UserId);
            UserOperatingSystem userOperatingSystemFromDb = db.UserOperatingSystems.Find(computerFromDb.UserOperatingSystemId);

            if (userFromDb != null)
            {
                EditUserViewModel viewModel = new EditUserViewModel
                {
                    User = userFromDb,
                    Computer = computerFromDb,
                    UserOperatingSystem = userOperatingSystemFromDb
                };

                return View(viewModel);
            }
            return RedirectToAction("Index");
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePOST(int? itemId/*, int? duraBlyat*/)
        {
            User userFromDb = db.Users.Find(itemId);
            Computer computerFromDb = db.Computers.Find(userFromDb.UserId);
            //UserOperatingSystem userOperatingSystemFromDb = db.UserOperatingSystems.Find(computerFromDb.UserOperatingSystemId);

            if(userFromDb != null || computerFromDb != null /*|| userOperatingSystemFromDb != null*/)
            {
                db.Users.Remove(userFromDb);
                db.Computers.Remove(computerFromDb);
                //db.UserOperatingSystems.Remove(userOperatingSystemFromDb);

                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        public IActionResult SystemInfoGET(int? itemId)
        {
            if (itemId == null || itemId == 0)
            {
                return NotFound();
            }

            var userFromDB = db.Users.Find(itemId);
            var computerFromDB = db.Computers.Find(userFromDB.UserId);
            var osFromDB = computerFromDB != null ? db.Computers.Find(computerFromDB.UserOperatingSystemId) : null;

            if (userFromDB == null)
            {
                return NotFound();
            }
            //if(computerFromDB == null)
            //{
            //    return NotFound();
            //}

            //if (osFromDB == null)
            //{
            //    return NotFound();
            //}

            if(computerFromDB == null || osFromDB == null)
            {
                var hardwareModel = new HardwareViewModel
                {
                    User = userFromDB,
                    PCMonitors = new List<PCMonitor>(),
                    Computers = new List<Computer>(),
                    UserOperatingSystem = new UserOperatingSystem()
                };

                ViewBag.ErrorMessage = "Информация отсутствует!";
                return View(hardwareModel);
            }

            List<PCMonitor> userMonitors = GetMonitorsForUser(userFromDB);
            List<Computer> userComputers = GetComputersForUser(userFromDB);
            //List<Software> userSoftwares = GetSoftwaresForUser(computerFromDB);
            int osId = computerFromDB.UserOperatingSystemId;
            UserOperatingSystem userOperatingSystem = GetUserOperatingSystem(osId);

            var model = new HardwareViewModel
            {
                User = userFromDB,
                PCMonitors = userMonitors,
                Computers = userComputers,
                //Softwares = userSoftwares,
                UserOperatingSystem = userOperatingSystem
            };

            return View(model);
        }

        public List<PCMonitor> GetMonitorsForUser(User user)
        {
            List<PCMonitor> monitors = db.Monitors.Where(m => m.UserId == user.UserId).ToList();
            return monitors;
        }

        public List<Computer> GetComputersForUser(User user)
        {
            List<Computer> computers = db.Computers.Where(c => c.UserId == user.UserId).ToList();
            return computers;
        }

        public UserOperatingSystem GetUserOperatingSystem(int userOperatingSystemId)
        {
            UserOperatingSystem result = db.UserOperatingSystems.FirstOrDefault(c => c.UserOperatingSystemId == userOperatingSystemId);
            return result;
        }

    }
}
