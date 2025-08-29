using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        //[InverseProperty(nameof(Instructor.MangedDepartment))]
        public Instructor Manager { get; set; }
        //[ForeignKey(nameof(Manager))]
        public int? Ins_ID { get; set; }
        public DateOnly HiringDate { get; set; }

        [InverseProperty(nameof(Instructor.InstructorDepartment))]
        public ICollection<Instructor> Instructors { get; set; } = new HashSet<Instructor>();

        [InverseProperty(nameof(Student.Department))]
        public ICollection<Student>? Students { get; set; } = new HashSet<Student>();
    }
}
