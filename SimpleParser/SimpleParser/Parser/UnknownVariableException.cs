using System;

namespace SimpleParser.Parser
{
  public class UnknownVariableException : ApplicationException
  {
    public UnknownVariableException(string name) : base(string.Format("Die Variable {0} ist nicht bekannt.", name))
    {
    }
  }
}