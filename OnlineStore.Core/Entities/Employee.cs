using System;
using OnlineStore.Core.SharedKernel;

namespace OnlineStore.Domain.Entities
{
    public class Employee : BaseEntity
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string JobTitle { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime StartDate { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostCode { get; set; }
        public string Country { get; set; }
        public string WorkPhone { get; set; }
        public string MobilePhone { get; set; }
        public string PhotoURL { get; set; }
        public string Notes { get; set; }
        public int? ReportsTo { get; set; }
        public Employee Manager { get; set; }
    }
}
