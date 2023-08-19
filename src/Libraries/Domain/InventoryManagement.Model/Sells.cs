using InventoryManagement.Shared.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Model
{
    public class Sells : BaseEntity, IEntity
    {
        public int Id { get; set; }
        public string? SellsProductName { get; set; }
        public string? SellsItem { get; set; }
        public string? SellsInvoice { get; set; }
        public string? SellsRecord { get; set; }
    }

}
