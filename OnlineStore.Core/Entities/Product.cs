using OnlineStore.Core.SharedKernel;

namespace OnlineStore.Core.Entities
{
    public class Product : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Stock { get; private set; }
        public float Price { get; set; }
    }
}
