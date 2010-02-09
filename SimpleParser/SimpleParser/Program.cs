using System;
using Antlr.Runtime;
using Antlr.Runtime.Tree;

namespace SimpleParser
{
  internal class Program
  {
    private static void Main(string[] args)
    {
      var storage = new Storage();
      var lexer = new SimpleLanguageLexer(new ANTLRStringStream("foo=5+3"));
      var parser = new SimpleLanguageParser(new CommonTokenStream(lexer));
      var tree = new SimpleLanguageBuilder(new CommonTreeNodeStream(parser.statement().Tree)) {Storage = storage};
      tree.statement().result.Execute();

      Console.WriteLine(storage.GetVariable("foo").Value);
    }
  }
}