using StudentAdmission.Configuration.Config;
using StudentAdmission.DAL.GenericRepository;
using StudentAdmission.DAL.Repositories;
using StudentAdmission.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdmission.DAL.Services
{
    public class StudentRepository : RepositoryBase<ApplicationUser>, IStudentRepository
    {
        private readonly ApplicationDbContext _context;
        public StudentRepository(ApplicationDbContext _context) : base(_context)
        {
            
        }
        public async Task<bool> AddStudentAsync(ApplicationUser user)
        {
            await this._context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
