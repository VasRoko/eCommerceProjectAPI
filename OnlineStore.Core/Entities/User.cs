using System;
using OnlineStore.Core.SharedKernel;

namespace OnlineStore.Core.Entities
{
    public class User : BaseEntity
    {
        public string Type { get; private set; }
        public string Name { get; set; }
    }
}
