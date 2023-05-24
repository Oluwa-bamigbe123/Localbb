using LocalBetBiga.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocalBetBiga.Interfaces.Repository
{
    public interface IEquipmentRepository
    {
        public Equipments AddEquipment(Equipments equipments);

        public Equipments FindById(int id);
        public Equipments FindByProductId(int id);
        public void DeleteEquipment(int id);
        public List<Equipments> GetAll();
        public Equipments UpdateEquipments(Equipments equipments);
        public Equipments FindByTypeAndBrand(string type, string brand);
        public Equipments FindByType(string type);

        public List<Equipments> FindByCategoryId(int id);
        public List<String> GetAllBrandByEquipmentType(string type);

    }
}
