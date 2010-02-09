using SimpleParser.Expressions;

namespace SimpleParser.Statements
{
  public class Assignment : IStatement
  {
    private readonly string variable;
    private readonly IExpression expression;

    public Assignment(string variable, IExpression expression)
    {
      this.variable = variable;
      this.expression = expression;
    }

    public void Execute(Storage storage)
    {
      storage.GetVariable(variable, true).Value = expression.Evaluate(storage);
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