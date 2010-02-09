namespace SimpleParser.Parser.Expressions
{
  public class Assignment : IExpression
  {
    private readonly string variable;
    private readonly IExpression expression;

    public Assignment(string variable, IExpression expression)
    {
      this.variable = variable;
      this.expression = expression;
    }

    public int Evaluate(Storage storage)
    {
      var value = expression.Evaluate(storage);
      storage.GetVariable(variable, true).Value = value;
      return value;
    }

    public string Variable
    {
      get { return variable; }
    }

    public IExpression Expression
    {
      get { return expression; }
    }
  }
}