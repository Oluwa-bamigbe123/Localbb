
using LocalBetBiga.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocalBetBiga.Interfaces.Services
{
    public interface IManagerEquipmentDistributionService
    {
        public ManagerEquipmentDistribution CreateDistribution(int managerId, int numberOfEquipment, string agentName,  DateTime dateAssigned, string shopAddress, int equipmentId);

        public ManagerEquipmentDistribution GetDistribution(int id);
        public List<ManagerEquipmentDistribution> GetAll();
        public ManagerEquipmentDistribution UpdateDistribution(ManagerEquipmentDistribution distribution);

        public ManagerEquipmentDistribution FindByAgentname(string agentName);
        public List<ManagerEquipmentDistribution> GetAllAssignedEquipmentByAgentId(int agentId);
        public ManagerEquipmentDistribution GetEquipmentAssignedById(int equipmentId);

        public ManagerEquipmentDistribution DeductEquipment(int equipmentId, int NumberOfEquipment, int managerId);
    }
}
