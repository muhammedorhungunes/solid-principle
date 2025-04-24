namespace DependencyInversion{
    public class AccountVerifier
    {
        private AccountRepository _accountRepository = new AccountRepository();

        public bool VerifyAccount(int accountId){
            return _accountRepository.GetAccount(accountId) == null;
        }
    }
}