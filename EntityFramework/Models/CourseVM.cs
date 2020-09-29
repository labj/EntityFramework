using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFramework.Models
{
    public class CourseVM
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Subject { get; set; }

        [Display(Name = "Teacher")]
        public string CourseTeacher { get; set; }

        [Display(Name = "Assignment")]
        public List<Assignment> CourseAssignments { get; set; }

        [Display(Name = "Student")]
        public List<Student> CourseStudents { get; set; }
    }
}
