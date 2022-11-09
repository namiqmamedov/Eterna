using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models
{
    public class About
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }
        public string Info { get; set; }
        public string Text { get; set; }

        public int DescriptionId { get; set; }
        public Description Description { get; set; }

    }

    //public class AboutClient
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public string Description { get; set; }
    //}
}
