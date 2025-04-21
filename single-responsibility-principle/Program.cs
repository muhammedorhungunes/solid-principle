// See https://aka.ms/new-console-template for more information
using SingleResponsibilityPrinciple;
using SingleResponsibilityPrinciple.Services;

Console.WriteLine("Hello, World!");

            var accountService = new AccountService();
            Console.WriteLine("Hello World!");
            var account = new Account
            {
                AccountId = Guid.NewGuid(),
                Profile = new Profile { FirstName = "Orhun", LastName = "gunes" },
                Address = new Address { Street = "123 Main St",ZipCode = 38190, City = "Kayseri", Country = "Türkiye" }
            };
            Console.WriteLine($"Account ID: {account.AccountId}");
            Console.WriteLine($"Account ID: {account.Profile}");
            accountService.DepositMoney(account.AccountId,100);
            accountService.WithdrawMoney(account.AccountId,100);

