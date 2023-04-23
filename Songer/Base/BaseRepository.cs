using Microsoft.EntityFrameworkCore;
using Songer.DAL;

namespace Songer.Base {
    public class BaseRepository<T> : IBaseRepository<T> where T : class, IBaseModel, new() {
        private readonly AppDbContext _context;

        public BaseRepository(AppDbContext context){
            _context = context;
        }

        public async Task AddAsync(T entity) {
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id) {
            T? entity = await _context.Set<T>().FirstOrDefaultAsync(x => x.Id == id);
            if (entity != null) {
                _context.Set<T>().Remove(entity);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<T>> GetAllAsync() => await _context.Set<T>().OrderByDescending(x => x.Id).ToListAsync();

        public async Task<T?> GetAsync(int id) => await _context.Set<T>().FirstOrDefaultAsync(x => x.Id == id);

        public async Task UpdateAsync(T entity) {
            _context.Set<T>().Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
