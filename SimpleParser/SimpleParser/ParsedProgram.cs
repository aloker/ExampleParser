using System;
using System.Collections.Generic;
using SimpleParser.Statements;

namespace SimpleParser
{
  public class ParsedProgram
  {
    private readonly IList<IStatement> statements = new List<IStatement>();
    private Storage storage = new Storage();

    public Storage Storage
    {
      get { return storage; }
    }

    public IEnumerable<IStatement> Statements
    {
      get { return statements; }
    }

    public void AddStatement(IStatement statement)
    {
      statements.Add(statement);
    }

    public void Run()
    {
      Console.WriteLine("Executing {0} statements", statements.Count);
      foreach (var statement in statements)
      {
        statement.Execute(Storage);
      }
    }
  }
}