using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFramework.Models
{
    public class Teacher
    {
        [Key]
        public int TeacherId { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage = "Name must be 100 characters or less")]
        public string Name { get; set; }
 
        public string PhoneNo { get; set; }

        public string Email { get; set; }

        public Course Course { get; set; }
    }
}
