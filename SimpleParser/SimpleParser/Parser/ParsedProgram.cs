using System;
using System.Collections.Generic;
using SimpleParser.Parser.Expressions;

namespace SimpleParser.Parser
{
  public class ParsedProgram
  {
    private readonly IList<IExpression> expressions = new List<IExpression>();
    private readonly Storage storage = new Storage();

    public Storage Storage
    {
      get { return storage; }
    }

    public IEnumerable<IExpression> Expressions
    {
      get { return expressions; }
    }

    public void AddExpression(IExpression expression)
    {
      expressions.Add(expression);
    }

    public int Run()
    {
      Console.WriteLine("Executing {0} Expressions", expressions.Count);
      var value = 0;
      foreach (var statement in expressions)
      {
        value = statement.Evaluate(Storage);
      }

      return value;
    }
  }
}