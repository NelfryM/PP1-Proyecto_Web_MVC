using Microsoft.AspNetCore.Mvc;
using System.Linq;
using PP1_Proyecto_Web_MVC.Models;
using PP1_Proyecto_Web_MVC.Data;
using Microsoft.EntityFrameworkCore;

namespace PP1_Proyecto_Web_MVC.Controllers
{
    public class AsignaturasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AsignaturasController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Asignaturas.ToListAsync());
        }
    }
}
