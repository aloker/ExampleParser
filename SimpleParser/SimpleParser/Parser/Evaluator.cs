using Antlr.Runtime;
using Antlr.Runtime.Tree;

namespace SimpleParser.Parser
{
  public class Evaluator
  {
    private int lastResult;
    private readonly Storage storage;

    public event ErrorHandler Error;

    public Evaluator(Storage storage)
    {
      this.storage = storage ?? new Storage();
    }

    public Evaluator() : this(new Storage())
    {
    }

    public int LastResult
    {
      get { return lastResult; }
    }

    public Storage Storage
    {
      get { return storage; }
    }


    public void Evaluate(string expression)
    {
      var lexer = CreateLexer(expression);

      var parseTree = ParseExpression(lexer);
      if (parseTree == null)
      {
        return;
      }

      var program = CompileProgram(parseTree);
      lastResult = program != null ? program.Run(storage) : 0;
    }

    private SimpleLanguageLexer CreateLexer(string expression)
    {
      var lexer = new SimpleLanguageLexer(new ANTLRStringStream(expression));
      lexer.Error += m => OnError("Lexer", m);
      return lexer;
    }

    private ITree ParseExpression(SimpleLanguageLexer lexer)
    {
      var parser = new SimpleLanguageParser(new CommonTokenStream(lexer));
      parser.Error += m => OnError("Parser", m);

      return (ITree) parser.program().Tree;
    }

    private ParsedProgram CompileProgram(ITree parseTree)
    {
      var tree = new SimpleLanguageTree(new CommonTreeNodeStream(parseTree));
      tree.Error += m => OnError("TreeParser", m);

      var compileProgram = tree.program();
      return compileProgram != null ? compileProgram.Result : null;
    }

    protected virtual void OnError(string source, string message)
    {
      var handler = Error;
      if (handler != null)
      {
        handler(string.Format("{0}: {1}", source, message));
      }
    }
  }
}