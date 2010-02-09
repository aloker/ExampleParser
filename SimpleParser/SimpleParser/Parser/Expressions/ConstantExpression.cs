namespace SimpleParser.Parser.Expressions
{
  public class ConstantExpression : IExpression
  {
    private int value;

    public ConstantExpression(int value)
    {
      this.value = value;
    }

    public int Evaluate(Storage storage)
    {
      return value;
    }

    public int Value
    {
      get { return value; }
      set { this.value = value; }
    }
  }
}