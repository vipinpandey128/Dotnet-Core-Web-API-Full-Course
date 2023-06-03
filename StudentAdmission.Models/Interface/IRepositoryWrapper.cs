namespace StudentAdmission.Models.Interface
{
    public interface IRepositoryWrapper
    {
        IStudentSubjectRepository Subject { get; }
        void Save();
    }
}
