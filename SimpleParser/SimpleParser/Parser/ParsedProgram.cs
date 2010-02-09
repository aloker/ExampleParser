using System.Collections.Generic;
using SimpleParser.Parser.Expressions;

namespace SimpleParser.Parser
{
  public class ParsedProgram
  {
    private readonly IList<IExpression> expressions = new List<IExpression>();

    public IEnumerable<IExpression> Expressions
    {
      get { return expressions; }
    }

    public void AddExpression(IExpression expression)
    {
      expressions.Add(expression);
    }

    public int Run(Storage storage)
    {
      var value = 0;
      foreach (var statement in expressions)
      {
        value = statement.Evaluate(storage);
      }

      return value;
    }
  }
}