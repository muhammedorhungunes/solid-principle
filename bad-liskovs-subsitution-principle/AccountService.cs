using System;

namespace BadLiskovsSubsitutionPrinciple
{
    public class AccountService
    {
        public void ChangeAddress(Address address){
            Require.That(()=> address.ZipCode > 1000);
            Console.WriteLine("Account address has been changed succesfully");
        }
    }
}