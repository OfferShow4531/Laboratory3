using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Laboratory6.Data;
using Laboratory6.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Laboratory6.Controllers
{
    public class PlanetController : Controller
    {
        private readonly AuthorizationContext _context;
        // GET: /<controller>/
        public PlanetController(AuthorizationContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.MarsControllers.ToListAsync());
        }


    }  
        
    
}
