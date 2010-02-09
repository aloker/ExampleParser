namespace SimpleParser.Parser.Expressions
{
  public interface IExpression
  {
    int Evaluate(Storage storage);
  }
}