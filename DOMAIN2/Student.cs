using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DOMAIN2
{
    public class Student
    {
        [Key]
        public int studentID { get; set; }
        [Required]
        public string studentName { get; set; }
        [Required]
        public string studentLastName { get; set; }
        [Required]
        public int studentCode { get; set; }
        [Required]
        public string studentAdress { get; set; }
    }
}
