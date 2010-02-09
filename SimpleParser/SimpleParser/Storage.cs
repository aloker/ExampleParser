using System.Collections.Generic;

namespace SimpleParser
{
  public class Storage
  {
    private readonly Dictionary<string, Variable> variables = new Dictionary<string, Variable>();

    public Variable GetVariable(string name)
    {
      return GetVariable(name, false);
    }

    public Variable GetVariable(string name, bool createIfMissing)
    {
      Variable variable;
      if (!variables.TryGetValue(name, out variable))
      {
        if (!createIfMissing)
        {
          throw new UnknownVariableException(name);
        }

        variable = Declare(name);
      }

      return variable;
    }

    public Variable Declare(string name)
    {
      return Declare(name, 0);
    }

    public Variable Declare(string name, int initialValue)
    {
      if (variables.ContainsKey(name))
      {
        throw new DuplicateVariableException(name);
      }

      var variable = new Variable(name, initialValue);
      variables.Add(name, variable);
      return variable;
    }
  }
}