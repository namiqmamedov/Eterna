using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.DAL;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class PricingController : Controller
    {
        private readonly AppDbContext _context;
        public PricingController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Pricing> pricings = _context.Pricings
                .Include(p => p.PricingServices)
                .ThenInclude(ps=>ps.PRService).ToList();

            ViewBag.PRServices = _context.PRServices.ToList();

            return View(pricings);
        }
    }
}
