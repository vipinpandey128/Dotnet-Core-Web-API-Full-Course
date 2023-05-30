using Microsoft.EntityFrameworkCore;
using StudentAdmission.Configuration.Config;
using StudentAdmission.DAL.Interface;
using StudentAdmission.DAL.Repositories;
using StudentAdmission.DAL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdmission.DAL.GenericRepository
{
    public abstract class RepositoryWrapper : IRepositoryWrapper
    {
        private ApplicationDbContext _context;
        private IStudentRepository _student;
        
        public IStudentRepository Student
        {
            get
            {
                if(_student == null)
                {
                    _student = new StudentRepository(_context);
                }
                return _student;
            }
        }

        public RepositoryWrapper(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
