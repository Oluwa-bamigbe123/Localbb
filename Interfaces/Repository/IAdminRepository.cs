using LocalBetBiga.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocalBetBiga.Interfaces.Repository
{
    public interface IAdminRepository
    {
        public Admin AddAdmin(Admin admin);
        public Admin GetAdmin(int id);
        public void DeleteAdmin(int id);
        public List<Admin> GetAll();
        public Admin UpdateAdmin(Admin admin);
        public Admin FindByEmail(string email);
    }
}
