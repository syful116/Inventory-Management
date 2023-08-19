using InventoryManagement.Model;
using InventoryManagement.Services.Model;
using InventoryManagement.Shared.CommonRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Repositories.Interface
{
    public interface ISellsRepository : IRepository<Sells, VmSells, int>
    {


    }


}
