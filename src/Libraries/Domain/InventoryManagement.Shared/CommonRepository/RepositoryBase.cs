using AutoMapper;
using InventoryManagement.Shared.Common;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagement.Shared.CommonRepository;

   public abstract class RepositoryBase<TEntity, IModel, T> : IRepository<TEntity, IModel, T>
    where TEntity : class, IEntity<T>, new()
    where IModel : class, IVm<T>, new()
    where T : IEquatable<T>


{

    private readonly IMapper _mapper;
    private readonly DbContext _dbContext;
    protected DbSet<TEntity> DbSet => _dbContext.Set<TEntity>();

    public RepositoryBase(IMapper mapper, DbContext dbContext)
    {
        _mapper = mapper;
        _dbContext = dbContext;
    }

    public async Task<IModel> Add(TEntity entity)
    {
        DbSet.Add(entity);
        await _dbContext.SaveChangesAsync();
        return _mapper.Map<IModel>(entity);
    }

    public async Task<IModel> Delete(T Id)
    {
        var entity = await DbSet.FindAsync(Id);
        if (entity == null)
        {
            throw new InvalidOperationException("Data Not Found");
        }
        DbSet.Remove(entity);
        await _dbContext.SaveChangesAsync();
        return _mapper.Map<IModel>(entity);
    }

    public Task<IEnumerable<IModel>> GetAll()
    {
        var data = DbSet.AsEnumerable();
        var model = _mapper.Map<IEnumerable<IModel>>(data);
        return Task.FromResult(model);
    }

    public async Task<IModel> GetById(T id)
    {
        var data = await DbSet.FindAsync(id);
        return _mapper.Map<IModel>(data);
    }

    public async Task<IModel> Update(T id, TEntity entity)
    {
        if (entity == null)
        {
            throw new ArgumentNullException("entity");
        }
        var exist = await DbSet.FindAsync(id);
        if (exist != null)
        {
            DbSet.Entry(exist).CurrentValues.SetValues(entity);
            await _dbContext.SaveChangesAsync();
        }
        return _mapper.Map<IModel>(entity);
    }

    public Task<IModel> Delete()
    {
        throw new NotImplementedException();
    }

    public Task<IModel> Update()
    {
        throw new NotImplementedException();
    }


}
