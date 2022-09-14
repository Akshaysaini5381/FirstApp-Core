using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace FirstApp_Core.Models
{
    public class student
    {
        [Key]
        [Required]
        public int StudentId { get; set; }
        [Required]
        public string StudentName { get; set; }
        [Required]
        public int StudentRollNo { get; set; }
        [Required]
        public string StudentCity { get; set; }
        [Required]
        public string StudentClass { get; set; }
    }
}
