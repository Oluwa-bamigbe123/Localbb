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
    public class AdminEquipmentDistributionRepository : IAdminEquipmentDistributionRepository
    {
        private readonly ApplicationDbContext _context;

        public AdminEquipmentDistributionRepository(ApplicationDbContext context)
        {
            _context = context;

        }

        public AdminEquipmentDistribution CreateDistribution(AdminEquipmentDistribution equipmentDistribution)
        {
            _context.AdminEquipmentDistribution.Add(equipmentDistribution);
            _context.SaveChanges();
            return equipmentDistribution;
        }

        public AdminEquipmentDistribution FindById(int id)
        {
            return _context.AdminEquipmentDistribution.FirstOrDefault(i => i.Id == id);
        }

        public List<String> GetAllAssignedBrandByEquipmentType(string type)
        {
            return _context.AdminEquipmentDistribution.Where(e => e.Equipments.EquipmentType == type).Select(e => e.Equipments.Brand).Distinct().ToList();
        }

        public List<AdminEquipmentDistribution> GetAll()
        {
            return _context.AdminEquipmentDistribution.ToList();
        }

        public List<AdminEquipmentDistribution> GetAllAssignedEquipmentByManagerId(int managerId)
        {
            var equipmentDistributions = _context.AdminEquipmentDistribution.Include(ach => ach.Equipments)
        .Where(ach => ach.ManagerId == managerId).ToList();

            return equipmentDistributions;
        }

        public AdminEquipmentDistribution FindByTypeAndBrand(string type, string brand)
        {
            return (AdminEquipmentDistribution)_context.AdminEquipmentDistribution.Where(t => t.Equipments.EquipmentType == type && t.Equipments.Brand == brand);
        }
        public List<AdminEquipmentDistribution> GetAllAssignedEquipments()
        {
            var equipmentDistributions = _context.AdminEquipmentDistribution.Include(ach => ach.Manager)
                .Include(man => man.Equipments)
                .ToList();
               
                
      

            return equipmentDistributions;
        }

        public AdminEquipmentDistribution GetDistribution(int id)
        {
            return _context.AdminEquipmentDistribution.Find(id);
        }

        public AdminEquipmentDistribution UpdateDistribution(AdminEquipmentDistribution distribution)
        {
            _context.AdminEquipmentDistribution.Update(distribution);
            _context.SaveChanges();
            return distribution;
        }


        
    }
}
