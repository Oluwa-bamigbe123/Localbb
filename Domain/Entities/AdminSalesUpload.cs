using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocalBetBiga.Domain.Entities
{
    public class AdminSalesUpload : BaseEntity
    {
        public Sales Sales{ get; set; }

        public string TotalSales { get; set; }

        public string TotalWinnings { get; set; }

        public string GGR { get; set; }

        public string NGR { get; set; }

        public string ProjectedSales { get; set; }

        public string ActualSales { get; set; }

        public int SalesId { get; set; }

        public Manager Manager { get; set; }

        public int ManagerId { get; set; }

        public Admin Admin { get; set; }

        public int AdminId { get; set; }


        public DateTime DateAssigned { get; set; }

        public string PecentageOfSalesComparedToProjectedSales { get; set; }
    }
}
