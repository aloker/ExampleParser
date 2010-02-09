namespace SimpleParser.Parser.Expressions
{
  public class VariableExpression : IExpression
  {
    private readonly string variableName;

    public VariableExpression(string variableName)
    {
      this.variableName = variableName;
    }

    public int Evaluate(Storage storage)
    {
      return storage.GetVariable(variableName, false).Value;
    }
  }
}