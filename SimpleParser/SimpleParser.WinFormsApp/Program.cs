using System;
using System.Windows.Forms;
using SimpleParser.Parser;

namespace SimpleParser.WinFormsApp
{
  internal class Program
  {
    private static void Main(string[] args)
    {
      Application.EnableVisualStyles();
      Application.Run(new MainForm());
    }
  }
}