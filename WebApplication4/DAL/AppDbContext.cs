using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.Models;

namespace WebApplication4.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Setting> settings  { get; set; }      
        public DbSet<Service> Services { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<Pricing> Pricings { get; set; }
        public DbSet<PRService> PRServices { get; set; }
        public DbSet<PricingServices> PricingServices { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Description> Descriptions { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<HomeSlider> HomeSliders { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }

        //public DbSet<AboutClient> AboutClients { get; set; }
    }
}
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        