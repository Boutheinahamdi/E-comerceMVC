using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_comerceMVC.Controllers
{
    [Authorize(Roles = "Manager")]
    public class RoleController : Controller
    {
        private RoleManager<IdentityRole> _roleManager;

        public RoleController(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }
        [Authorize(Roles ="Manager")]
        public IActionResult Index()
        {
            var roles = _roleManager.Roles.ToList();
            return View(roles);
        }
        [HttpGet]
        public IActionResult CreateRole()
        {
           
            return View(new IdentityRole());
        }
        [HttpPost]
        public async Task<IActionResult> CreateRole(IdentityRole role)
        {
            await _roleManager.CreateAsync(role);
            return View();
        }

    }
}
