using SimpleParser.Expressions;

namespace SimpleParser.Statements
{
  public class Assignment : IStatement
  {
    private readonly Variable destination;
    private readonly IExpression expression;

    public Assignment(Variable destination, IExpression expression)
    {
      this.destination = destination;
      this.expression = expression;
    }

    public void Execute()
    {
      destination.Value = expression.Evaluate();
    }

    public Variable Destination
    {
      get { return destination; }
    }

    public IExpression Expression
    {
      get { return expression; }
    }
  }
}