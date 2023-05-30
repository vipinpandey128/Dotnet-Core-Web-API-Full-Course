using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdmission.Models
{
    public class StudentSubject
    {
        [Key]
        public int StudentSubjectId { get; set; }
        public string StudentId { get; set; }
        public int SubjectId { get; set; }
        public int Sem { get; set; }
    }
}
