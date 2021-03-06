using System;

namespace SimpleParser.Parser.Expressions
{
  public class SimpleBinaryExpression : BinaryExpression
  {
    private readonly Func<int, int, int> evaluator;

    public SimpleBinaryExpression(IExpression left, IExpression right, Func<int, int, int> evaluator)
      : base(left, right)
    {
      this.evaluator = evaluator;
    }

    public override int Evaluate(Storage storage)
    {
      return evaluator(Left.Evaluate(storage), Right.Evaluate(storage));
    }

    public static SimpleBinaryExpression Add(IExpression left, IExpression right)
    {
      return new SimpleBinaryExpression(left, right, (l, r) => l + r);
    }

    public static SimpleBinaryExpression Subtract(IExpression left, IExpression right)
    {
      return new SimpleBinaryExpression(left, right, (l, r) => l - r);
    }

    public static SimpleBinaryExpression Multiply(IExpression left, IExpression right)
    {
      return new SimpleBinaryExpression(left, right, (l, r) => l*r);
    }

    public static SimpleBinaryExpression Divide(IExpression left, IExpression right)
    {
      return new SimpleBinaryExpression(left, right, (l, r) => l/r);
    }
  }
}