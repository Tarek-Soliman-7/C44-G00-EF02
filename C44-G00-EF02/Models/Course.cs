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

        [InverseProperty(nameof(Topic.Courses))]
        public Topic Topic { get; set; } = null!;

        public ICollection<Student> Students { get; set; } = new HashSet<Student>();
        [InverseProperty(nameof(Stud_Course.Course))]
        public ICollection<Stud_Course> stud_courses { get; set; } = new HashSet<Stud_Course>();

        [InverseProperty(nameof(Course_Inst.Course))]
        public ICollection<Course_Inst>? Course_Insts { get; set; } = new HashSet<Course_Inst>();


    }
}
