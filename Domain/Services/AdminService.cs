using LocalBetBiga.Interfaces.Repository;
using LocalBetBiga.Interfaces.Services;
using LocalBetBiga.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocalBetBiga.Domain.Services
{
    public class AdminService : IAdminService
    {
        private readonly IAdminRepository _adminRepository;
        public AdminService(IAdminRepository adminRepository)
        {
            _adminRepository = adminRepository;

        }

        public Admin AddAdmin(Admin admin)
        {
            Admin ad = _adminRepository.AddAdmin(admin);
            return ad;
        }

        public void DeleteAdmin(int id)
        {
            _adminRepository.DeleteAdmin(id);
        }

        public Admin FindByEmail(string email)
        {
            return _adminRepository.FindByEmail(email);
        }

        public Admin GetAdmin(int id)
        {
            return _adminRepository.GetAdmin(id);
        }

        public List<Admin> GetAll()
        {
            return _adminRepository.GetAll();
        }

        public Admin Login(string username, string password)
        {
            var admin = _adminRepository.FindByEmail(username);
            if (admin == null || admin.Password != password)
            {
                return null;
            }

            return admin;
        }

        public Admin UpdateAdmin(Admin admin)
        {
            return _adminRepository.UpdateAdmin(admin);
        }
    }
}
