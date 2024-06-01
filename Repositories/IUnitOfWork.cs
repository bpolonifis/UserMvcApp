namespace UserMvcApp.Repositories
{
    public interface IUnitOfWork
    {
        public IUserRepository UserRepository { get; }
        /*
         *      public IStudentRepository UserRepository { get; }
         *      public ITeacherRepository UserRepository { get; }
         */

        Task<bool> SaveAsync();
    }
}
