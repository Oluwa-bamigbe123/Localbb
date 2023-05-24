﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocalBetBiga.Domain.Entities
{
    public class Sales : BaseEntity
    {
        public string TotalSales { get; set; }

        public string TotalWinnings { get; set; }

        public string TotalGGR { get; set; }

        public string Commission { get; set; }

        public string NGR { get; set; }


        public string ProjectedSales { get; set; }

        public string ActualSales { get; set; }

        public string PecentageOfSalesComparedToProjectedSales { get; set; }

    }
}
