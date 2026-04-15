using Kias_Kar_Kompany.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Kias_Kar_Kompany.Models;

namespace Kias_Kar_Kompany.Controllers
{
    public class ManufacturersController : Controller
    {

        private readonly Kias_Kar_KompanyContext _context;

        public ManufacturersController(Kias_Kar_KompanyContext context)
        {
            _context = context;
        }

        // GET: ManufacturersController
        public async Task<ActionResult> Index()
        {
            var Kias_Kar_KompanyContext = _context.Vehicle.Include(e => e.Manufacturer).Include(e => e.Owner);
            return View(await _context.Manufacturer.ToListAsync());
        }

        
        // GET: ManufacturersController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ManufacturersController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Manufacturer manufacturer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(manufacturer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            
            return View(manufacturer);
            
        }

        // GET: ManufacturersController/Edit/5
        
    }
}
