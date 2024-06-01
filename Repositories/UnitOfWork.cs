
using UserMvcApp.Data;

namespace UserMvcApp.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly StudentsMvcDbContext _context;

        public UnitOfWork(StudentsMvcDbContext context)
        {
            _context = context;
        }

        public IUserRepository UserRepository => new UserRepository(_context);
        /*public ITeacherRepository TeacherRepository => new TeacherRepository(_context);
         * public IStudentRepository StudentRepository => new StudentRepository(_context);
         */

        public async Task<bool> SaveAsync()
        {
            return await _context.SaveChangesAsync()>0;
        }

    }
}
