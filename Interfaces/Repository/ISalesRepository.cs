using LocalBetBiga.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocalBetBiga.Interfaces.Repository
{
    public interface ISalesRepository
    {
        public Sales FindById(int id);
        public List<String> GetAllAssignedBrandByEquipmentType(string type);
        public List<Sales> GetAll();
        public Sales UpdateSales(Sales sales);
        public Sales CreateSales(Sales sales);
        public List<Sales> GetAllSalesByManagerId(int managerId);

        public List<Sales> GetAllSales();
        
    }
}
