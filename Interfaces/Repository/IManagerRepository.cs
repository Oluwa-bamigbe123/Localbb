using LocalBetBiga.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocalBetBiga.Interfaces.Repository
{
    public interface IManagerRepository
    {
        public Manager AddManager(Manager manager);
        public Manager GetManager(int id);
        public void DeleteManager(int id);
        public List<Manager> GetAll();
        public Manager UpdateManager(Manager manager);
        public Manager GetManagerByEmail(string email);
        public Manager FindByPhoneNumber(string phoneNumber);
        public Manager FindByUserName(string userName);
    }
}
