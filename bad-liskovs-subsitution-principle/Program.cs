var addressService = new AddressService();
var address = addressService.GetAddressForUser(25);
var accountService = new AccountService();
accountService.ChangeAddress(address);
