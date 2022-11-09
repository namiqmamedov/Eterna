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
    public class AboutController : Controller
    {
        private readonly AppDbContext _context;
        public AboutController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<About> abouts = _context.Abouts.Include(a => a.Description).ToList();
            ViewBag.Descriptions = _context.Descriptions.ToList();
            return View(abouts);

            
        }
        //public IActionResult AboutClient()
        //{
        //    List<AboutClient> aboutClients = _context.AboutClients.ToList();
        //    return View(aboutClients);
        //}

        
    }
}
