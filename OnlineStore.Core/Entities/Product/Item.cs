using System;
using System.Collections.Generic;
using OnlineStore.Core.SharedKernel;

namespace OnlineStore.Domain.Entities.Product
{
    public class Item : BaseEntity
    {
        public string Name { get; set; }
        public string CountyPrefix { get; set; }
        public Guid CategoryId { get; set; }
        public Details Details { get; set; }
        public string ReferenceNumber { get; set; }
        public ICollection<Review> Reviews { get; set; }
        public bool Discontinued { get; private set; }
        public DateTime DateAdded { get; private set; }

        public void SetDiscontinued()
        {
            Discontinued = true;
        }

        public void SetDateAdded()
        {
            DateAdded = DateTime.Now;
        }
    }
}
