using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G00_EF02.Models
{
    [Index(nameof(Name), IsUnique = true)]
    internal class Department
    {
        [Key]
        public int ID { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        public int? Ins_ID { get; set; }
        public DateOnly HiringDate { get; set; }
    }
}
