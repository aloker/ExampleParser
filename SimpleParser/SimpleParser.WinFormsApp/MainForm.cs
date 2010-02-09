using System;
using System.Windows.Forms;
using SimpleParser.Parser;

namespace SimpleParser.WinFormsApp
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
        ClearOutput();

        var evaluator = new Evaluator();
        evaluator.Error += AppendError;
        evaluator.Evaluate(input.Text);
        
        UpdateOutput(evaluator);
      }
      catch (Exception exception)
      {
        AppendError(string.Format("{0}: {1}", "Semantics", exception.Message));
      }
    }

    private void UpdateOutput(Evaluator evaluator)
    {
      foreach (var variable in evaluator.Storage.Variables)
      {
        variables.Items.Add(new ListViewItem(new[] {variable.Key, variable.Value.ToString()}));
      }
      AppendError(string.Format("{0}: {1}", "Result", evaluator.LastResult));
    }

    private void ClearOutput()
    {
      errors.Text = string.Empty;
      variables.Items.Clear();
    }

    private void AppendError(string message)
    {
      errors.Text += string.Format("{0}{1}", message, Environment.NewLine);
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