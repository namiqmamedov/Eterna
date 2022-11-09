using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models
{
    public class Portfolio
    {
        public int Id { get; set; }
        public string Info { get; set; }
        public string Category { get; set; }
        public string Client { get; set; }
        public string Date { get; set; }
        public string URL { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }

    }
}
