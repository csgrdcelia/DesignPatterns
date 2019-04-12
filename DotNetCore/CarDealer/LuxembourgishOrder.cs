namespace CarDealer
{
    public class LuxembourgishOrder : BaseOrder
    {
        private double _preTaxServiceAmount;
        private double _preTaxMaterialAmount;

        public LuxembourgishOrder(double preTaxServiceAmount, double preTaxMaterialAmount) 
        {
            _preTaxServiceAmount = preTaxServiceAmount;
            _preTaxMaterialAmount = preTaxMaterialAmount;
        }
        protected override double CalculateVal() 
        {
            return _preTaxServiceAmount * 0.12 + _preTaxMaterialAmount * 0.15;
        }

        protected override double CalculatePreTaxAmount() 
        {
            return _preTaxServiceAmount + _preTaxMaterialAmount;
        }
    }
}