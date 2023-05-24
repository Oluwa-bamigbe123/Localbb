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
    public class ManagerEquipmentDistributionRepository : IManagerEquipmentDistributionRepository
    {
        private readonly ApplicationDbContext _context;

        public ManagerEquipmentDistributionRepository(ApplicationDbContext context)
        {
            _context = context;

        }

        public ManagerEquipmentDistribution CreateDistribution(ManagerEquipmentDistribution equipmentDistribution)
        {
            _context.ManagerEquipmentDistribution.Add(equipmentDistribution);
            _context.SaveChanges();
            return equipmentDistribution;
        }

        public ManagerEquipmentDistribution FindByAgentName(string agentName)
        {
            return _context.ManagerEquipmentDistribution.FirstOrDefault(ag => ag.NameOfAgentAssignedTo == agentName);
        }

        public ManagerEquipmentDistribution FindById(int id)
        {
            return _context.ManagerEquipmentDistribution.FirstOrDefault(i => i.Id == id);
        }

        public List<ManagerEquipmentDistribution> GetAll()
        {
            return _context.ManagerEquipmentDistribution.ToList();
        }

        public ManagerEquipmentDistribution GetDistribution(int id)
        {
            return _context.ManagerEquipmentDistribution.Find(id);
        }

        public ManagerEquipmentDistribution UpdateDistribution(ManagerEquipmentDistribution distribution)
        {
            _context.ManagerEquipmentDistribution.Update(distribution);
            _context.SaveChanges();
            return distribution;
        }

        public List<ManagerEquipmentDistribution> GetAllAssignedEquipmentByManagertId(int managerId)
        {
            var manager = _context.ManagerEquipmentDistribution.Include(ach => ach.Equipment)
        .Where(ach => ach.ManagerId == managerId).ToList();

            return manager;
        }

        public List<ManagerEquipmentDistribution> GetAllAssignedEquipments()
        {
            throw new NotImplementedException();
        }

        public ManagerEquipmentDistribution GetEquipmentAssignedById(int equipmentId)
        {
            return _context.ManagerEquipmentDistribution.FirstOrDefault(eq => eq.EquipmentId == equipmentId);
        }

      
    }
}
