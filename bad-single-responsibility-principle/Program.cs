// See https://aka.ms/new-console-template for more information
using BadSingleResponsibilityPrinciple;

Console.WriteLine("Hello, World!");
        var account = new Account
        {
            AccountId = Guid.NewGuid(),
            FirstName = "Orhun",
            LastName = "gunes",
            Street = "123 Main St",
            ZipCode = 38190,
            City = "Kayseri",
            Password = "123",
            Username = "name"
            //Country = "Türkiye" 
        };

        account.ChangePassword("321");
        account.DepositMoney(100);