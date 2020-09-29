using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFramework.Models
{
    public class Assignment
    {
        [Key]
        public int AssignmentId { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage = "Title must be 100 characters or less")]
        public string Title { get; set; }

        [Required]
        [MaxLength(200, ErrorMessage = "Subject must be 200 characters or less")]
        public string Subject { get; set; }

        [ForeignKey("CourseId")]
        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}
