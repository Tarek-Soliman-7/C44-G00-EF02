using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G00_EF02.Models
{
    internal class Instructor
    {
        [Key]
        public int ID { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        [Range(1, int.MaxValue)]
        public decimal Salary { get; set; }
        [MaxLength(150)]
        public string? Address { get; set; }
        [Range(0, int.MaxValue)]
        public decimal HourRateBouns {  get; set; }
        public int Dept_ID { get; set; }
    }
}
