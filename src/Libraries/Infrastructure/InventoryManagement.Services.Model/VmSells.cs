using InventoryManagement.Shared.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Services.Model
{
    public class VmSells : IVm
    {

        public int Id { get; set; }
        public string SellsProductName { get; set; } =String.Empty;
        public string SellsItem { get; set; } = String.Empty;
        public string? SellsInvoice { get; set; }
        public string? SellsRecord { get; set; }

    }
}
