using Kias_Kar_Kompany.Data;
using Kias_Kar_Kompany.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Kias_Kar_Kompany.Controllers
{
    public class OwnerController : Controller
    {
        private readonly Kias_Kar_KompanyContext _context;

        public OwnerController(Kias_Kar_KompanyContext context)
        {
            _context = context;
        }

        // GET: OwnerController
        public async Task<ActionResult> Index()
        {
            var Kias_Kar_KompanyContext = _context.Vehicle.Include(e => e.Manufacturer).Include(e => e.Owner);
            return View(await _context.Manufacturer.ToListAsync());
        }


        // GET: VehiclesController/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var owner = await _context.Owner
                .FirstOrDefaultAsync(m => m.OwnerId == id);
            if (owner == null)
            {
                return NotFound();
            }
            return View(owner);
        }



        // GET: OwnerController/Create
        public ActionResult Create()
        {
            return View();
        }


        // POST: OwnerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OwnerID, Name, E-Mail, PhoneNumber")] Owner owner)
        {
            if (ModelState.IsValid)
            {
                _context.Add(owner);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(owner);
        }

        // GET: OwnerController/Edit/5

        private bool OwnerExists(int id)
        {
            return _context.Owner.Any(e => e.OwnerId == id);
        }

      
    }
}
       

 