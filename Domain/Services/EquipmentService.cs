using LocalBetBiga.Interfaces.Repository;
using LocalBetBiga.Interfaces.Services;
using LocalBetBiga.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocalBetBiga.Domain.Services
{
    public class EquipmentService : IEquipmentService
    {
        private readonly IEquipmentRepository _equipmentRepository;
        private readonly IManagerRepository _managerRepository;
       


        public EquipmentService(IEquipmentRepository equipmentRepository,  IManagerRepository managerRepository)
        {
            _equipmentRepository = equipmentRepository;
            _managerRepository = managerRepository;
           
        }
        public Equipments AddEquipment(Equipments equipments)
        {
            Equipments eq = _equipmentRepository.AddEquipment(equipments);
            return eq;
        }

        public Equipments DeductEquipment(int equipmentId, int numberOfEquipment)
        {
            Equipments equipment = _equipmentRepository.FindById(equipmentId);
            equipment.NumberInStore -= numberOfEquipment;
            _equipmentRepository.UpdateEquipments(equipment);

            return equipment;

        }

        





        public void DeleteEquipment(int id)
        {
            _equipmentRepository.DeleteEquipment(id);
        }

        public List<Equipments> FindByCategoryId(int id)
        {
            return _equipmentRepository.FindByCategoryId(id);
        }

        public Equipments FindByTypeAndBrand(string type, string brand)
        {
            return _equipmentRepository.FindByTypeAndBrand(type, brand);
        }

        public Equipments FindEquipmentById(int id)
        {
            return _equipmentRepository.FindById(id);
        }

        public List<Equipments> GetAll()
        {
            return _equipmentRepository.GetAll();
        }

        public List<string> GetAllBrandByEquipmentType(string type)
        {
            return _equipmentRepository.GetAllBrandByEquipmentType(type);
        }

        public Equipments UpdateEquipment(Equipments equipments)
        {
            return _equipmentRepository.UpdateEquipments(equipments);
        }

        public Equipments UpdateEquipmentNumber(int id, int numberToBeAdded)
        {
            Equipments equipments = _equipmentRepository.FindById(id);

            equipments.NumberInStore += numberToBeAdded;

            _equipmentRepository.UpdateEquipments(equipments);

            return equipments;
        }
    }
}
