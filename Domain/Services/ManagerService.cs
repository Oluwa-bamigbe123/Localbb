using LocalBetBiga.Interfaces.Repository;
using LocalBetBiga.Interfaces.Services;
using LocalBetBiga.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocalBetBiga.Domain.Services
{
    public class ManagerService : IManagerService
    {
        private readonly IManagerRepository _managerRepository;
        public ManagerService(IManagerRepository managerRepository)
        {
            _managerRepository = managerRepository;

        }
        public Manager AddManager(Manager manager)
        {
            Manager mn = _managerRepository.AddManager(manager);
            return mn;
        }

        public void DeleteManager(int id)
        {
            _managerRepository.DeleteManager(id);
        }

        public Manager FindByPhoneNumber(string phoneNumber)
        {
            return _managerRepository.FindByPhoneNumber(phoneNumber);
        }

        public Manager FindByUserName(string userName)
        {
            return _managerRepository.FindByUserName(userName);
        }

        public List<Manager> GetAll()
        {
            return _managerRepository.GetAll();
        }

        public Manager GetManager(int id)
        {
            return _managerRepository.GetManager(id);
        }

        public Manager GetManagerByEmail(string email)
        {
            return _managerRepository.GetManagerByEmail(email);
        }

        public Manager Login(string username, string password)
        {
            var manager = _managerRepository.GetManagerByEmail(username);
            if (manager == null || manager.Password != password)
            {
                return null;
            }

            return manager;
        }

        public Manager UpdateManager(Manager manager)
        {
            return _managerRepository.UpdateManager(manager);
        }
    }
}
