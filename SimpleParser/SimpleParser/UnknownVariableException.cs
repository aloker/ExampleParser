using System;

namespace SimpleParser
{
  public class UnknownVariableException : ApplicationException
  {
    public UnknownVariableException(string name) : base(string.Format("Die Variable {0} ist nicht bekannt.", name))
    {
    }
  }
}