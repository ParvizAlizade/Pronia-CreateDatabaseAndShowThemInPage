using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using P230_Pronia.DAL;
using P230_Pronia.Entities;
using P230_Pronia.Models;
using P230_Pronia.ViewModels;
using System.Diagnostics;

namespace P230_Pronia.Controllers
{
    public class HomeController : Controller
    {
        readonly ProniaDbContext _context;

        public HomeController(ProniaDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Slider> sliders = _context.Sliders.OrderBy(s=>s.Order).ToList();
            List<Plant> plants = _context.Plants.Include(p=>p.PlantImages).ToList();
            HomeVM vm = new HomeVM()
            {
                Sliders = sliders,
                Plants = plants,
            };
            return View(vm);
        }

    }
}