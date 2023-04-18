namespace Songer.Base {
    public interface IBaseRepository<T> where T: class, IBaseModel, new() {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T?> GetAsync(int id);
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(int id);
    }
}
