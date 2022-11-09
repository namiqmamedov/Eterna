using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models
{
    public class Description
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<About> Abouts { get; set; }
    }
}
