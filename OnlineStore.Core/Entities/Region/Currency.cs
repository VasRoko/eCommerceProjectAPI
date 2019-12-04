using OnlineStore.Core.SharedKernel;

namespace OnlineStore.Domain.Entities.Region
{
    public class Currency : BaseEntity
    {
        public string CurrencyCode { get; set; }
        public string Name { get; set; }
        public Country Country { get; set; }
    }
}
