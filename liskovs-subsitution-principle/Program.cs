using System;
using LiskovsSubsitutionPrinciple;

var addressService = new NewAddressService();
var address = addressService.GetAddressForUser(25);
var accountService = new AccountService();
accountService.ChangeAddress(address);
