namespace SimpleParser.Expressions
{
  public class VariableExpression : IExpression
  {
    private readonly Variable variable;

    public VariableExpression(Variable variable)
    {
      this.variable = variable;
    }

    public int Evaluate()
    {
      return variable.Value;
    }
  }
}