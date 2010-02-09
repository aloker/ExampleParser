using System;
using Antlr.Runtime;
using Antlr.Runtime.Tree;

namespace SimpleParser
{
  internal class Program
  {
    private static void Main(string[] args)
    {
      const string source = @"
b = 6;
foo =  (a + b) * 6; 
";

      try
      {
        var lexer = new SimpleLanguageLexer(new ANTLRStringStream(source));
        var parser = new SimpleLanguageParser(new CommonTokenStream(lexer));
        var tree = new SimpleLanguageTree(new CommonTreeNodeStream(parser.statement().Tree));
        var program = tree.program().Result;
        program.Storage.Declare("a", 123);
        program.Run();

        Console.WriteLine(program.Storage.GetVariable("foo").Value);
      }
      catch (Exception e)
      {
        Console.WriteLine(e.Message);
      }
    }
  }
}