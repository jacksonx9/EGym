using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Data.Entity;
using System.Web.Http;
using AutoMapper;
using EGym.Dtos;
using EGym.Models;

namespace EGym.Controllers.Api
{
    public class EquipmentsController : ApiController
    {
        private ApplicationDbContext _context;

        public EquipmentsController()
        {
            _context = new ApplicationDbContext();
        }

        // GET /api/equipments
        public IEnumerable<EquipmentDto> GetEquipments()
        {
            return _context.Equipments.
                Include(e => e.RentalType)
                .ToList()
                .Select(Mapper.Map<Equipment, EquipmentDto>);
        }

        // GET /api/equipments/1
        public IHttpActionResult GetEquipments(int id)
        {
            var equipment = _context.Equipments.SingleOrDefault(e => e.Id == id);

            if (equipment == null)
                return NotFound();

            return Ok(Mapper.Map<Equipment, EquipmentDto>(equipment));
        }

        // POST /api/equipments
        [HttpPost]
        public IHttpActionResult CreateEquipment(EquipmentDto equipmentDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var equipment = Mapper.Map<EquipmentDto, Equipment>(equipmentDto);
            _context.Equipments.Add(equipment);
            _context.SaveChanges();

            equipmentDto.Id = equipment.Id;

            return Created(new Uri(Request.RequestUri + "/" + equipment.Id), equipmentDto);
        }

        // PUT /api/equipments/1
        [HttpPut]
        public void UpdateEquipment(int id, EquipmentDto equipmentDto)
        {
            if(!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var equipmentInDb = _context.Equipments.SingleOrDefault(e => e.Id == id);

            if (equipmentInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            Mapper.Map<EquipmentDto, Equipment>(equipmentDto, equipmentInDb);

            _context.SaveChanges();
        }

        // DELETE /api/customers/1
        [HttpDelete]
        public void DeleteEquipment(int id)
        {
            var equipmentInDb = _context.Equipments.SingleOrDefault(e => e.Id == id);

            if (equipmentInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.Equipments.Remove(equipmentInDb);
            _context.SaveChanges();
        }
    }
}
