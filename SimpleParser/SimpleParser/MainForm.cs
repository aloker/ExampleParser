using System;
using System.Windows.Forms;
using Antlr.Runtime;
using Antlr.Runtime.Tree;
using SimpleParser.Parser;

namespace SimpleParser
{
  public partial class MainForm : Form
  {
    public MainForm()
    {
      InitializeComponent();
    }

    private void runButton_Click(object sender, EventArgs e)
    {
      Execute();
    }

    private void Execute()
    {
      try
      {
        errors.Text = string.Empty;
        variables.Items.Clear();
        var lexer = new SimpleLanguageLexer(new ANTLRStringStream(input.Text + Environment.NewLine));
        lexer.Error += m => AppendError("Lexer", m);
        var parser = new SimpleLanguageParser(new CommonTokenStream(lexer));
        parser.Error += m => AppendError("Parser", m);
        var tree = new SimpleLanguageTree(new CommonTreeNodeStream(parser.program().Tree));
        tree.Error += m => AppendError("TreeParser", m);

        var program = tree.program().Result;
        if (program != null)
        {
          var res = program.Run();
          foreach (var variable in program.Storage.Variables)
          {
            variables.Items.Add(new ListViewItem(new[] {variable.Key, variable.Value.ToString()}));
          }
          AppendError("Result", res.ToString());
        }
      }
      catch (Exception exception)
      {
        AppendError("Semantics", exception.Message);
      }
    }

    private void AppendError(string where, string message)
    {
      errors.Text += string.Format("{0}: {1}{2}", where, message, Environment.NewLine);
    }

    private void input_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.Control && e.KeyCode == Keys.Enter)
      {
        Execute();
        e.Handled = true;
        e.SuppressKeyPress = true;
      }
    }
  }
}