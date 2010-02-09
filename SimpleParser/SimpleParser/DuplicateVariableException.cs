using System;

namespace SimpleParser
{
  public class DuplicateVariableException : ApplicationException
  {
    public DuplicateVariableException(string name)
      : base(string.Format("Die Variable {0} wurde bereits deklariert. ", name))
    {
    }
  }
}