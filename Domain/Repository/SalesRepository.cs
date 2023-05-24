using LocalBetBiga.Domain.Entities;
using LocalBetBiga.Interfaces.Repository;
using LocalBetBiga.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocalBetBiga.Domain.Repository
{
    public class SalesRepository : ISalesRepository
    {

        private readonly ApplicationDbContext _context;

        public SalesRepository(ApplicationDbContext context)
        {
            _context = context;

        }
        public Sales CreateSales(Sales sales)
        {
            throw new NotImplementedException();
        }

        public Sales FindById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Sales> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<string> GetAllAssignedBrandByEquipmentType(string type)
        {
            throw new NotImplementedException();
        }

        public List<Sales> GetAllSales()
        {
            throw new NotImplementedException();
        }

        public List<Sales> GetAllSalesByManagerId(int managerId)
        {
            throw new NotImplementedException();
        }

        public Sales UpdateSales(Sales sales)
        {
            throw new NotImplementedException();
        }
    }
}
