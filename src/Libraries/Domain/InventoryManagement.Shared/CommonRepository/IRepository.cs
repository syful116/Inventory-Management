using InventoryManagement.Shared.Common;

namespace InventoryManagement.Shared.CommonRepository
{
    public interface IRepository<TEntity, IModel, T>
    where TEntity : class, IEntity<T>, new()
    where IModel : class, IVm<T>, new()
    where T : IEquatable<T>
    {
        public Task<IModel> GetById(T id);
        public Task<IEnumerable<IModel>> GetAll();
        public Task<IModel> Delete(T id);
        public Task<IModel> Update(T id, TEntity entity);
        public Task<IModel> Add(TEntity entity);

    }
}
