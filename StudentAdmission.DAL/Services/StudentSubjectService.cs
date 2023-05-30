using StudentAdmission.Configuration.Config;
using StudentAdmission.DAL.Repositories;
using StudentAdmission.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdmission.DAL.Services
{
    public class StudentSubjectService : IStudentSubjectRepository
    {
        private readonly ApplicationDbContext _context;
        public StudentSubjectService(ApplicationDbContext _context)
        {
            this._context = _context;
        }
        public async Task<bool> AddStudentSubjectAsync(StudentSubject subject)
        {
            await this._context.StudentSubjects.AddAsync(subject);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
