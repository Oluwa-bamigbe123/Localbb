using LocalBetBiga.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocalBetBiga.Interfaces.Services
{
    public interface IEquipmentService
    {
        public Equipments AddEquipment(Equipments equipments);
        public Equipments FindEquipmentById(int id);

        public void DeleteEquipment(int id);

        public List<Equipments> GetAll();
        public Equipments UpdateEquipment(Equipments equipments);
        public Equipments DeductEquipment(int equipmentId, int NumberOfEquipment);
        public Equipments UpdateEquipmentNumber(int id, int numberToBeAdded);
        public Equipments FindByTypeAndBrand(string type, string brand);
        public List<Equipments> FindByCategoryId(int id);
        public List<String> GetAllBrandByEquipmentType(string type);
    }
}
