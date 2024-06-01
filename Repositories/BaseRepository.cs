
using Microsoft.EntityFrameworkCore;
using UserMvcApp.Data;

namespace UserMvcApp.Repositories
{
    public abstract class BaseRepository<T> : IBaseRepository<T> 
        where T : class
    {
        public readonly StudentsMvcDbContext context;
        private readonly DbSet<T> _table;

        public BaseRepository(StudentsMvcDbContext context)
        {
            this.context = context;
            _table = this.context.Set<T>();
        }

        public virtual async Task<IEnumerable<T>> GetAllAsync() //giati exoyme abstract class kai mporei na ginei overide
        {
            var entities = await _table.ToListAsync();
            return entities;
        }

        public virtual async Task<T?> GetAsync(int id)
        {
            var entity = await _table.FindAsync(id);
            return entity;
        }


        public virtual async Task AddAsync(T entity)
        {
            await _table.AddAsync(entity);
        }

        public virtual async Task AddRangeAsync(IEnumerable<T> entities)
        {
            await _table.AddRangeAsync(entities);
        }

        public virtual void UpdateAsync(T entity)
        {
            //_context.Attach(entity);
            context.Entry(entity).State = EntityState.Modified; 
        }

        public virtual async Task<bool> DeleteAsync(int id)
        {
            T? existingEntity = await _table.FindAsync(id);
            if (existingEntity is null) return false;
            _table.Remove(existingEntity);
            return true;
        }

        public virtual async Task<int> GetCountAsync()
        {
            var count = await _table.CountAsync();  
            return count;
        }

    }
}
