namespace SimpleParser.Parser.Expressions
{
  public abstract class BinaryExpression : IExpression
  {
    private IExpression left;
    private IExpression right;

    protected BinaryExpression(IExpression left, IExpression right)
    {
      this.left = left;
      this.right = right;
    }

    public IExpression Left
    {
      get { return left; }
    }

    public IExpression Right
    {
      get { return right; }
    }

    public abstract int Evaluate(Storage storage);
  }
}