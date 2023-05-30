using StudentAdmission.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdmission.DAL.Interface
{
    public interface IRepositoryWrapper
    {
       IStudentRepository Student { get; }
        void Save();
    }
}
