using System;
using System.Collections.Generic;

namespace OnlineStore.Core.SharedKernel
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        public List<BaseDomainEvent> Events = new List<BaseDomainEvent>();
    }
}
