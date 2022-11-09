using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models
{
    public class PricingServices
    {
        public int Id { get; set; }

        public int PricingId { get; set; }
        public Pricing Pricing { get; set; }
        public int PRServiceId { get; set; }
        public PRService PRService { get; set; }

    }
}
