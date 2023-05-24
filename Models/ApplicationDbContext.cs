using LocalBetBiga.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocalBetBiga.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Equipments> Equipments { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<AdminEquipmentDistribution> AdminEquipmentDistribution { get; set; }
        public DbSet<Retrival> Retrivals { get; set; }
        public DbSet<Sales> Sales { get; set; }

        public DbSet<ManagerEquipmentDistribution> ManagerEquipmentDistribution { get; set; }

    }
}
