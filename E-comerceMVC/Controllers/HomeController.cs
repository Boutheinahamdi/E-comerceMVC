using E_comerceMVC.Models;
using E_comerceMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_comerceMVC.Controllers
{
    public class HomeController : Controller
    {

        private readonly IUnitOfWork<Catgorie> _categorie;
        private readonly IUnitOfWork<Product> _product;

        public HomeController(IUnitOfWork<Catgorie> categorie, IUnitOfWork<Product> product)

        {

            _categorie = categorie;
            _product = product;

        }
        public IActionResult Index()
        {
            var categorieView = new CategorieViewModel
            {
                catgorie = _categorie.Entity.GetAll().ToList()




            };
            return View(categorieView);

        }
        public IActionResult Cart()
        {
            
            return View();

        }
        public IActionResult Details(int id)
        {




            return View();
        }
        public IActionResult Shop()
        {
            var ProduitView = new PorductViewModel
            {
                product = _product.Entity.GetAll().ToList()




            };
            return View(ProduitView);
        }
    }
}
