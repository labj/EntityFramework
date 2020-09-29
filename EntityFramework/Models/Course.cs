using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFramework.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage = "Title must be 100 characters or less")]
        public string Title { get; set; }

        [Required]
        [MaxLength(200, ErrorMessage = "Subject must be 200 characters or less")]
        public string Subject { get; set; }
        
        [Required]
        public int Points { get; set; }


        [ForeignKey("TeacherId")]
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }

        public List<Assignment> Assignments { get; set; }

        public List<StudentCourse> StudentCourses { get; set; }

    }
}
