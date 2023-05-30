using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdmission.DAL.Interface
{
    public interface IRepositoryBase<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetById(int id);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
