using StudentAdmission.DAL.Config;
using StudentAdmission.Models.Interface;

namespace StudentAdmission.DAL.Repositories.GenericRepository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private ApplicationDbContext _context;
        private IStudentSubjectRepository _subject;

        public IStudentSubjectRepository Subject
        {
            get
            {
                if (_subject == null)
                {
                    _subject = new StudentSubjectRepository(_context);
                }
                return _subject;
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
