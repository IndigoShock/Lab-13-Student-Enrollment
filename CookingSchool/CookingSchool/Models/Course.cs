using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CookingSchool.Models
{
    public class Course
    {
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public CourseName CourseName { get; set; }
        [Required]
        public int CourseId { get; set; }

    }

    public enum CourseName
    {
        Sushi,
        Chocolatier,
        LineCook,
        Patisserie
    }
}
