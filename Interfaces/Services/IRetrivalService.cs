using LocalBetBiga.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocalBetBiga.Interfaces.Services
{
    public interface IRetrivalService
    {
        public Retrival AddRetrival(int managerId, string nameOfAgent, string equipmentName, string nameOfAgentReassignedTo,DateTime dateRetrieved);
        public Retrival GetRetrival(int id);
        public void DeleteRetrival(int id);
        public List<Retrival> GetAll();
        public Retrival UpdateRetrival(Retrival retrival);
        public Retrival FindByAgentName(string name);
        public List<Retrival> GetAllRetrivalsByManagerId(int managerId);
    }
}
