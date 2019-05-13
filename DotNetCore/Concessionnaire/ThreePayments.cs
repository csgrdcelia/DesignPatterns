namespace Concessionnaire
{
    public class ThreePayments : ICreditType
    {
        public double GetNumberOfPayments() 
        {
            return 3;
        }
    }
}