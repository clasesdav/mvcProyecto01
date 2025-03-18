using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using mvcProyecto.Data;

namespace mvcProyecto.Controllers
{
    public class AlmacenesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AlmacenesController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.Almacen.ToListAsync());
        }
    }
}
