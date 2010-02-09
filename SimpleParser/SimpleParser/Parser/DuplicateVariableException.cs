using System;

namespace SimpleParser.Parser
{
  public class DuplicateVariableException : ApplicationException
  {
    public DuplicateVariableException(string name)
      : base(string.Format("The variable {0} was already declared. ", name))
    {
    }
  }
}