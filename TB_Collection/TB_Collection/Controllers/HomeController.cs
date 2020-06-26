using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TB_Collection.Data;
using TB_Collection.Models;

namespace TB_Collection.Controllers
{
    public class HomeController : Controller
    {
        public ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (userId != null)
            {
                var collector = _context.Collectors.Where(c => c.IdentityUserId == userId).SingleOrDefault();
                if (collector == null)
                {
                    return RedirectToAction("Create", "Collectors");
                }
            }
            else
            {
                return RedirectToAction("Index", "Collectors");
            }
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
