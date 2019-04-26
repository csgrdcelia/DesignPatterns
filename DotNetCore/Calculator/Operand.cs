namespace Calculator
{
    public class Operand : IExpression
    {
        private double _operand;
        public Operand(double value) 
        {
            _operand = value;
        }
        public double Evaluate() 
        {
            return this._operand;
        }
    }
}