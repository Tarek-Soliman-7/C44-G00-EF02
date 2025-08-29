using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G00_EF02.Models
{
    internal class Topic
    {
        [Key]
        public int ID { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }

        [InverseProperty(nameof(Course.Topic))]
        public ICollection<Course>? Courses { get; set; } = new HashSet<Course>();


    }
}
