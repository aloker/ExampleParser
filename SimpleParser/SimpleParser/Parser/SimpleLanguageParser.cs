// $ANTLR 3.1.2 E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g 2010-02-09 12:35:05

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
		"SEMICOLON", 
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
    public const int LETTER = 16;
    public const int IDENTIFIER = 12;
    public const int NUMBER = 13;
    public const int ASSIGN = 8;
    public const int WHITESPACE = 15;
    public const int PLUS = 4;
    public const int SEMICOLON = 11;
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
    // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:21:1: statement : ( assignment SEMICOLON )+ -> ( assignment )+ ;
    public SimpleLanguageParser.statement_return statement() // throws RecognitionException [1]
    {   
        SimpleLanguageParser.statement_return retval = new SimpleLanguageParser.statement_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken SEMICOLON2 = null;
        SimpleLanguageParser.assignment_return assignment1 = default(SimpleLanguageParser.assignment_return);


        object SEMICOLON2_tree=null;
        RewriteRuleTokenStream stream_SEMICOLON = new RewriteRuleTokenStream(adaptor,"token SEMICOLON");
        RewriteRuleSubtreeStream stream_assignment = new RewriteRuleSubtreeStream(adaptor,"rule assignment");
        try 
    	{
            // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:22:2: ( ( assignment SEMICOLON )+ -> ( assignment )+ )
            // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:22:4: ( assignment SEMICOLON )+
            {
            	// E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:22:4: ( assignment SEMICOLON )+
            	int cnt1 = 0;
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
            			    // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:22:5: assignment SEMICOLON
            			    {
            			    	PushFollow(FOLLOW_assignment_in_statement84);
            			    	assignment1 = assignment();
            			    	state.followingStackPointer--;

            			    	stream_assignment.Add(assignment1.Tree);
            			    	SEMICOLON2=(IToken)Match(input,SEMICOLON,FOLLOW_SEMICOLON_in_statement86);  
            			    	stream_SEMICOLON.Add(SEMICOLON2);


            			    }
            			    break;

            			default:
            			    if ( cnt1 >= 1 ) goto loop1;
            		            EarlyExitException eee1 =
            		                new EarlyExitException(1, input);
            		            throw eee1;
            	    }
            	    cnt1++;
            	} while (true);

            	loop1:
            		;	// Stops C# compiler whinging that label 'loop1' has no statements



            	// AST REWRITE
            	// elements:          assignment
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 22:28: -> ( assignment )+
            	{
            	    if ( !(stream_assignment.HasNext()) ) {
            	        throw new RewriteEarlyExitException();
            	    }
            	    while ( stream_assignment.HasNext() )
            	    {
            	        adaptor.AddChild(root_0, stream_assignment.NextTree());

            	    }
            	    stream_assignment.Reset();

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
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
    // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:25:1: assignment : IDENTIFIER ASSIGN expression ;
    public SimpleLanguageParser.assignment_return assignment() // throws RecognitionException [1]
    {   
        SimpleLanguageParser.assignment_return retval = new SimpleLanguageParser.assignment_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken IDENTIFIER3 = null;
        IToken ASSIGN4 = null;
        SimpleLanguageParser.expression_return expression5 = default(SimpleLanguageParser.expression_return);


        object IDENTIFIER3_tree=null;
        object ASSIGN4_tree=null;

        try 
    	{
            // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:26:2: ( IDENTIFIER ASSIGN expression )
            // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:26:4: IDENTIFIER ASSIGN expression
            {
            	root_0 = (object)adaptor.GetNilNode();

            	IDENTIFIER3=(IToken)Match(input,IDENTIFIER,FOLLOW_IDENTIFIER_in_assignment105); 
            		IDENTIFIER3_tree = (object)adaptor.Create(IDENTIFIER3);
            		adaptor.AddChild(root_0, IDENTIFIER3_tree);

            	ASSIGN4=(IToken)Match(input,ASSIGN,FOLLOW_ASSIGN_in_assignment107); 
            		ASSIGN4_tree = (object)adaptor.Create(ASSIGN4);
            		root_0 = (object)adaptor.BecomeRoot(ASSIGN4_tree, root_0);

            	PushFollow(FOLLOW_expression_in_assignment110);
            	expression5 = expression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, expression5.Tree);

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
    // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:29:1: expression : term ( ( PLUS | MINUS ) term )* ;
    public SimpleLanguageParser.expression_return expression() // throws RecognitionException [1]
    {   
        SimpleLanguageParser.expression_return retval = new SimpleLanguageParser.expression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken PLUS7 = null;
        IToken MINUS8 = null;
        SimpleLanguageParser.term_return term6 = default(SimpleLanguageParser.term_return);

        SimpleLanguageParser.term_return term9 = default(SimpleLanguageParser.term_return);


        object PLUS7_tree=null;
        object MINUS8_tree=null;

        try 
    	{
            // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:30:2: ( term ( ( PLUS | MINUS ) term )* )
            // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:30:4: term ( ( PLUS | MINUS ) term )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_term_in_expression122);
            	term6 = term();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, term6.Tree);
            	// E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:30:9: ( ( PLUS | MINUS ) term )*
            	do 
            	{
            	    int alt3 = 2;
            	    int LA3_0 = input.LA(1);

            	    if ( ((LA3_0 >= PLUS && LA3_0 <= MINUS)) )
            	    {
            	        alt3 = 1;
            	    }


            	    switch (alt3) 
            		{
            			case 1 :
            			    // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:30:10: ( PLUS | MINUS ) term
            			    {
            			    	// E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:30:10: ( PLUS | MINUS )
            			    	int alt2 = 2;
            			    	int LA2_0 = input.LA(1);

            			    	if ( (LA2_0 == PLUS) )
            			    	{
            			    	    alt2 = 1;
            			    	}
            			    	else if ( (LA2_0 == MINUS) )
            			    	{
            			    	    alt2 = 2;
            			    	}
            			    	else 
            			    	{
            			    	    NoViableAltException nvae_d2s0 =
            			    	        new NoViableAltException("", 2, 0, input);

            			    	    throw nvae_d2s0;
            			    	}
            			    	switch (alt2) 
            			    	{
            			    	    case 1 :
            			    	        // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:30:11: PLUS
            			    	        {
            			    	        	PLUS7=(IToken)Match(input,PLUS,FOLLOW_PLUS_in_expression126); 
            			    	        		PLUS7_tree = (object)adaptor.Create(PLUS7);
            			    	        		root_0 = (object)adaptor.BecomeRoot(PLUS7_tree, root_0);


            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:30:17: MINUS
            			    	        {
            			    	        	MINUS8=(IToken)Match(input,MINUS,FOLLOW_MINUS_in_expression129); 
            			    	        		MINUS8_tree = (object)adaptor.Create(MINUS8);
            			    	        		root_0 = (object)adaptor.BecomeRoot(MINUS8_tree, root_0);


            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_term_in_expression133);
            			    	term9 = term();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, term9.Tree);

            			    }
            			    break;

            			default:
            			    goto loop3;
            	    }
            	} while (true);

            	loop3:
            		;	// Stops C# compiler whining that label 'loop3' has no statements


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
    // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:33:1: term : value ( ( MULT | DIV | ) value )* ;
    public SimpleLanguageParser.term_return term() // throws RecognitionException [1]
    {   
        SimpleLanguageParser.term_return retval = new SimpleLanguageParser.term_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken MULT11 = null;
        IToken DIV12 = null;
        SimpleLanguageParser.value_return value10 = default(SimpleLanguageParser.value_return);

        SimpleLanguageParser.value_return value13 = default(SimpleLanguageParser.value_return);


        object MULT11_tree=null;
        object DIV12_tree=null;

        try 
    	{
            // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:34:2: ( value ( ( MULT | DIV | ) value )* )
            // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:34:4: value ( ( MULT | DIV | ) value )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_value_in_term147);
            	value10 = value();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, value10.Tree);
            	// E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:34:10: ( ( MULT | DIV | ) value )*
            	do 
            	{
            	    int alt5 = 2;
            	    int LA5_0 = input.LA(1);

            	    if ( ((LA5_0 >= MULT && LA5_0 <= DIV) || LA5_0 == LEFTPAREN || (LA5_0 >= IDENTIFIER && LA5_0 <= NUMBER)) )
            	    {
            	        alt5 = 1;
            	    }


            	    switch (alt5) 
            		{
            			case 1 :
            			    // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:34:11: ( MULT | DIV | ) value
            			    {
            			    	// E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:34:11: ( MULT | DIV | )
            			    	int alt4 = 3;
            			    	switch ( input.LA(1) ) 
            			    	{
            			    	case MULT:
            			    		{
            			    	    alt4 = 1;
            			    	    }
            			    	    break;
            			    	case DIV:
            			    		{
            			    	    alt4 = 2;
            			    	    }
            			    	    break;
            			    	case LEFTPAREN:
            			    	case IDENTIFIER:
            			    	case NUMBER:
            			    		{
            			    	    alt4 = 3;
            			    	    }
            			    	    break;
            			    		default:
            			    		    NoViableAltException nvae_d4s0 =
            			    		        new NoViableAltException("", 4, 0, input);

            			    		    throw nvae_d4s0;
            			    	}

            			    	switch (alt4) 
            			    	{
            			    	    case 1 :
            			    	        // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:34:12: MULT
            			    	        {
            			    	        	MULT11=(IToken)Match(input,MULT,FOLLOW_MULT_in_term151); 
            			    	        		MULT11_tree = (object)adaptor.Create(MULT11);
            			    	        		root_0 = (object)adaptor.BecomeRoot(MULT11_tree, root_0);


            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:34:18: DIV
            			    	        {
            			    	        	DIV12=(IToken)Match(input,DIV,FOLLOW_DIV_in_term154); 
            			    	        		DIV12_tree = (object)adaptor.Create(DIV12);
            			    	        		root_0 = (object)adaptor.BecomeRoot(DIV12_tree, root_0);


            			    	        }
            			    	        break;
            			    	    case 3 :
            			    	        // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:34:23: 
            			    	        {
            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_value_in_term159);
            			    	value13 = value();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, value13.Tree);

            			    }
            			    break;

            			default:
            			    goto loop5;
            	    }
            	} while (true);

            	loop5:
            		;	// Stops C# compiler whining that label 'loop5' has no statements


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
    // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:37:1: value : ( ( LEFTPAREN expression RIGHTPAREN ) | NUMBER | IDENTIFIER );
    public SimpleLanguageParser.value_return value() // throws RecognitionException [1]
    {   
        SimpleLanguageParser.value_return retval = new SimpleLanguageParser.value_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken LEFTPAREN14 = null;
        IToken RIGHTPAREN16 = null;
        IToken NUMBER17 = null;
        IToken IDENTIFIER18 = null;
        SimpleLanguageParser.expression_return expression15 = default(SimpleLanguageParser.expression_return);


        object LEFTPAREN14_tree=null;
        object RIGHTPAREN16_tree=null;
        object NUMBER17_tree=null;
        object IDENTIFIER18_tree=null;

        try 
    	{
            // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:38:2: ( ( LEFTPAREN expression RIGHTPAREN ) | NUMBER | IDENTIFIER )
            int alt6 = 3;
            switch ( input.LA(1) ) 
            {
            case LEFTPAREN:
            	{
                alt6 = 1;
                }
                break;
            case NUMBER:
            	{
                alt6 = 2;
                }
                break;
            case IDENTIFIER:
            	{
                alt6 = 3;
                }
                break;
            	default:
            	    NoViableAltException nvae_d6s0 =
            	        new NoViableAltException("", 6, 0, input);

            	    throw nvae_d6s0;
            }

            switch (alt6) 
            {
                case 1 :
                    // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:38:4: ( LEFTPAREN expression RIGHTPAREN )
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	// E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:38:4: ( LEFTPAREN expression RIGHTPAREN )
                    	// E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:38:5: LEFTPAREN expression RIGHTPAREN
                    	{
                    		LEFTPAREN14=(IToken)Match(input,LEFTPAREN,FOLLOW_LEFTPAREN_in_value174); 
                    		PushFollow(FOLLOW_expression_in_value177);
                    		expression15 = expression();
                    		state.followingStackPointer--;

                    		adaptor.AddChild(root_0, expression15.Tree);
                    		RIGHTPAREN16=(IToken)Match(input,RIGHTPAREN,FOLLOW_RIGHTPAREN_in_value179); 

                    	}


                    }
                    break;
                case 2 :
                    // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:38:42: NUMBER
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	NUMBER17=(IToken)Match(input,NUMBER,FOLLOW_NUMBER_in_value185); 
                    		NUMBER17_tree = (object)adaptor.Create(NUMBER17);
                    		adaptor.AddChild(root_0, NUMBER17_tree);


                    }
                    break;
                case 3 :
                    // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:38:51: IDENTIFIER
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	IDENTIFIER18=(IToken)Match(input,IDENTIFIER,FOLLOW_IDENTIFIER_in_value189); 
                    		IDENTIFIER18_tree = (object)adaptor.Create(IDENTIFIER18);
                    		adaptor.AddChild(root_0, IDENTIFIER18_tree);


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

 

    public static readonly BitSet FOLLOW_assignment_in_statement84 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_SEMICOLON_in_statement86 = new BitSet(new ulong[]{0x0000000000001002UL});
    public static readonly BitSet FOLLOW_IDENTIFIER_in_assignment105 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_ASSIGN_in_assignment107 = new BitSet(new ulong[]{0x0000000000003200UL});
    public static readonly BitSet FOLLOW_expression_in_assignment110 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_term_in_expression122 = new BitSet(new ulong[]{0x0000000000000032UL});
    public static readonly BitSet FOLLOW_PLUS_in_expression126 = new BitSet(new ulong[]{0x0000000000003200UL});
    public static readonly BitSet FOLLOW_MINUS_in_expression129 = new BitSet(new ulong[]{0x0000000000003200UL});
    public static readonly BitSet FOLLOW_term_in_expression133 = new BitSet(new ulong[]{0x0000000000000032UL});
    public static readonly BitSet FOLLOW_value_in_term147 = new BitSet(new ulong[]{0x00000000000032C2UL});
    public static readonly BitSet FOLLOW_MULT_in_term151 = new BitSet(new ulong[]{0x0000000000003200UL});
    public static readonly BitSet FOLLOW_DIV_in_term154 = new BitSet(new ulong[]{0x0000000000003200UL});
    public static readonly BitSet FOLLOW_value_in_term159 = new BitSet(new ulong[]{0x00000000000032C2UL});
    public static readonly BitSet FOLLOW_LEFTPAREN_in_value174 = new BitSet(new ulong[]{0x0000000000003200UL});
    public static readonly BitSet FOLLOW_expression_in_value177 = new BitSet(new ulong[]{0x0000000000000400UL});
    public static readonly BitSet FOLLOW_RIGHTPAREN_in_value179 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NUMBER_in_value185 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IDENTIFIER_in_value189 = new BitSet(new ulong[]{0x0000000000000002UL});

}
