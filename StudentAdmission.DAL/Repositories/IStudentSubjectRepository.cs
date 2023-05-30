using StudentAdmission.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdmission.DAL.Repositories
{
    public interface IStudentSubjectRepository
    {
        Task<bool> AddStudentSubjectAsync(StudentSubject subject);
    }
}
