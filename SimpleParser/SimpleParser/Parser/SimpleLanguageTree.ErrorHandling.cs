using Antlr.Runtime;

namespace SimpleParser.Parser
{
  public partial class SimpleLanguageTree
  {
    public event ErrorHandler Error;

    public override void DisplayRecognitionError(string[] tokenNames, RecognitionException e)
    {
      var handler = Error;
      if (handler != null)
      {
        handler(string.Format("{0} {1}", GetErrorHeader(e), GetErrorMessage(e, tokenNames)));
      }

      base.DisplayRecognitionError(tokenNames, e);
    }
  }
}