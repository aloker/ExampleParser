tree grammar SimpleLanguageBuilder;

options 
{
	language=CSharp2;
	output=AST;
	tokenVocab=SimpleLanguage;
	ASTLabelType=CommonTree;
}

@header{
using SimpleParser;	
using SimpleParser.Statements;
using SimpleParser.Expressions; 
}

@members{
	public Storage Storage{get;set;}
	
	Variable GetVariable(string name){
		return Storage.GetVariable(name, true);
	}
}

statement returns [IStatement result]
	:	^(ASSIGN id=IDENTIFIER expr=expression) { $result = new Assignment(Storage.GetVariable($id.text, true), $expr.result);}
	;
	
	
expression returns [IExpression result]
	:	 ^(PLUS left=expression right=expression)  { $result = SimpleBinaryExpression.Add(left.result, right.result);}
		|^(MINUS left=expression right=expression) { $result = SimpleBinaryExpression.Subtract(left.result, right.result);}
		|^(MULT left=expression right=expression)  { $result = SimpleBinaryExpression.Multiply(left.result, right.result);}
		|^(DIV left=expression right=expression)	{ $result = SimpleBinaryExpression.Divide(left.result, right.result);}
	        |NUMBER { $result = new ConstantExpression(Convert.ToInt32($NUMBER.text));}
		|IDENTIFIER { $result = new VariableExpression( Storage.GetVariable($IDENTIFIER.text, true));}	
	;
	
