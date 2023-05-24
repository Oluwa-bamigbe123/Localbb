using LocalBetBiga.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocalBetBiga.Interfaces.Repository
{
    public interface IManagerEquipmentDistributionRepository
    {
       
        public ManagerEquipmentDistribution FindById(int id);

        public List<ManagerEquipmentDistribution> GetAll();
        public ManagerEquipmentDistribution UpdateDistribution(ManagerEquipmentDistribution distribution);
        public ManagerEquipmentDistribution CreateDistribution(ManagerEquipmentDistribution Distribution);
        public ManagerEquipmentDistribution FindByAgentName(string agentName);
        public List<ManagerEquipmentDistribution> GetAllAssignedEquipmentByManagertId(int managerId);

        public ManagerEquipmentDistribution GetEquipmentAssignedById(int equipmentId);

        public List<ManagerEquipmentDistribution> GetAllAssignedEquipments();
    }
}
