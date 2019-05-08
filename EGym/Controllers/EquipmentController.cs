using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EGym.Models;
using EGym.ViewModels;

namespace EGym.Controllers
{
    public class EquipmentController : Controller
    {
        private IEnumerable<Equipment> GetEquipment()
        {
            return new List<Equipment>()
            {
                new Equipment() { Id = 1, EquipmentName = "Bench" },
                new Equipment() { Id = 2, EquipmentName = "Dumbbells" }
            };
        }

        // GET: Equipment
        public ActionResult Index()
        {
            var equipment = GetEquipment();

            return View(equipment);
        }

        public ActionResult Details(int id)
        {
            var equipment = GetEquipment().SingleOrDefault(c => c.Id == id);
            if (equipment == null)
                return HttpNotFound();

            return View(equipment);
        }

        // GET: Equipment
        public ActionResult Schedule()
        {
            var equipment1 = new Equipment()
            {
                EquipmentName = "ScheduleTemp"
            };
            return View(equipment1);

        }

        [Route("equipment/description/{equipmentName}")]
        public ActionResult Item(string equipmentName)
        {
            var equipment1 = new Equipment()
            {
                EquipmentName = equipmentName
            };
            return View(equipment1);
        }
    }
}