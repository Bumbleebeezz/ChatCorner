namespace ChatCorner.CommonInterfaces;

public interface IRepository<TEntity, TID> where TEntity : IEntity<TID>
{
    Task<TEntity> GetByIdAsync(TID ID);
    Task<IEnumerable<TEntity>> GetManyAsync(int start, int count);
    Task AddOneAsync(TEntity item);
}