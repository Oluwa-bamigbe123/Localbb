
using LocalBetBiga.Interfaces.Repository;
using LocalBetBiga.Models;
using LocalBetBiga.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocalBetBiga.Domain.Repository
{
    public class EquipmentRepository : IEquipmentRepository
    {
        private readonly ApplicationDbContext _context;

        public EquipmentRepository(ApplicationDbContext context)
        {
            _context = context;

        }
        public Equipments AddEquipment(Equipments equipments)
        {
            _context.Equipments.Add(equipments);
            _context.SaveChanges();
            return equipments;

        }

        public int CreateEquipment(Equipments equipments)
        {
            try
            {
                _context.Equipments.Add(equipments);
                _context.SaveChanges();
                return equipments.Id;
            }
            catch (Exception ea)
            {
                Console.WriteLine($"err2: {ea.Message}");
            }
            return equipments.Id;
        }

        public void DeleteEquipment(int id)
        {
            var equipment = _context.Equipments.Find(id);
            _context.Remove(equipment);
            _context.SaveChanges();
        }

        public Equipments FindByEquipmentType(string equipmentName)
        {
            return _context.Equipments.FirstOrDefault(eq => eq.EquipmentType == equipmentName);
        }

        public Equipments FindById(int id)
        {
            return _context.Equipments.FirstOrDefault(i => i.Id == id);
        }

        public Equipments FindByProductId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Equipments> GetAll()
        {
            return _context.Equipments.Include(c => c.Category). ToList();

        }

        public Equipments GetEquipments(int id)
        {
            return _context.Equipments.Find(id);
        }
        public Equipments GetEquipment(int id)
        {
            return _context.Equipments.Find(id);
        }

        public Equipments UpdateEquipments(Equipments equipments)
        {
            _context.Equipments.Update(equipments);
            _context.SaveChanges();
            return equipments;
        }

     

        public Equipments FindByTypeAndBrand(string type, string brand)
        {
            return _context.Equipments.FirstOrDefault(eq => eq.EquipmentType == type && eq.Brand == brand);

        }

        public Equipments FindByType(string type)
        {
            return _context.Equipments.FirstOrDefault(t => t.EquipmentType == type);
        }

        public Equipments GetType(int id)
        {
            return _context.Equipments.Find(id);
        }

        public Equipments UpdateEquipmentNumber(int id, int number)
        {
            var numberToBeAdded = _context.Equipments.Find(id);
            _context.Update(number);
            _context.SaveChanges();
            return numberToBeAdded;
        }

        public List<Equipments> FindByCategoryId(int id)
        {
            return _context.Equipments.Where(e => e.CategoryId == id).ToList();
        }

        public List<String> GetAllBrandByEquipmentType(string type)
        {
            return _context.Equipments.Where(e => e.EquipmentType == type).Select(e => e.Brand).ToList();
        }
    }
}
