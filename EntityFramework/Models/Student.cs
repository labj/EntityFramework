using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFramework.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage = "Name must be 100 characters or less")]
        public string Name { get; set; }

        public string City { get; set; }

        public string PhoneNo { get; set; }

        public List<StudentCourse> StudentCourses { get; set; }
    }
}
