
using LocalBetBiga.Interfaces.Repository;
using LocalBetBiga.Interfaces.Services;
using LocalBetBiga.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocalBetBiga.Domain.Services
{
    public class ManagerEquipmentDistributionService : IManagerEquipmentDistributionService
    {
        private readonly IManagerEquipmentDistributionRepository _managerEquipmentDistributionRepository;
        private readonly IEquipmentRepository _equipmentRepository;
        private readonly IManagerRepository _managerRepository;
        private readonly ICategoryRepository _categoryRepository;
       


        public ManagerEquipmentDistributionService(IManagerEquipmentDistributionRepository managerEquipmentDistribution, IEquipmentRepository equipmentRepository, IAdminRepository adminRepository, IManagerRepository managerRepository, ICategoryRepository categoryRepository)
        {
            _managerEquipmentDistributionRepository = managerEquipmentDistribution;
            _equipmentRepository = equipmentRepository;
            _managerRepository = managerRepository;
            _categoryRepository = categoryRepository;

        }

        public ManagerEquipmentDistribution CreateDistribution(int managerId, int numberOfEquipment, string agentName, DateTime dateAssigned, string shopAddress, int equipmentId)
        {
            {

              



                ManagerEquipmentDistribution managerEquipmentDistribution = new ManagerEquipmentDistribution
                {

                    ManagerId = managerId,
                    DateAssigned = dateAssigned,
                    NumberOfEquipmentAssigned = numberOfEquipment,
                    NameOfAgentAssignedTo = agentName,
                    ShopAddress = shopAddress,
                    EquipmentId = equipmentId




                };

                return _managerEquipmentDistributionRepository.CreateDistribution(managerEquipmentDistribution);
            }
        }

        public ManagerEquipmentDistribution DeductEquipment(int equipmentId, int numberOfEquipment, int managerId)
        {
            ManagerEquipmentDistribution equipment = _managerEquipmentDistributionRepository.GetEquipmentAssignedById(equipmentId);

            Manager manager = _managerRepository.GetManager(managerId);

            equipment.NumberOfEquipmentAssigned -= numberOfEquipment;

            _managerEquipmentDistributionRepository.UpdateDistribution(equipment);

            return equipment;
        }

        public ManagerEquipmentDistribution FindByAgentname(string agentName)
        {
            return _managerEquipmentDistributionRepository.FindByAgentName(agentName);
        }

       

        public List<ManagerEquipmentDistribution> GetAll()
        {
            return _managerEquipmentDistributionRepository.GetAll();
        }

        public List<ManagerEquipmentDistribution> GetAllAssignedEquipmentByAgentId(int agentId)
        {
            return _managerEquipmentDistributionRepository.GetAllAssignedEquipmentByManagertId(agentId);
        }

        public ManagerEquipmentDistribution GetDistribution(int id)
        {
            return _managerEquipmentDistributionRepository.FindById(id);
        }

        public Equipments GetEquipmentAssignedById(int equipmentId)
        {
            return _equipmentRepository.FindById(equipmentId);
        }

        public ManagerEquipmentDistribution UpdateDistribution(ManagerEquipmentDistribution distribution)
        {
            return _managerEquipmentDistributionRepository.UpdateDistribution(distribution);
        }

        ManagerEquipmentDistribution IManagerEquipmentDistributionService.GetEquipmentAssignedById(int equipmentId)
        {
            throw new NotImplementedException();
        }
    }
    }
