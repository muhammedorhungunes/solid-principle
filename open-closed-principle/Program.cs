
using OpenClosedPrinciple;

var stateFinder = new StateFinder();

    try{
        var addressVerifier = new AddressVerifier();
        Console.WriteLine(stateFinder.GetStateNameForZipCode(11, addressVerifier));
        Console.WriteLine(stateFinder.GetStateNameForZipCode(9, addressVerifier));
    } catch(InvalidOperationException exception){
        Console.WriteLine(exception.Message);
    }
              
    try{
        var addressVerifier = new GermanyAddressVerifier();
        Console.WriteLine(stateFinder.GetStateNameForZipCode(9, addressVerifier));
    } catch(InvalidOperationException exception){
        Console.WriteLine(exception.Message);
    }