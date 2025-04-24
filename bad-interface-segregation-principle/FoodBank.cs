using System;

namespace BadInterfaceSegregationPrinciple
{
    public class FoodBank
    {
        public void AddToList(IOmnivore omnivore)
        {
            throw new NotImplementedException();
        }
    }
}