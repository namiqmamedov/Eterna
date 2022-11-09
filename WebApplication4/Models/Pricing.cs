using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models
{
    public class Pricing
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public bool IsBuy { get; set; }
        public bool isFeatured { get; set; }

        public List<PricingServices> PricingServices { get; set; }

    }
}
