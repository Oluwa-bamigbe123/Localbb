
using LocalBetBiga.Interfaces.Repository;
using LocalBetBiga.Interfaces.Services;
using LocalBetBiga.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocalBetBiga.Domain.Services
{
    public class AdminEquipmentDistributionService : IAdminEquipmentDistributionService
    {
        private readonly IAdminEquipmentDistributionRepository _adminEquipmentRepository;
        private readonly IEquipmentRepository _equipmentRepository;
        private readonly IManagerRepository _managerRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IAdminRepository _adminRepository;


        public AdminEquipmentDistributionService(IAdminEquipmentDistributionRepository adminEquipmentDistribution, IEquipmentRepository equipmentRepository, IAdminRepository adminRepository, IManagerRepository managerRepository, ICategoryRepository categoryRepository)
        {
            _adminEquipmentRepository = adminEquipmentDistribution;
            _equipmentRepository = equipmentRepository;
            _managerRepository = managerRepository;
            _categoryRepository = categoryRepository;
            _adminRepository = adminRepository;
        }



        public AdminEquipmentDistribution CreateDistribution(int adminId,int managerId, int numberOfEquipment, int equipmentId, DateTime dateAssigned)
        {
            
            AdminEquipmentDistribution adminEquipmentDistribution = new AdminEquipmentDistribution
            {
                AdminId = adminId,
                ManagerId = managerId,
                DateAssigned = dateAssigned,
                NumberOfEquipmentAssigned = numberOfEquipment,
                EquipmentsId = equipmentId,

            };

            return _adminEquipmentRepository.CreateDistribution(adminEquipmentDistribution);


        }

        public AdminEquipmentDistribution FindByTypeAndBrand(string type, string brand)
        {
            return _adminEquipmentRepository.FindByTypeAndBrand(type, brand);
        }

        public List<AdminEquipmentDistribution> GetAll()
        {
            return _adminEquipmentRepository.GetAll();
        }

        public List<string> GetAllAssignedBrandByEquipmentType(string type)
        {
            return _adminEquipmentRepository.GetAllAssignedBrandByEquipmentType(type);
        }

        public List<AdminEquipmentDistribution> GetAllAssignedEquipmentByManagerId(int managerId)
        {
            return _adminEquipmentRepository.GetAllAssignedEquipmentByManagerId(managerId);
        }

       

        public List<AdminEquipmentDistribution> GetAllAssignedEquipments()
        {
            return _adminEquipmentRepository.GetAllAssignedEquipments();
        }

        public AdminEquipmentDistribution GetDistribution(int id)
        {
            return _adminEquipmentRepository.FindById(id);
        }

        public AdminEquipmentDistribution UpdateDistribution(AdminEquipmentDistribution distribution)
        {
            return _adminEquipmentRepository.UpdateDistribution(distribution);
        }

        //public AdminEquipmentDistribution GetTotalNumberOfEquipmentAssignedToManager(int managerId, string equipmentName, int totalNumberOfEquipment)
        //{
        //    Manager manager = _managerRepository.GetManager(managerId);

        //    manager.Id = managerId;

        //    //AdminEquipmentDistribution equipmentDistribution = _adminEquipmentRepository.
        //}
    }
}
