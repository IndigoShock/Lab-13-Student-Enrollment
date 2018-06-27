using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CookingSchool.Data;
using CookingSchool.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CookingSchool.Controllers
{
    public class CourseController : Controller
    {
        private CookingDbContext _context;

        public CourseController(CookingDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("ID, Name, CourseName, CourseId")]Course course)
        {

            await _context.Courses.AddAsync(course);
            await _context.SaveChangesAsync();

            int id = course.ID;
            return View();
        }
    }
}