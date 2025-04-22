using System;
using System.ComponentModel;

namespace LiskovsSubsitutionPrinciple
{
    public class NewAddressService : AddressService
    {
        public override Address GetAddressForUser(int userId)
        {
            Require.That(() => userId > 10);
            Require.That(() => userId < 30);
            var address = new Address()
            {
                Street = "Test Street",
                ZipCode = 1500,
                City = "Murray",
                State = "New England",
                Country = "USA"
            };
            return address;
        }
    }
}