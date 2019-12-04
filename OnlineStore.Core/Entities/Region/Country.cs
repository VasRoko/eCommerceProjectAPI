using OnlineStore.Core.SharedKernel;

namespace OnlineStore.Domain.Entities.Region
{
    public class Country : BaseEntity
    {
        public string CountryCode { get; set; }
        public string Name { get; set; }
    }
}
