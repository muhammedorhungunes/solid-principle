namespace BadDependencyInversion{
    public class AccountCreator
    {
        private AccountRepository _accountRepository = new AccountRepository();
       
        
        public void SaveAccount(AccountModel accountModel){
            _accountRepository.SaveAccount(new Account(accountModel));
        }
    }
}