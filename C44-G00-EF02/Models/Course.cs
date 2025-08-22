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
    internal class Course
    {
        [Key]
        public int ID { get; set; }
        [Range(1, int.MaxValue)]
        public int Duration {  get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(255)]
        public string? Description { get; set; }
        public int Top_ID {  get; set; }

    }
}
