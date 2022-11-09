using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models
{
    public class Trainer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public string FacebookURL { get; set; }
        public string InstagramURL { get; set; }
        public string LinkedinURL { get; set; }
        public string TwitterURL { get; set; }

        public int PositionId { get; set; }
        public Position Position { get; set; }
    }
}
