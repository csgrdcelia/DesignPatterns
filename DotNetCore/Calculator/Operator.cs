namespace Calculator
{
    public abstract class Operator : IExpression
    {
        protected IExpression _leftExpression;
        protected IExpression _rightExpression;
        public Operator(IExpression leftExpression, IExpression rightExpression) 
        {
            _leftExpression = leftExpression;
            _rightExpression = rightExpression;
        }
        public abstract double Evaluate();
    }
}