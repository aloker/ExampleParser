using System;
using System.Windows.Forms;
using SimpleParser.Parser;

namespace SimpleParser.WinFormsApp
{
  internal class Program
  {
    private static void Main(string[] args)
    {
      string expressionFromXml = "valErgebnis = valCount1 - valCount2 + valCount3 ";

      var evaluator = new Evaluator();
      evaluator.Storage.Declare("valCount1", 4);
      evaluator.Storage.Declare("valCount2", 2);
      evaluator.Storage.Declare("valCount3", 5);

      evaluator.Evaluate(expressionFromXml);

      Console.WriteLine(evaluator.Storage["valErgebnis"]);

      Application.EnableVisualStyles();
      Application.Run(new MainForm());
    }
  }
}