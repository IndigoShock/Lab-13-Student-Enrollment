using CookingSchool.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookingSchool.Data
{
    public class CookingDbContext : DbContext
    {
        public CookingDbContext(DbContextOptions<CookingDbContext> options) : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }

        public DbSet<Course> Courses { get; set; }

    }
}
