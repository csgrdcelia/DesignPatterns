namespace Calculator
{
    public class PlusOperator : Operator
    {
        public PlusOperator(IExpression leftExpression, IExpression rightExpression) : base(leftExpression, rightExpression)
        {

        }
        public override double Evaluate() 
        {
            return this._leftExpression.Evaluate() + this._rightExpression.Evaluate();
        }
    }
}