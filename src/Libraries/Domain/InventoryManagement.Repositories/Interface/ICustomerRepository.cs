using InventoryManagement.Model;
using InventoryManagement.Services.Model;
using InventoryManagement.Shared.CommonRepository;

namespace InventoryManagement.Repositories.Interface;
public interface ICustomerRepository : IRepository<Customer, VmCustomer, int>
{


}

