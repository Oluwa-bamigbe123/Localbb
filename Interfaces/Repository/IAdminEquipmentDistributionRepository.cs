using LocalBetBiga.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocalBetBiga.Interfaces.Repository
{
    public interface IAdminEquipmentDistributionRepository
    {
        public AdminEquipmentDistribution FindById(int id);
        public List<String> GetAllAssignedBrandByEquipmentType(string type);
        public List<AdminEquipmentDistribution> GetAll();
        public AdminEquipmentDistribution UpdateDistribution(AdminEquipmentDistribution distribution);
        public AdminEquipmentDistribution CreateDistribution(AdminEquipmentDistribution equipmentDistribution);
        public List<AdminEquipmentDistribution> GetAllAssignedEquipmentByManagerId(int managerId);

        public List<AdminEquipmentDistribution> GetAllAssignedEquipments();
        public AdminEquipmentDistribution FindByTypeAndBrand(string type, string brand);
    }
}
