using System;

namespace SingleResponsibilityPrinciple
{
    public class Account 
    {
         public Guid AccountId { get; set; }
        public Profile Profile { get; set; }
        public Address Address { get; set; }
    }
}