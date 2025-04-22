using System; 

namespace BadOpenClosedPrinciple
{
    public class StateFinder
    {
        public string GetStateNameForZipCode(int zipCode, AddressVerifier verifier)
        {
            if(!verifier.IsValidZipCode(zipCode)){
                throw new InvalidOperationException($"Invalid ZipCode: {zipCode}");
            }

            switch(zipCode){
                case 11:
                    return "California";
                case 12:
                    return "Utah";
                default:
                    throw new InvalidOperationException($"No state is found with {zipCode}");
            }
        }
    }
}