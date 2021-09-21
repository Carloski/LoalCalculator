using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoalCalculator.Models
{
    public class Loan
    {
        public decimal Amount { get; set; }

        public decimal Rate { get; set; }

        public int Term { get; set; }

        public int Payment { get; set; }

        public decimal TotalInterest { get; set; }

        public decimal TotalCost { get; set; }
    }
}
