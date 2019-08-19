using System;

namespace OnlineStore.Core.SharedKernel
{
    public class BaseDomainEvent
    {
        public DateTime DataOccurred { get; protected set; } = DateTime.UtcNow;
    }
}
