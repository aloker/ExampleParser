using System.Collections.Generic;
using System.Linq;

namespace SimpleParser.Parser
{
  public class Storage
  {
    private readonly Dictionary<string, Variable> variables = new Dictionary<string, Variable>();

    public IEnumerable<KeyValuePair<string, int>> Variables
    {
      get
      {
        return
          variables.Select(keyValuePair => new KeyValuePair<string, int>(keyValuePair.Key, keyValuePair.Value.Value));
      }
    }

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

    public int this[string variable]
    {
      get { return variables[variable].Value; }
    }
  }
}