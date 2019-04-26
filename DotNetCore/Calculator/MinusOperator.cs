namespace Calculator
{
    public class MinusOperator : Operator
    {
        public MinusOperator(IExpression leftExpression, IExpression rightExpression) : base(leftExpression, rightExpression)
        {

        }
        public override double Evaluate() 
        {
            return this._leftExpression.Evaluate() - this._rightExpression.Evaluate();
        }
    }
}