// $ANTLR 3.1.2 E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g 2010-02-09 11:54:23

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162

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
		"IDENTIFIER", 
		"NUMBER", 
		"DIGIT", 
		"WHITESPACE", 
		"LETTER", 
		"LOWER", 
		"UPPER"
    };

    public const int LEFTPAREN = 9;
    public const int RIGHTPAREN = 10;
    public const int LETTER = 15;
    public const int IDENTIFIER = 11;
    public const int NUMBER = 12;
    public const int ASSIGN = 8;
    public const int WHITESPACE = 14;
    public const int PLUS = 4;
    public const int LOWER = 16;
    public const int DIGIT = 13;
    public const int MINUS = 5;
    public const int MULT = 6;
    public const int DIV = 7;
    public const int EOF = -1;
    public const int UPPER = 17;

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
    // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:20:1: statement : assignment ;
    public SimpleLanguageParser.statement_return statement() // throws RecognitionException [1]
    {   
        SimpleLanguageParser.statement_return retval = new SimpleLanguageParser.statement_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        SimpleLanguageParser.assignment_return assignment1 = default(SimpleLanguageParser.assignment_return);



        try 
    	{
            // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:21:2: ( assignment )
            // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:21:4: assignment
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_assignment_in_statement77);
            	assignment1 = assignment();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, assignment1.Tree);

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
    // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:24:1: assignment : IDENTIFIER ASSIGN expression ;
    public SimpleLanguageParser.assignment_return assignment() // throws RecognitionException [1]
    {   
        SimpleLanguageParser.assignment_return retval = new SimpleLanguageParser.assignment_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken IDENTIFIER2 = null;
        IToken ASSIGN3 = null;
        SimpleLanguageParser.expression_return expression4 = default(SimpleLanguageParser.expression_return);


        object IDENTIFIER2_tree=null;
        object ASSIGN3_tree=null;

        try 
    	{
            // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:25:2: ( IDENTIFIER ASSIGN expression )
            // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:25:4: IDENTIFIER ASSIGN expression
            {
            	root_0 = (object)adaptor.GetNilNode();

            	IDENTIFIER2=(IToken)Match(input,IDENTIFIER,FOLLOW_IDENTIFIER_in_assignment89); 
            		IDENTIFIER2_tree = (object)adaptor.Create(IDENTIFIER2);
            		adaptor.AddChild(root_0, IDENTIFIER2_tree);

            	ASSIGN3=(IToken)Match(input,ASSIGN,FOLLOW_ASSIGN_in_assignment91); 
            		ASSIGN3_tree = (object)adaptor.Create(ASSIGN3);
            		root_0 = (object)adaptor.BecomeRoot(ASSIGN3_tree, root_0);

            	PushFollow(FOLLOW_expression_in_assignment94);
            	expression4 = expression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, expression4.Tree);

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
    // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:28:1: expression : term ( ( PLUS | MINUS ) term )* ;
    public SimpleLanguageParser.expression_return expression() // throws RecognitionException [1]
    {   
        SimpleLanguageParser.expression_return retval = new SimpleLanguageParser.expression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken PLUS6 = null;
        IToken MINUS7 = null;
        SimpleLanguageParser.term_return term5 = default(SimpleLanguageParser.term_return);

        SimpleLanguageParser.term_return term8 = default(SimpleLanguageParser.term_return);


        object PLUS6_tree=null;
        object MINUS7_tree=null;

        try 
    	{
            // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:29:2: ( term ( ( PLUS | MINUS ) term )* )
            // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:29:4: term ( ( PLUS | MINUS ) term )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_term_in_expression106);
            	term5 = term();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, term5.Tree);
            	// E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:29:9: ( ( PLUS | MINUS ) term )*
            	do 
            	{
            	    int alt2 = 2;
            	    int LA2_0 = input.LA(1);

            	    if ( ((LA2_0 >= PLUS && LA2_0 <= MINUS)) )
            	    {
            	        alt2 = 1;
            	    }


            	    switch (alt2) 
            		{
            			case 1 :
            			    // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:29:10: ( PLUS | MINUS ) term
            			    {
            			    	// E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:29:10: ( PLUS | MINUS )
            			    	int alt1 = 2;
            			    	int LA1_0 = input.LA(1);

            			    	if ( (LA1_0 == PLUS) )
            			    	{
            			    	    alt1 = 1;
            			    	}
            			    	else if ( (LA1_0 == MINUS) )
            			    	{
            			    	    alt1 = 2;
            			    	}
            			    	else 
            			    	{
            			    	    NoViableAltException nvae_d1s0 =
            			    	        new NoViableAltException("", 1, 0, input);

            			    	    throw nvae_d1s0;
            			    	}
            			    	switch (alt1) 
            			    	{
            			    	    case 1 :
            			    	        // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:29:11: PLUS
            			    	        {
            			    	        	PLUS6=(IToken)Match(input,PLUS,FOLLOW_PLUS_in_expression110); 
            			    	        		PLUS6_tree = (object)adaptor.Create(PLUS6);
            			    	        		root_0 = (object)adaptor.BecomeRoot(PLUS6_tree, root_0);


            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:29:17: MINUS
            			    	        {
            			    	        	MINUS7=(IToken)Match(input,MINUS,FOLLOW_MINUS_in_expression113); 
            			    	        		MINUS7_tree = (object)adaptor.Create(MINUS7);
            			    	        		root_0 = (object)adaptor.BecomeRoot(MINUS7_tree, root_0);


            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_term_in_expression117);
            			    	term8 = term();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, term8.Tree);

            			    }
            			    break;

            			default:
            			    goto loop2;
            	    }
            	} while (true);

            	loop2:
            		;	// Stops C# compiler whining that label 'loop2' has no statements


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
    // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:32:1: term : value ( ( MULT | DIV | ) value )* ;
    public SimpleLanguageParser.term_return term() // throws RecognitionException [1]
    {   
        SimpleLanguageParser.term_return retval = new SimpleLanguageParser.term_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken MULT10 = null;
        IToken DIV11 = null;
        SimpleLanguageParser.value_return value9 = default(SimpleLanguageParser.value_return);

        SimpleLanguageParser.value_return value12 = default(SimpleLanguageParser.value_return);


        object MULT10_tree=null;
        object DIV11_tree=null;

        try 
    	{
            // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:33:2: ( value ( ( MULT | DIV | ) value )* )
            // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:33:4: value ( ( MULT | DIV | ) value )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_value_in_term131);
            	value9 = value();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, value9.Tree);
            	// E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:33:10: ( ( MULT | DIV | ) value )*
            	do 
            	{
            	    int alt4 = 2;
            	    int LA4_0 = input.LA(1);

            	    if ( ((LA4_0 >= MULT && LA4_0 <= DIV) || LA4_0 == LEFTPAREN || (LA4_0 >= IDENTIFIER && LA4_0 <= NUMBER)) )
            	    {
            	        alt4 = 1;
            	    }


            	    switch (alt4) 
            		{
            			case 1 :
            			    // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:33:11: ( MULT | DIV | ) value
            			    {
            			    	// E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:33:11: ( MULT | DIV | )
            			    	int alt3 = 3;
            			    	switch ( input.LA(1) ) 
            			    	{
            			    	case MULT:
            			    		{
            			    	    alt3 = 1;
            			    	    }
            			    	    break;
            			    	case DIV:
            			    		{
            			    	    alt3 = 2;
            			    	    }
            			    	    break;
            			    	case LEFTPAREN:
            			    	case IDENTIFIER:
            			    	case NUMBER:
            			    		{
            			    	    alt3 = 3;
            			    	    }
            			    	    break;
            			    		default:
            			    		    NoViableAltException nvae_d3s0 =
            			    		        new NoViableAltException("", 3, 0, input);

            			    		    throw nvae_d3s0;
            			    	}

            			    	switch (alt3) 
            			    	{
            			    	    case 1 :
            			    	        // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:33:12: MULT
            			    	        {
            			    	        	MULT10=(IToken)Match(input,MULT,FOLLOW_MULT_in_term135); 
            			    	        		MULT10_tree = (object)adaptor.Create(MULT10);
            			    	        		root_0 = (object)adaptor.BecomeRoot(MULT10_tree, root_0);


            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:33:18: DIV
            			    	        {
            			    	        	DIV11=(IToken)Match(input,DIV,FOLLOW_DIV_in_term138); 
            			    	        		DIV11_tree = (object)adaptor.Create(DIV11);
            			    	        		root_0 = (object)adaptor.BecomeRoot(DIV11_tree, root_0);


            			    	        }
            			    	        break;
            			    	    case 3 :
            			    	        // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:33:23: 
            			    	        {
            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_value_in_term143);
            			    	value12 = value();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, value12.Tree);

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
    // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:36:1: value : ( ( LEFTPAREN expression RIGHTPAREN ) | NUMBER | IDENTIFIER );
    public SimpleLanguageParser.value_return value() // throws RecognitionException [1]
    {   
        SimpleLanguageParser.value_return retval = new SimpleLanguageParser.value_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken LEFTPAREN13 = null;
        IToken RIGHTPAREN15 = null;
        IToken NUMBER16 = null;
        IToken IDENTIFIER17 = null;
        SimpleLanguageParser.expression_return expression14 = default(SimpleLanguageParser.expression_return);


        object LEFTPAREN13_tree=null;
        object RIGHTPAREN15_tree=null;
        object NUMBER16_tree=null;
        object IDENTIFIER17_tree=null;

        try 
    	{
            // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:37:2: ( ( LEFTPAREN expression RIGHTPAREN ) | NUMBER | IDENTIFIER )
            int alt5 = 3;
            switch ( input.LA(1) ) 
            {
            case LEFTPAREN:
            	{
                alt5 = 1;
                }
                break;
            case NUMBER:
            	{
                alt5 = 2;
                }
                break;
            case IDENTIFIER:
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
                    // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:37:4: ( LEFTPAREN expression RIGHTPAREN )
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	// E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:37:4: ( LEFTPAREN expression RIGHTPAREN )
                    	// E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:37:5: LEFTPAREN expression RIGHTPAREN
                    	{
                    		LEFTPAREN13=(IToken)Match(input,LEFTPAREN,FOLLOW_LEFTPAREN_in_value158); 
                    			LEFTPAREN13_tree = (object)adaptor.Create(LEFTPAREN13);
                    			adaptor.AddChild(root_0, LEFTPAREN13_tree);

                    		PushFollow(FOLLOW_expression_in_value160);
                    		expression14 = expression();
                    		state.followingStackPointer--;

                    		adaptor.AddChild(root_0, expression14.Tree);
                    		RIGHTPAREN15=(IToken)Match(input,RIGHTPAREN,FOLLOW_RIGHTPAREN_in_value162); 
                    			RIGHTPAREN15_tree = (object)adaptor.Create(RIGHTPAREN15);
                    			adaptor.AddChild(root_0, RIGHTPAREN15_tree);


                    	}


                    }
                    break;
                case 2 :
                    // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:37:40: NUMBER
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	NUMBER16=(IToken)Match(input,NUMBER,FOLLOW_NUMBER_in_value167); 
                    		NUMBER16_tree = (object)adaptor.Create(NUMBER16);
                    		adaptor.AddChild(root_0, NUMBER16_tree);


                    }
                    break;
                case 3 :
                    // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:37:49: IDENTIFIER
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	IDENTIFIER17=(IToken)Match(input,IDENTIFIER,FOLLOW_IDENTIFIER_in_value171); 
                    		IDENTIFIER17_tree = (object)adaptor.Create(IDENTIFIER17);
                    		adaptor.AddChild(root_0, IDENTIFIER17_tree);


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

 

    public static readonly BitSet FOLLOW_assignment_in_statement77 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IDENTIFIER_in_assignment89 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_ASSIGN_in_assignment91 = new BitSet(new ulong[]{0x0000000000001A00UL});
    public static readonly BitSet FOLLOW_expression_in_assignment94 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_term_in_expression106 = new BitSet(new ulong[]{0x0000000000000032UL});
    public static readonly BitSet FOLLOW_PLUS_in_expression110 = new BitSet(new ulong[]{0x0000000000001A00UL});
    public static readonly BitSet FOLLOW_MINUS_in_expression113 = new BitSet(new ulong[]{0x0000000000001A00UL});
    public static readonly BitSet FOLLOW_term_in_expression117 = new BitSet(new ulong[]{0x0000000000000032UL});
    public static readonly BitSet FOLLOW_value_in_term131 = new BitSet(new ulong[]{0x0000000000001AC2UL});
    public static readonly BitSet FOLLOW_MULT_in_term135 = new BitSet(new ulong[]{0x0000000000001A00UL});
    public static readonly BitSet FOLLOW_DIV_in_term138 = new BitSet(new ulong[]{0x0000000000001A00UL});
    public static readonly BitSet FOLLOW_value_in_term143 = new BitSet(new ulong[]{0x0000000000001AC2UL});
    public static readonly BitSet FOLLOW_LEFTPAREN_in_value158 = new BitSet(new ulong[]{0x0000000000001A00UL});
    public static readonly BitSet FOLLOW_expression_in_value160 = new BitSet(new ulong[]{0x0000000000000400UL});
    public static readonly BitSet FOLLOW_RIGHTPAREN_in_value162 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NUMBER_in_value167 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IDENTIFIER_in_value171 = new BitSet(new ulong[]{0x0000000000000002UL});

}
