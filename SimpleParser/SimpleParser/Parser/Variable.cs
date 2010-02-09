namespace SimpleParser.Parser
{
  public class Variable
  {
    private readonly string name;
    private int value;

    public Variable(string name)
    {
      this.name = name;
    }

    public Variable(string name, int value)
    {
      this.name = name;
      this.value = value;
    }

    public int Value
    {
      get { return value; }
      set { this.value = value; }
    }

    public string Name
    {
      get { return name; }
    }
  }
}