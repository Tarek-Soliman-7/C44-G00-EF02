using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G00_EF02.Models
{
    internal class Course_Inst
    {
        public int Inst_Id { get; set; }
        public int Course_Id { get; set; }
        [Range(1, 10)]
        public int? Evaluate { get; set; }
    }
}
