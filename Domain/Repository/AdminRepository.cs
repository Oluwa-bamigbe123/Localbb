using LocalBetBiga.Interfaces.Repository;
using LocalBetBiga.Models;
using LocalBetBiga.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocalBetBiga.Domain.Repository
{
    public class AdminRepository : IAdminRepository
    {
        private readonly ApplicationDbContext _context;
        public AdminRepository(ApplicationDbContext context)
        {
            _context = context;

        }

        public Admin AddAdmin(Admin admin)
        {
            _context.Admins.Add(admin);
            _context.SaveChanges();
            return admin;
        }

        public void DeleteAdmin(int id)
        {
            var admin = _context.Admins.Find(id);
            _context.Remove(admin);
            _context.SaveChanges();
        }

        public Admin FindByEmail(string email)
        {
            return _context.Admins.FirstOrDefault(i => i.Email == email);
        }

        public Admin GetAdmin(int id)
        {
            return _context.Admins.Find(id);
        }

        public List<Admin> GetAll()
        {
            return _context.Admins.ToList();
        }

        public Admin UpdateAdmin(Admin admin)
        {
            _context.Admins.Update(admin);
            _context.SaveChanges();
            return admin;
        }
    }
}
