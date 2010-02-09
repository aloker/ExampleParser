tree grammar SimpleLanguageTree;

options 
{
	language=CSharp2;
	output=AST;
	tokenVocab=SimpleLanguage;
	ASTLabelType=CommonTree;
}

@namespace { SimpleParser.Parser }

@header{	
using SimpleParser.Parser.Expressions;
}

@members{
	private ParsedProgram prog = new ParsedProgram();

}


program	returns [ParsedProgram Result]
	:	(s=expression {prog.AddExpression($s.result);})* { $Result = prog;}
	;
	
	
expression returns [IExpression result]
	:	  ^(ASSIGN id=IDENTIFIER expr=expression) { $result = new Assignment($id.text, $expr.result);}
		| ^(PLUS left=expression right=expression)  { $result = SimpleBinaryExpression.Add(left.result, right.result);}
		| ^(MINUS left=expression right=expression) { $result = SimpleBinaryExpression.Subtract(left.result, right.result);}
		| ^(MULT left=expression right=expression)  { $result = SimpleBinaryExpression.Multiply(left.result, right.result);}
		| ^(DIV left=expression right=expression)	{ $result = SimpleBinaryExpression.Divide(left.result, right.result);}
	        | NUMBER { $result = new ConstantExpression(Convert.ToInt32($NUMBER.text));}
		| IDENTIFIER { $result = new VariableExpression( $IDENTIFIER.text);}	
	;
	
