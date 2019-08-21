using OnlineStore.Core.SharedKernel;

namespace OnlineStore.Core.Entities
{
    public class Product : BaseEntity
    {
        public string Title { get; set; }
        public float Price { get; set; }
        public int Stock { get; set; }
        public int? UnitPack { get; set; }
        public string Description { get; set; }
    }
}
