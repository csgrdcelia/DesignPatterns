namespace CarDealer
{
    public class FrenchOrder : BaseOrder
    {
        private double _preTaxAmount;

        public FrenchOrder(double preTaxAmount) 
        {
            _preTaxAmount = preTaxAmount;
        }

        protected override double CalculateVal() 
        {
            return _preTaxAmount * 0.196;
        }

        protected override double CalculatePreTaxAmount() 
        {
            return _preTaxAmount;
        }
    }
}