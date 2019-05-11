using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using EGym.Models;
using EGym.ViewModels;

namespace EGym.Controllers
{
    public class EquipmentController : Controller
    {
        private ApplicationDbContext _context;

        public EquipmentController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        [Authorize(Roles = RoleName.CanManageEquipment)]
        public ActionResult New()
        {
            var rentalType = _context.RentalTypes.ToList();
            var viewModel = new EquipmentFormViewModel()
            {
                Equipment = new Equipment(),
                RentalTypes = rentalType
            };
            return View("EquipmentForm", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Equipment equipment)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new EquipmentFormViewModel()
                {
                    Equipment = equipment,
                    RentalTypes = _context.RentalTypes.ToList()
                };

                return View("EquipmentForm", viewModel);
            }

            if (equipment.Id == 0)
            {
                equipment.CustomerId = 3;
                _context.Equipments.Add(equipment);
            }
            else
            {
                var equipmentInDb = _context.Equipments.Single(e => e.Id == equipment.Id);

                Mapper.Map(equipment, equipmentInDb);
            }

            _context.SaveChanges();
            return RedirectToAction("Index", "Equipment");
        }

        // GET: Equipment
        public ActionResult Index()
        {
            if (User.IsInRole(RoleName.CanManageEquipment))
                return View("List");

            return View("ReadOnlyList");
        }

        public ActionResult Details(int id)
        {
            // var customers = _context.Customers..ToList();
            var equipment = _context.Equipments.Include(e => e.Customer).SingleOrDefault(c => c.Id == id);
            if (equipment == null)
                return HttpNotFound();

            return View(equipment);
        }

        // GET: Equipment
        public ActionResult Schedule()
        {
            var equipment1 = new Equipment()
            {
                Name = "ScheduleTemp"
            };
            return View(equipment1);

        }

        [Route("equipment/description/{Name}")]
        public ActionResult Item(string Name)
        {
            var equipment1 = new Equipment()
            {
                Name = Name
            };
            return View(equipment1);
        }

        public ActionResult Edit(int id)
        {
            var equipment = _context.Equipments.SingleOrDefault(e => e.Id == id);

            if (equipment == null)
                return HttpNotFound();

            var viewModel = new EquipmentFormViewModel
            {
                Equipment = equipment,
                RentalTypes = _context.RentalTypes.ToList()
            };

            return View("EquipmentForm", viewModel);
        }
    }
}