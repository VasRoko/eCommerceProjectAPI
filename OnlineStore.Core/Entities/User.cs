using System;
using OnlineStore.Core.SharedKernel;

namespace OnlineStore.Core.Entities
{
    public class User : BaseEntity
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
    }
}
