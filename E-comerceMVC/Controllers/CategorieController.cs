using E_comerceMVC.Data;
using E_comerceMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_comerceMVC.Controllers
{
    public class CategorieController : Controller
    {

        private readonly ApplicationDbContext _context;

        public CategorieController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]

       public ViewResult products(int id)
        {
            var products = _context.products
          .Where(p => p.catgorie.Id == id)
          .ToList();
            return View(products);

        }
    }
}
