using System;

namespace SimpleParser.Parser
{
  public class UnknownVariableException : ApplicationException
  {
    public UnknownVariableException(string name) : base(string.Format("The variable {0} has not been declared.", name))
    {
    }
  }
}