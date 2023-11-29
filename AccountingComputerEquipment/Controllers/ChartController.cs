using AccountingComputerEquipment.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AccountingComputerEquipment.Controllers
{
    public class ChartController : Controller
    {
        private readonly ApplicationDbContext _db;
        public ChartController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult OSStatisticsChart()
        {
            var userOsData = _db.UserOperatingSystems
                .Include(os => os.Computers)
                .ToList();

            var chartData = new
            {
                labels = userOsData.Select(os => os.UserOperatingSystemName),
                datasets = new[]
                {
                    new
                    {
                        label = "Кол-во устройств",
                        data = userOsData.Select(os => os.InstallCount), //os.InstallCount
                        borderWidth = 1
                    }
                }
            };

            return View(chartData);
        }
    }
}
