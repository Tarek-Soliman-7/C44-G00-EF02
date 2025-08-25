using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        [InverseProperty(nameof(Department.Students))]
        public Department Department { get; set; }

        public ICollection<Course> Courses { get; set; } = new HashSet<Course>();

        [InverseProperty(nameof(Stud_Course.Student))]
        public ICollection<Stud_Course> stud_courses { get; set; } = new HashSet<Stud_Course>();

    }
}
