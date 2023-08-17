using AutoMapper;
using InventoryManagement.Infrastructure;
using InventoryManagement.Model;
using InventoryManagement.Repositories.Interface;
using InventoryManagement.Services.Model;
using InventoryManagement.Shared.CommonRepository;

namespace InventoryManagement.Repositories.Base;

public class CustomerRepository : RepositoryBase<Customer, VmCustomer, int>, ICustomerRepository
    {
        public CustomerRepository(IMapper mapper, InventoryDbContext dbContext) : base(mapper, dbContext)
        {
        }
    }


