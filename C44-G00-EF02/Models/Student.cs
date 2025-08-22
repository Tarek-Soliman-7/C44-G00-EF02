using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G00_EF02.Models
{
    internal class Student
    {
        [Key]
        public int ID { get; set; }
        [MaxLength(50)]
        public string FName { get; set; }
        [MaxLength(50)]
        public string LName { get; set; }
        [MaxLength(150)]
        public string? Address { get; set; }
        [Range(18,60,ErrorMessage ="Age must be between 18:60.")]
        public int Age { get; set; }
        public int Dep_Id { get; set; }
    }
}
