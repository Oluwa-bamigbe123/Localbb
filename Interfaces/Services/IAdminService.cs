using LocalBetBiga.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocalBetBiga.Interfaces.Services
{
    public interface IAdminService
    {
        public Admin AddAdmin(Admin admin);


        public Admin GetAdmin(int id);

        public void DeleteAdmin(int id);

        public List<Admin> GetAll();
        public Admin UpdateAdmin(Admin admin);
        public Admin Login(string username, string password);
        public Admin FindByEmail(string email);
    }
}
