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
