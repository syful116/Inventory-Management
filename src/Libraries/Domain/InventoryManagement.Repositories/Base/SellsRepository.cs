using AutoMapper;
using InventoryManagement.Infrastructure;
using InventoryManagement.Model;
using InventoryManagement.Repositories.Interface;
using InventoryManagement.Services.Model;
using InventoryManagement.Shared.CommonRepository;

namespace InventoryManagement.Repositories.Base;
public class SellsRepository : RepositoryBase<Sells, VmSells, int>, ISellsRepository
{
    public SellsRepository(IMapper mapper, InventoryDbContext dbContext) : base(mapper, dbContext)
    {
    }
}
