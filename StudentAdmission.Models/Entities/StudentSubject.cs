using System.ComponentModel.DataAnnotations;

namespace StudentAdmission.Models.Entities
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
