grammar SimpleLanguage;

options 
{
	language=CSharp2;
	output=AST;
}

tokens{
	PLUS='+';
	MINUS='-';
	MULT='*';
	DIV='/';
	ASSIGN='=';
	LEFTPAREN='(';
	RIGHTPAREN=')';	
	SEMICOLON=';';
}

program	:	statement+
	;

statement
	:	assignment SEMICOLON
	;
	
assignment
	:	IDENTIFIER ASSIGN^ expression
	;
	
expression
	:	term ((PLUS^|MINUS^) term)*
	;
	
term
	:	value ((MULT^|DIV^|) value)*
	;
	
value
	:	(LEFTPAREN! expression RIGHTPAREN!) | NUMBER | IDENTIFIER
	;
	


NUMBER	:	DIGIT+;
WHITESPACE
	:	( '\t' | ' ' | '\r' | '\n'| '\u000C' )+ { $channel = HIDDEN; } ;
IDENTIFIER
	:	LETTER (DIGIT|LETTER)*;
	
fragment LETTER: LOWER | UPPER;
fragment LOWER: 'a'..'z';
fragment UPPER: 'A'..'Z';
fragment DIGIT: '0'..'9';
