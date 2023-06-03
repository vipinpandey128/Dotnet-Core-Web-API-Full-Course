using StudentAdmission.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdmission.Models.Interface
{
    public interface IStudentRepository
    {
        Task<bool> AddStudentAsync(ApplicationUser user);
    }
}
