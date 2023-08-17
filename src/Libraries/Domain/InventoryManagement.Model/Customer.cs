using InventoryManagement.Shared.Common;

namespace InventoryManagement.Model;



    public class Customer : BaseEntity, IEntity
    {
        public int Id { get; set; }
        public string? CustomerName { get; set; }
        public string? CustomerEmail { get; set; }
        public string? CustomerPhone { get; set; }
        public string? CustomerCity { get; set; }
    }



