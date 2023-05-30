using Microsoft.EntityFrameworkCore;
using StudentAdmission.Configuration.Config;
using StudentAdmission.DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdmission.DAL.GenericRepository
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected readonly ApplicationDbContext _context;
        public RepositoryBase(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<T>> GetAllAsync() => _context.Set<T>().AsNoTracking();

        public async Task<T> GetById(int id) => await _context.Set<T>().FindAsync(id);

        public void Create(T entity) => _context.Set<T>().Add(entity);
        public void Update(T entity) => _context.Set<T>().Update(entity);
        public void Delete(T entity) => _context.Set<T>().Remove(entity);
    }
}
