// $ANTLR 3.1.2 E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g 2010-02-09 14:21:15

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162
namespace  SimpleParser.Parser 
{

using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;



using Antlr.Runtime.Tree;

public partial class SimpleLanguageParser : Parser
{
    public static readonly string[] tokenNames = new string[] 
	{
        "<invalid>", 
		"<EOR>", 
		"<DOWN>", 
		"<UP>", 
		"PLUS", 
		"MINUS", 
		"MULT", 
		"DIV", 
		"ASSIGN", 
		"LEFTPAREN", 
		"RIGHTPAREN", 
		"NEWLINE", 
		"IDENTIFIER", 
		"NUMBER", 
		"DIGIT", 
		"WHITESPACE", 
		"LETTER", 
		"LOWER", 
		"UPPER"
    };

    public const int LEFTPAREN = 9;
    public const int NEWLINE = 11;
    public const int RIGHTPAREN = 10;
    public const int LETTER = 16;
    public const int IDENTIFIER = 12;
    public const int NUMBER = 13;
    public const int ASSIGN = 8;
    public const int WHITESPACE = 15;
    public const int PLUS = 4;
    public const int LOWER = 17;
    public const int DIGIT = 14;
    public const int MINUS = 5;
    public const int MULT = 6;
    public const int DIV = 7;
    public const int EOF = -1;
    public const int UPPER = 18;

    // delegates
    // delegators



        public SimpleLanguageParser(ITokenStream input)
    		: this(input, new RecognizerSharedState()) {
        }

        public SimpleLanguageParser(ITokenStream input, RecognizerSharedState state)
    		: base(input, state) {
            InitializeCyclicDFAs();

             
        }
        
    protected ITreeAdaptor adaptor = new CommonTreeAdaptor();

    public ITreeAdaptor TreeAdaptor
    {
        get { return this.adaptor; }
        set {
    	this.adaptor = value;
    	}
    }

    override public string[] TokenNames {
		get { return SimpleLanguageParser.tokenNames; }
    }

    override public string GrammarFileName {
		get { return "E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g"; }
    }


    public class program_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "program"
    // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:22:1: program : ( statement )* ( NEWLINE )? EOF ;
    public SimpleLanguageParser.program_return program() // throws RecognitionException [1]
    {   
        SimpleLanguageParser.program_return retval = new SimpleLanguageParser.program_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken NEWLINE2 = null;
        IToken EOF3 = null;
        SimpleLanguageParser.statement_return statement1 = default(SimpleLanguageParser.statement_return);


        object NEWLINE2_tree=null;
        object EOF3_tree=null;

        try 
    	{
            // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:22:9: ( ( statement )* ( NEWLINE )? EOF )
            // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:22:11: ( statement )* ( NEWLINE )? EOF
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:22:11: ( statement )*
            	do 
            	{
            	    int alt1 = 2;
            	    int LA1_0 = input.LA(1);

            	    if ( (LA1_0 == IDENTIFIER) )
            	    {
            	        alt1 = 1;
            	    }


            	    switch (alt1) 
            		{
            			case 1 :
            			    // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:22:11: statement
            			    {
            			    	PushFollow(FOLLOW_statement_in_program92);
            			    	statement1 = statement();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, statement1.Tree);

            			    }
            			    break;

            			default:
            			    goto loop1;
            	    }
            	} while (true);

            	loop1:
            		;	// Stops C# compiler whining that label 'loop1' has no statements

            	// E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:22:22: ( NEWLINE )?
            	int alt2 = 2;
            	int LA2_0 = input.LA(1);

            	if ( (LA2_0 == NEWLINE) )
            	{
            	    alt2 = 1;
            	}
            	switch (alt2) 
            	{
            	    case 1 :
            	        // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:22:22: NEWLINE
            	        {
            	        	NEWLINE2=(IToken)Match(input,NEWLINE,FOLLOW_NEWLINE_in_program95); 
            	        		NEWLINE2_tree = (object)adaptor.Create(NEWLINE2);
            	        		adaptor.AddChild(root_0, NEWLINE2_tree);


            	        }
            	        break;

            	}

            	EOF3=(IToken)Match(input,EOF,FOLLOW_EOF_in_program98); 

            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "program"

    public class statement_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "statement"
    // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:25:1: statement : assignment NEWLINE ;
    public SimpleLanguageParser.statement_return statement() // throws RecognitionException [1]
    {   
        SimpleLanguageParser.statement_return retval = new SimpleLanguageParser.statement_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken NEWLINE5 = null;
        SimpleLanguageParser.assignment_return assignment4 = default(SimpleLanguageParser.assignment_return);


        object NEWLINE5_tree=null;

        try 
    	{
            // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:26:2: ( assignment NEWLINE )
            // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:26:4: assignment NEWLINE
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_assignment_in_statement110);
            	assignment4 = assignment();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, assignment4.Tree);
            	NEWLINE5=(IToken)Match(input,NEWLINE,FOLLOW_NEWLINE_in_statement112); 

            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "statement"

    public class assignment_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "assignment"
    // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:29:1: assignment : IDENTIFIER ASSIGN expression ;
    public SimpleLanguageParser.assignment_return assignment() // throws RecognitionException [1]
    {   
        SimpleLanguageParser.assignment_return retval = new SimpleLanguageParser.assignment_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken IDENTIFIER6 = null;
        IToken ASSIGN7 = null;
        SimpleLanguageParser.expression_return expression8 = default(SimpleLanguageParser.expression_return);


        object IDENTIFIER6_tree=null;
        object ASSIGN7_tree=null;

        try 
    	{
            // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:30:2: ( IDENTIFIER ASSIGN expression )
            // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:30:4: IDENTIFIER ASSIGN expression
            {
            	root_0 = (object)adaptor.GetNilNode();

            	IDENTIFIER6=(IToken)Match(input,IDENTIFIER,FOLLOW_IDENTIFIER_in_assignment125); 
            		IDENTIFIER6_tree = (object)adaptor.Create(IDENTIFIER6);
            		adaptor.AddChild(root_0, IDENTIFIER6_tree);

            	ASSIGN7=(IToken)Match(input,ASSIGN,FOLLOW_ASSIGN_in_assignment127); 
            		ASSIGN7_tree = (object)adaptor.Create(ASSIGN7);
            		root_0 = (object)adaptor.BecomeRoot(ASSIGN7_tree, root_0);

            	PushFollow(FOLLOW_expression_in_assignment130);
            	expression8 = expression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, expression8.Tree);

            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "assignment"

    public class expression_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "expression"
    // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:33:1: expression : term ( ( PLUS | MINUS ) term )* ;
    public SimpleLanguageParser.expression_return expression() // throws RecognitionException [1]
    {   
        SimpleLanguageParser.expression_return retval = new SimpleLanguageParser.expression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken PLUS10 = null;
        IToken MINUS11 = null;
        SimpleLanguageParser.term_return term9 = default(SimpleLanguageParser.term_return);

        SimpleLanguageParser.term_return term12 = default(SimpleLanguageParser.term_return);


        object PLUS10_tree=null;
        object MINUS11_tree=null;

        try 
    	{
            // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:34:2: ( term ( ( PLUS | MINUS ) term )* )
            // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:34:4: term ( ( PLUS | MINUS ) term )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_term_in_expression142);
            	term9 = term();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, term9.Tree);
            	// E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:34:9: ( ( PLUS | MINUS ) term )*
            	do 
            	{
            	    int alt4 = 2;
            	    int LA4_0 = input.LA(1);

            	    if ( ((LA4_0 >= PLUS && LA4_0 <= MINUS)) )
            	    {
            	        alt4 = 1;
            	    }


            	    switch (alt4) 
            		{
            			case 1 :
            			    // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:34:10: ( PLUS | MINUS ) term
            			    {
            			    	// E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:34:10: ( PLUS | MINUS )
            			    	int alt3 = 2;
            			    	int LA3_0 = input.LA(1);

            			    	if ( (LA3_0 == PLUS) )
            			    	{
            			    	    alt3 = 1;
            			    	}
            			    	else if ( (LA3_0 == MINUS) )
            			    	{
            			    	    alt3 = 2;
            			    	}
            			    	else 
            			    	{
            			    	    NoViableAltException nvae_d3s0 =
            			    	        new NoViableAltException("", 3, 0, input);

            			    	    throw nvae_d3s0;
            			    	}
            			    	switch (alt3) 
            			    	{
            			    	    case 1 :
            			    	        // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:34:11: PLUS
            			    	        {
            			    	        	PLUS10=(IToken)Match(input,PLUS,FOLLOW_PLUS_in_expression146); 
            			    	        		PLUS10_tree = (object)adaptor.Create(PLUS10);
            			    	        		root_0 = (object)adaptor.BecomeRoot(PLUS10_tree, root_0);


            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:34:17: MINUS
            			    	        {
            			    	        	MINUS11=(IToken)Match(input,MINUS,FOLLOW_MINUS_in_expression149); 
            			    	        		MINUS11_tree = (object)adaptor.Create(MINUS11);
            			    	        		root_0 = (object)adaptor.BecomeRoot(MINUS11_tree, root_0);


            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_term_in_expression153);
            			    	term12 = term();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, term12.Tree);

            			    }
            			    break;

            			default:
            			    goto loop4;
            	    }
            	} while (true);

            	loop4:
            		;	// Stops C# compiler whining that label 'loop4' has no statements


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "expression"

    public class term_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "term"
    // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:37:1: term : value ( ( MULT | DIV | ) value )* ;
    public SimpleLanguageParser.term_return term() // throws RecognitionException [1]
    {   
        SimpleLanguageParser.term_return retval = new SimpleLanguageParser.term_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken MULT14 = null;
        IToken DIV15 = null;
        SimpleLanguageParser.value_return value13 = default(SimpleLanguageParser.value_return);

        SimpleLanguageParser.value_return value16 = default(SimpleLanguageParser.value_return);


        object MULT14_tree=null;
        object DIV15_tree=null;

        try 
    	{
            // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:38:2: ( value ( ( MULT | DIV | ) value )* )
            // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:38:4: value ( ( MULT | DIV | ) value )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_value_in_term167);
            	value13 = value();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, value13.Tree);
            	// E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:38:10: ( ( MULT | DIV | ) value )*
            	do 
            	{
            	    int alt6 = 2;
            	    int LA6_0 = input.LA(1);

            	    if ( ((LA6_0 >= MULT && LA6_0 <= DIV) || LA6_0 == LEFTPAREN || (LA6_0 >= IDENTIFIER && LA6_0 <= NUMBER)) )
            	    {
            	        alt6 = 1;
            	    }


            	    switch (alt6) 
            		{
            			case 1 :
            			    // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:38:11: ( MULT | DIV | ) value
            			    {
            			    	// E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:38:11: ( MULT | DIV | )
            			    	int alt5 = 3;
            			    	switch ( input.LA(1) ) 
            			    	{
            			    	case MULT:
            			    		{
            			    	    alt5 = 1;
            			    	    }
            			    	    break;
            			    	case DIV:
            			    		{
            			    	    alt5 = 2;
            			    	    }
            			    	    break;
            			    	case LEFTPAREN:
            			    	case IDENTIFIER:
            			    	case NUMBER:
            			    		{
            			    	    alt5 = 3;
            			    	    }
            			    	    break;
            			    		default:
            			    		    NoViableAltException nvae_d5s0 =
            			    		        new NoViableAltException("", 5, 0, input);

            			    		    throw nvae_d5s0;
            			    	}

            			    	switch (alt5) 
            			    	{
            			    	    case 1 :
            			    	        // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:38:12: MULT
            			    	        {
            			    	        	MULT14=(IToken)Match(input,MULT,FOLLOW_MULT_in_term171); 
            			    	        		MULT14_tree = (object)adaptor.Create(MULT14);
            			    	        		root_0 = (object)adaptor.BecomeRoot(MULT14_tree, root_0);


            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:38:18: DIV
            			    	        {
            			    	        	DIV15=(IToken)Match(input,DIV,FOLLOW_DIV_in_term174); 
            			    	        		DIV15_tree = (object)adaptor.Create(DIV15);
            			    	        		root_0 = (object)adaptor.BecomeRoot(DIV15_tree, root_0);


            			    	        }
            			    	        break;
            			    	    case 3 :
            			    	        // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:38:23: 
            			    	        {
            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_value_in_term179);
            			    	value16 = value();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, value16.Tree);

            			    }
            			    break;

            			default:
            			    goto loop6;
            	    }
            	} while (true);

            	loop6:
            		;	// Stops C# compiler whining that label 'loop6' has no statements


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "term"

    public class value_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "value"
    // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:41:1: value : ( ( LEFTPAREN expression RIGHTPAREN ) | NUMBER | IDENTIFIER );
    public SimpleLanguageParser.value_return value() // throws RecognitionException [1]
    {   
        SimpleLanguageParser.value_return retval = new SimpleLanguageParser.value_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken LEFTPAREN17 = null;
        IToken RIGHTPAREN19 = null;
        IToken NUMBER20 = null;
        IToken IDENTIFIER21 = null;
        SimpleLanguageParser.expression_return expression18 = default(SimpleLanguageParser.expression_return);


        object LEFTPAREN17_tree=null;
        object RIGHTPAREN19_tree=null;
        object NUMBER20_tree=null;
        object IDENTIFIER21_tree=null;

        try 
    	{
            // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:42:2: ( ( LEFTPAREN expression RIGHTPAREN ) | NUMBER | IDENTIFIER )
            int alt7 = 3;
            switch ( input.LA(1) ) 
            {
            case LEFTPAREN:
            	{
                alt7 = 1;
                }
                break;
            case NUMBER:
            	{
                alt7 = 2;
                }
                break;
            case IDENTIFIER:
            	{
                alt7 = 3;
                }
                break;
            	default:
            	    NoViableAltException nvae_d7s0 =
            	        new NoViableAltException("", 7, 0, input);

            	    throw nvae_d7s0;
            }

            switch (alt7) 
            {
                case 1 :
                    // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:42:4: ( LEFTPAREN expression RIGHTPAREN )
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	// E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:42:4: ( LEFTPAREN expression RIGHTPAREN )
                    	// E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:42:5: LEFTPAREN expression RIGHTPAREN
                    	{
                    		LEFTPAREN17=(IToken)Match(input,LEFTPAREN,FOLLOW_LEFTPAREN_in_value194); 
                    		PushFollow(FOLLOW_expression_in_value197);
                    		expression18 = expression();
                    		state.followingStackPointer--;

                    		adaptor.AddChild(root_0, expression18.Tree);
                    		RIGHTPAREN19=(IToken)Match(input,RIGHTPAREN,FOLLOW_RIGHTPAREN_in_value199); 

                    	}


                    }
                    break;
                case 2 :
                    // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:42:42: NUMBER
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	NUMBER20=(IToken)Match(input,NUMBER,FOLLOW_NUMBER_in_value205); 
                    		NUMBER20_tree = (object)adaptor.Create(NUMBER20);
                    		adaptor.AddChild(root_0, NUMBER20_tree);


                    }
                    break;
                case 3 :
                    // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:42:51: IDENTIFIER
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	IDENTIFIER21=(IToken)Match(input,IDENTIFIER,FOLLOW_IDENTIFIER_in_value209); 
                    		IDENTIFIER21_tree = (object)adaptor.Create(IDENTIFIER21);
                    		adaptor.AddChild(root_0, IDENTIFIER21_tree);


                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "value"

    // Delegated rules


	private void InitializeCyclicDFAs()
	{
	}

 

    public static readonly BitSet FOLLOW_statement_in_program92 = new BitSet(new ulong[]{0x0000000000001800UL});
    public static readonly BitSet FOLLOW_NEWLINE_in_program95 = new BitSet(new ulong[]{0x0000000000000000UL});
    public static readonly BitSet FOLLOW_EOF_in_program98 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_assignment_in_statement110 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_NEWLINE_in_statement112 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IDENTIFIER_in_assignment125 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_ASSIGN_in_assignment127 = new BitSet(new ulong[]{0x0000000000003200UL});
    public static readonly BitSet FOLLOW_expression_in_assignment130 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_term_in_expression142 = new BitSet(new ulong[]{0x0000000000000032UL});
    public static readonly BitSet FOLLOW_PLUS_in_expression146 = new BitSet(new ulong[]{0x0000000000003200UL});
    public static readonly BitSet FOLLOW_MINUS_in_expression149 = new BitSet(new ulong[]{0x0000000000003200UL});
    public static readonly BitSet FOLLOW_term_in_expression153 = new BitSet(new ulong[]{0x0000000000000032UL});
    public static readonly BitSet FOLLOW_value_in_term167 = new BitSet(new ulong[]{0x00000000000032C2UL});
    public static readonly BitSet FOLLOW_MULT_in_term171 = new BitSet(new ulong[]{0x0000000000003200UL});
    public static readonly BitSet FOLLOW_DIV_in_term174 = new BitSet(new ulong[]{0x0000000000003200UL});
    public static readonly BitSet FOLLOW_value_in_term179 = new BitSet(new ulong[]{0x00000000000032C2UL});
    public static readonly BitSet FOLLOW_LEFTPAREN_in_value194 = new BitSet(new ulong[]{0x0000000000003200UL});
    public static readonly BitSet FOLLOW_expression_in_value197 = new BitSet(new ulong[]{0x0000000000000400UL});
    public static readonly BitSet FOLLOW_RIGHTPAREN_in_value199 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NUMBER_in_value205 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IDENTIFIER_in_value209 = new BitSet(new ulong[]{0x0000000000000002UL});

}
}