using LocalBetBiga.Interfaces.Repository;
using LocalBetBiga.Interfaces.Services;
using LocalBetBiga.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocalBetBiga.Domain.Services
{
    public class RetrivalService : IRetrivalService
    {
        private readonly IRetrivalRepository _retrival;
        public RetrivalService(IRetrivalRepository retrivalRepository)
        {
            _retrival = retrivalRepository;

        }

        public Retrival AddRetrival(int managerId, string nameOfAgent, string equipmentName, string nameOfAgentReassignedTo, DateTime dateRetrieved)
        {
            Retrival retrival = new Retrival
            {
                ManagerId = managerId,
                NameOfAgent = nameOfAgent,
                NameOfEquipmentRetrieved = equipmentName,
                NameOfAgentReassignedTo = nameOfAgentReassignedTo,
                DateRetrieved = DateTime.Now,
            };

            return _retrival.AddRetrival(retrival);
        }

        public void DeleteRetrival(int id)
        {
            _retrival.DeleteRetrival(id);
        }

        public Retrival FindByAgentName(string name)
        {
           return  _retrival.FindByAgentName(name);
        }

        public List<Retrival> GetAll()
        {
            return _retrival.GetAll();
        }

        public List<Retrival> GetAllRetrivalsByManagerId(int managerId)
        {
            return _retrival.GetAllRetrivalsByManagerId(managerId);
        }

        public Retrival GetRetrival(int id)
        {
            return _retrival.GetRetrival(id);
        }

        public Retrival UpdateRetrival(Retrival retrival)
        {
            return _retrival.UpdateRetrival(retrival);
        }
    }
}
