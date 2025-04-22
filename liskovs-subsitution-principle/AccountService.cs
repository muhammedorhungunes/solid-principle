using System;

namespace LiskovsSubsitutionPrinciple
{
    public class AccountService
    {
        public void ChangeAddress(Address address){
            LiskovsSubsitutionPrinciple.Require.That(()=> address.ZipCode > 1000);
            Console.WriteLine("Account address has been changed succesfully");
        }
    }
}