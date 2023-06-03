using StudentAdmission.DAL.Config;
using StudentAdmission.DAL.Repositories;
using StudentAdmission.DAL.Repositories.GenericRepository;
using StudentAdmission.Models.Entities;
using StudentAdmission.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdmission.DAL.Repositories
{
    public class StudentSubjectRepository : RepositoryBase<StudentSubject>, IStudentSubjectRepository
    {
        public StudentSubjectRepository(ApplicationDbContext _context) : base(_context)
        {
             
        }
    }
}
