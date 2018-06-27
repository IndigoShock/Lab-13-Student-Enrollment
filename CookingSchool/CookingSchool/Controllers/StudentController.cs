using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CookingSchool.Data;
using Microsoft.AspNetCore.Mvc;

namespace CookingSchool.Controllers
{
    public class StudentController : Controller
    {
        private CookingDbContext _context;

        public StudentController(CookingDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}