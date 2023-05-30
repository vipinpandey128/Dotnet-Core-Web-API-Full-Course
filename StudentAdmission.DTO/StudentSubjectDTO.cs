using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdmission.DTOs
{
    public class StudentSubjectDTO
    {
        public int StudentSubjectId { get; set; }
        public string StudentId { get; set; }
        public int SubjectId { get; set; }
        public int Sem { get; set; }
    }
}
