using LocalBetBiga.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocalBetBiga.Interfaces.Services
{
    public interface IAdminEquipmentDistributionService
    {
        public AdminEquipmentDistribution CreateDistribution(int adminId,int managerId, int numberOfEquipment, int equipmentId,  DateTime dateAssigned);
       
        public AdminEquipmentDistribution GetDistribution(int id);
        public List<AdminEquipmentDistribution> GetAll();
        public AdminEquipmentDistribution UpdateDistribution(AdminEquipmentDistribution distribution);
        public List<String> GetAllAssignedBrandByEquipmentType(string type);

        public List<AdminEquipmentDistribution> GetAllAssignedEquipmentByManagerId(int agentId);
        public List<AdminEquipmentDistribution> GetAllAssignedEquipments();
        public AdminEquipmentDistribution FindByTypeAndBrand(string type, string brand);
    }
}
