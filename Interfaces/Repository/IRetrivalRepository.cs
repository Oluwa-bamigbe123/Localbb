using LocalBetBiga.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocalBetBiga.Interfaces.Repository
{
    public interface IRetrivalRepository
    {
        public Retrival AddRetrival(Retrival retrival);
        public Retrival GetRetrival(int id);
        public void DeleteRetrival(int id);
        public List<Retrival> GetAll();
        public Retrival UpdateRetrival(Retrival retrival);
        public Retrival FindByAgentName(string name);
        public List<Retrival> GetAllRetrivalsByManagerId(int managerId);
    }
}
