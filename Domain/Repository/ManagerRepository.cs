using LocalBetBiga.Interfaces.Repository;
using LocalBetBiga.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LocalBetBiga.Models;

namespace LocalBetBiga.Domain.Repository
{
    public class ManagerRepository : IManagerRepository
    {
        private readonly ApplicationDbContext _context;
        public ManagerRepository(ApplicationDbContext context)
        {
            _context = context;

        }

        public Manager AddManager(Manager manager)
        {
            _context.Managers.Add(manager);
            _context.SaveChanges();
            return manager;
        }

        public void DeleteManager(int id)
        {
         
            var manager = _context.Managers.Find(id);
            if(manager != null)
            {
                _context.Remove(manager);
                _context.SaveChanges();
            }
          
        }

        public Manager FindByPhoneNumber(string phoneNumber)
        {
            Models.Entities.Manager manager1 = new Models.Entities.Manager
            {
                PhoneNumber = phoneNumber
            };
            return _context.Managers.FirstOrDefault(i => i.PhoneNumber == phoneNumber);
        }

        public Manager FindByUserName(string userName)
        {
            return _context.Managers.FirstOrDefault(u => u.UserName == userName);
        }

        public List<Manager> GetAll()
        {
            return _context.Managers.ToList();
        }

        public Manager GetManager(int id)
        {
            return _context.Managers.Find(id);
        }

        public Manager GetManagerByEmail(string email)
        {
            return _context.Managers.FirstOrDefault(m => m.Email == email);
        }

        public Manager UpdateManager(Manager manager)
        {
            _context.Managers.Update(manager);
            _context.SaveChanges();
            return manager;
        }
    }
}
