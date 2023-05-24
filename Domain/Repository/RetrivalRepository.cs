using LocalBetBiga.Interfaces.Repository;
using LocalBetBiga.Models;
using LocalBetBiga.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocalBetBiga.Domain.Repository
{
    public class RetrivalRepository : IRetrivalRepository
    {
        private readonly ApplicationDbContext _context;
        public RetrivalRepository(ApplicationDbContext context)
        {
            _context = context;

        }

        public Retrival AddRetrival(Retrival retrival)
        {
            _context.Retrivals.Add(retrival);
            _context.SaveChanges();
            return retrival;
        }

        public void DeleteRetrival(int id)
        {
            var retrival = _context.Admins.Find(id);
            _context.Remove(retrival);
            _context.SaveChanges();
        }

        public Retrival FindByAgentName(string name)
        {
            return _context.Retrivals.FirstOrDefault(i => i.NameOfAgent == name);
        }

        public List<Retrival> GetAll()
        {
            return _context.Retrivals.Include(c => c.Manager).ToList();

        }

        public List<Retrival> GetAllRetrivalsByManagerId(int managerId)
        {
            return _context.Retrivals.Where(m => m.ManagerId == managerId).ToList();
        }

        public Retrival GetRetrival(int id)
        {
            return _context.Retrivals.Find(id);
        }

        public Retrival UpdateRetrival(Retrival retrival)
        {
            _context.Retrivals.Update(retrival);
            _context.SaveChanges();
            return retrival;
        }
    }
}
