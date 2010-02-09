// $ANTLR 3.1.2 E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\Parser\\SimpleLanguage.g 2010-02-09 15:20:24

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
		get { return "E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\Parser\\SimpleLanguage.g"; }
    }


    public class program_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "program"
    // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\Parser\\SimpleLanguage.g:24:1: program : ( NEWLINE )* expression ( NEWLINE expression )* ( NEWLINE )* EOF ;
    public SimpleLanguageParser.program_return program() // throws RecognitionException [1]
    {   
        SimpleLanguageParser.program_return retval = new SimpleLanguageParser.program_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken NEWLINE1 = null;
        IToken NEWLINE3 = null;
        IToken NEWLINE5 = null;
        IToken EOF6 = null;
        SimpleLanguageParser.expression_return expression2 = default(SimpleLanguageParser.expression_return);

        SimpleLanguageParser.expression_return expression4 = default(SimpleLanguageParser.expression_return);


        CommonTree NEWLINE1_tree=null;
        CommonTree NEWLINE3_tree=null;
        CommonTree NEWLINE5_tree=null;
        CommonTree EOF6_tree=null;

        try 
    	{
            // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\Parser\\SimpleLanguage.g:24:9: ( ( NEWLINE )* expression ( NEWLINE expression )* ( NEWLINE )* EOF )
            // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\Parser\\SimpleLanguage.g:24:11: ( NEWLINE )* expression ( NEWLINE expression )* ( NEWLINE )* EOF
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	// E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\Parser\\SimpleLanguage.g:24:18: ( NEWLINE )*
            	do 
            	{
            	    int alt1 = 2;
            	    int LA1_0 = input.LA(1);

            	    if ( (LA1_0 == NEWLINE) )
            	    {
            	        alt1 = 1;
            	    }


            	    switch (alt1) 
            		{
            			case 1 :
            			    // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\Parser\\SimpleLanguage.g:24:18: NEWLINE
            			    {
            			    	NEWLINE1=(IToken)Match(input,NEWLINE,FOLLOW_NEWLINE_in_program104); 

            			    }
            			    break;

            			default:
            			    goto loop1;
            	    }
            	} while (true);

            	loop1:
            		;	// Stops C# compiler whining that label 'loop1' has no statements

            	PushFollow(FOLLOW_expression_in_program108);
            	expression2 = expression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, expression2.Tree);
            	// E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\Parser\\SimpleLanguage.g:24:32: ( NEWLINE expression )*
            	do 
            	{
            	    int alt2 = 2;
            	    int LA2_0 = input.LA(1);

            	    if ( (LA2_0 == NEWLINE) )
            	    {
            	        int LA2_1 = input.LA(2);

            	        if ( (LA2_1 == LEFTPAREN || (LA2_1 >= IDENTIFIER && LA2_1 <= NUMBER)) )
            	        {
            	            alt2 = 1;
            	        }


            	    }


            	    switch (alt2) 
            		{
            			case 1 :
            			    // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\Parser\\SimpleLanguage.g:24:33: NEWLINE expression
            			    {
            			    	NEWLINE3=(IToken)Match(input,NEWLINE,FOLLOW_NEWLINE_in_program111); 
            			    	PushFollow(FOLLOW_expression_in_program114);
            			    	expression4 = expression();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, expression4.Tree);

            			    }
            			    break;

            			default:
            			    goto loop2;
            	    }
            	} while (true);

            	loop2:
            		;	// Stops C# compiler whining that label 'loop2' has no statements

            	// E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\Parser\\SimpleLanguage.g:24:62: ( NEWLINE )*
            	do 
            	{
            	    int alt3 = 2;
            	    int LA3_0 = input.LA(1);

            	    if ( (LA3_0 == NEWLINE) )
            	    {
            	        alt3 = 1;
            	    }


            	    switch (alt3) 
            		{
            			case 1 :
            			    // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\Parser\\SimpleLanguage.g:24:62: NEWLINE
            			    {
            			    	NEWLINE5=(IToken)Match(input,NEWLINE,FOLLOW_NEWLINE_in_program118); 

            			    }
            			    break;

            			default:
            			    goto loop3;
            	    }
            	} while (true);

            	loop3:
            		;	// Stops C# compiler whining that label 'loop3' has no statements

            	EOF6=(IToken)Match(input,EOF,FOLLOW_EOF_in_program122); 
            		EOF6_tree = (CommonTree)adaptor.Create(EOF6);
            		adaptor.AddChild(root_0, EOF6_tree);


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "program"

    public class expression_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "expression"
    // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\Parser\\SimpleLanguage.g:28:1: expression : ( assignment | ( term ( ( PLUS | MINUS ) term )* ) );
    public SimpleLanguageParser.expression_return expression() // throws RecognitionException [1]
    {   
        SimpleLanguageParser.expression_return retval = new SimpleLanguageParser.expression_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken PLUS9 = null;
        IToken MINUS10 = null;
        SimpleLanguageParser.assignment_return assignment7 = default(SimpleLanguageParser.assignment_return);

        SimpleLanguageParser.term_return term8 = default(SimpleLanguageParser.term_return);

        SimpleLanguageParser.term_return term11 = default(SimpleLanguageParser.term_return);


        CommonTree PLUS9_tree=null;
        CommonTree MINUS10_tree=null;

        try 
    	{
            // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\Parser\\SimpleLanguage.g:29:2: ( assignment | ( term ( ( PLUS | MINUS ) term )* ) )
            int alt6 = 2;
            alt6 = dfa6.Predict(input);
            switch (alt6) 
            {
                case 1 :
                    // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\Parser\\SimpleLanguage.g:29:4: assignment
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_assignment_in_expression136);
                    	assignment7 = assignment();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, assignment7.Tree);

                    }
                    break;
                case 2 :
                    // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\Parser\\SimpleLanguage.g:29:17: ( term ( ( PLUS | MINUS ) term )* )
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	// E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\Parser\\SimpleLanguage.g:29:17: ( term ( ( PLUS | MINUS ) term )* )
                    	// E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\Parser\\SimpleLanguage.g:29:18: term ( ( PLUS | MINUS ) term )*
                    	{
                    		PushFollow(FOLLOW_term_in_expression141);
                    		term8 = term();
                    		state.followingStackPointer--;

                    		adaptor.AddChild(root_0, term8.Tree);
                    		// E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\Parser\\SimpleLanguage.g:29:23: ( ( PLUS | MINUS ) term )*
                    		do 
                    		{
                    		    int alt5 = 2;
                    		    int LA5_0 = input.LA(1);

                    		    if ( ((LA5_0 >= PLUS && LA5_0 <= MINUS)) )
                    		    {
                    		        alt5 = 1;
                    		    }


                    		    switch (alt5) 
                    			{
                    				case 1 :
                    				    // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\Parser\\SimpleLanguage.g:29:24: ( PLUS | MINUS ) term
                    				    {
                    				    	// E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\Parser\\SimpleLanguage.g:29:24: ( PLUS | MINUS )
                    				    	int alt4 = 2;
                    				    	int LA4_0 = input.LA(1);

                    				    	if ( (LA4_0 == PLUS) )
                    				    	{
                    				    	    alt4 = 1;
                    				    	}
                    				    	else if ( (LA4_0 == MINUS) )
                    				    	{
                    				    	    alt4 = 2;
                    				    	}
                    				    	else 
                    				    	{
                    				    	    NoViableAltException nvae_d4s0 =
                    				    	        new NoViableAltException("", 4, 0, input);

                    				    	    throw nvae_d4s0;
                    				    	}
                    				    	switch (alt4) 
                    				    	{
                    				    	    case 1 :
                    				    	        // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\Parser\\SimpleLanguage.g:29:25: PLUS
                    				    	        {
                    				    	        	PLUS9=(IToken)Match(input,PLUS,FOLLOW_PLUS_in_expression145); 
                    				    	        		PLUS9_tree = (CommonTree)adaptor.Create(PLUS9);
                    				    	        		root_0 = (CommonTree)adaptor.BecomeRoot(PLUS9_tree, root_0);


                    				    	        }
                    				    	        break;
                    				    	    case 2 :
                    				    	        // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\Parser\\SimpleLanguage.g:29:31: MINUS
                    				    	        {
                    				    	        	MINUS10=(IToken)Match(input,MINUS,FOLLOW_MINUS_in_expression148); 
                    				    	        		MINUS10_tree = (CommonTree)adaptor.Create(MINUS10);
                    				    	        		root_0 = (CommonTree)adaptor.BecomeRoot(MINUS10_tree, root_0);


                    				    	        }
                    				    	        break;

                    				    	}

                    				    	PushFollow(FOLLOW_term_in_expression152);
                    				    	term11 = term();
                    				    	state.followingStackPointer--;

                    				    	adaptor.AddChild(root_0, term11.Tree);

                    				    }
                    				    break;

                    				default:
                    				    goto loop5;
                    		    }
                    		} while (true);

                    		loop5:
                    			;	// Stops C# compiler whining that label 'loop5' has no statements


                    	}


                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "expression"

    public class assignment_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "assignment"
    // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\Parser\\SimpleLanguage.g:32:1: assignment : IDENTIFIER ASSIGN expression ;
    public SimpleLanguageParser.assignment_return assignment() // throws RecognitionException [1]
    {   
        SimpleLanguageParser.assignment_return retval = new SimpleLanguageParser.assignment_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken IDENTIFIER12 = null;
        IToken ASSIGN13 = null;
        SimpleLanguageParser.expression_return expression14 = default(SimpleLanguageParser.expression_return);


        CommonTree IDENTIFIER12_tree=null;
        CommonTree ASSIGN13_tree=null;

        try 
    	{
            // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\Parser\\SimpleLanguage.g:33:2: ( IDENTIFIER ASSIGN expression )
            // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\Parser\\SimpleLanguage.g:33:4: IDENTIFIER ASSIGN expression
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	IDENTIFIER12=(IToken)Match(input,IDENTIFIER,FOLLOW_IDENTIFIER_in_assignment167); 
            		IDENTIFIER12_tree = (CommonTree)adaptor.Create(IDENTIFIER12);
            		adaptor.AddChild(root_0, IDENTIFIER12_tree);

            	ASSIGN13=(IToken)Match(input,ASSIGN,FOLLOW_ASSIGN_in_assignment169); 
            		ASSIGN13_tree = (CommonTree)adaptor.Create(ASSIGN13);
            		root_0 = (CommonTree)adaptor.BecomeRoot(ASSIGN13_tree, root_0);

            	PushFollow(FOLLOW_expression_in_assignment172);
            	expression14 = expression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, expression14.Tree);

            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "assignment"

    public class term_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "term"
    // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\Parser\\SimpleLanguage.g:36:1: term : value ( ( MULT | DIV | ) value )* ;
    public SimpleLanguageParser.term_return term() // throws RecognitionException [1]
    {   
        SimpleLanguageParser.term_return retval = new SimpleLanguageParser.term_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken MULT16 = null;
        IToken DIV17 = null;
        SimpleLanguageParser.value_return value15 = default(SimpleLanguageParser.value_return);

        SimpleLanguageParser.value_return value18 = default(SimpleLanguageParser.value_return);


        CommonTree MULT16_tree=null;
        CommonTree DIV17_tree=null;

        try 
    	{
            // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\Parser\\SimpleLanguage.g:37:2: ( value ( ( MULT | DIV | ) value )* )
            // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\Parser\\SimpleLanguage.g:37:4: value ( ( MULT | DIV | ) value )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_value_in_term185);
            	value15 = value();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, value15.Tree);
            	// E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\Parser\\SimpleLanguage.g:37:10: ( ( MULT | DIV | ) value )*
            	do 
            	{
            	    int alt8 = 2;
            	    alt8 = dfa8.Predict(input);
            	    switch (alt8) 
            		{
            			case 1 :
            			    // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\Parser\\SimpleLanguage.g:37:11: ( MULT | DIV | ) value
            			    {
            			    	// E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\Parser\\SimpleLanguage.g:37:11: ( MULT | DIV | )
            			    	int alt7 = 3;
            			    	switch ( input.LA(1) ) 
            			    	{
            			    	case MULT:
            			    		{
            			    	    alt7 = 1;
            			    	    }
            			    	    break;
            			    	case DIV:
            			    		{
            			    	    alt7 = 2;
            			    	    }
            			    	    break;
            			    	case LEFTPAREN:
            			    	case IDENTIFIER:
            			    	case NUMBER:
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
            			    	        // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\Parser\\SimpleLanguage.g:37:12: MULT
            			    	        {
            			    	        	MULT16=(IToken)Match(input,MULT,FOLLOW_MULT_in_term189); 
            			    	        		MULT16_tree = (CommonTree)adaptor.Create(MULT16);
            			    	        		root_0 = (CommonTree)adaptor.BecomeRoot(MULT16_tree, root_0);


            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\Parser\\SimpleLanguage.g:37:18: DIV
            			    	        {
            			    	        	DIV17=(IToken)Match(input,DIV,FOLLOW_DIV_in_term192); 
            			    	        		DIV17_tree = (CommonTree)adaptor.Create(DIV17);
            			    	        		root_0 = (CommonTree)adaptor.BecomeRoot(DIV17_tree, root_0);


            			    	        }
            			    	        break;
            			    	    case 3 :
            			    	        // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\Parser\\SimpleLanguage.g:37:23: 
            			    	        {
            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_value_in_term197);
            			    	value18 = value();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, value18.Tree);

            			    }
            			    break;

            			default:
            			    goto loop8;
            	    }
            	} while (true);

            	loop8:
            		;	// Stops C# compiler whining that label 'loop8' has no statements


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "term"

    public class value_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "value"
    // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\Parser\\SimpleLanguage.g:40:1: value : ( ( LEFTPAREN expression RIGHTPAREN ) | NUMBER | IDENTIFIER );
    public SimpleLanguageParser.value_return value() // throws RecognitionException [1]
    {   
        SimpleLanguageParser.value_return retval = new SimpleLanguageParser.value_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken LEFTPAREN19 = null;
        IToken RIGHTPAREN21 = null;
        IToken NUMBER22 = null;
        IToken IDENTIFIER23 = null;
        SimpleLanguageParser.expression_return expression20 = default(SimpleLanguageParser.expression_return);


        CommonTree LEFTPAREN19_tree=null;
        CommonTree RIGHTPAREN21_tree=null;
        CommonTree NUMBER22_tree=null;
        CommonTree IDENTIFIER23_tree=null;

        try 
    	{
            // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\Parser\\SimpleLanguage.g:41:2: ( ( LEFTPAREN expression RIGHTPAREN ) | NUMBER | IDENTIFIER )
            int alt9 = 3;
            switch ( input.LA(1) ) 
            {
            case LEFTPAREN:
            	{
                alt9 = 1;
                }
                break;
            case NUMBER:
            	{
                alt9 = 2;
                }
                break;
            case IDENTIFIER:
            	{
                alt9 = 3;
                }
                break;
            	default:
            	    NoViableAltException nvae_d9s0 =
            	        new NoViableAltException("", 9, 0, input);

            	    throw nvae_d9s0;
            }

            switch (alt9) 
            {
                case 1 :
                    // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\Parser\\SimpleLanguage.g:41:4: ( LEFTPAREN expression RIGHTPAREN )
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	// E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\Parser\\SimpleLanguage.g:41:4: ( LEFTPAREN expression RIGHTPAREN )
                    	// E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\Parser\\SimpleLanguage.g:41:5: LEFTPAREN expression RIGHTPAREN
                    	{
                    		LEFTPAREN19=(IToken)Match(input,LEFTPAREN,FOLLOW_LEFTPAREN_in_value212); 
                    		PushFollow(FOLLOW_expression_in_value215);
                    		expression20 = expression();
                    		state.followingStackPointer--;

                    		adaptor.AddChild(root_0, expression20.Tree);
                    		RIGHTPAREN21=(IToken)Match(input,RIGHTPAREN,FOLLOW_RIGHTPAREN_in_value217); 

                    	}


                    }
                    break;
                case 2 :
                    // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\Parser\\SimpleLanguage.g:41:42: NUMBER
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	NUMBER22=(IToken)Match(input,NUMBER,FOLLOW_NUMBER_in_value223); 
                    		NUMBER22_tree = (CommonTree)adaptor.Create(NUMBER22);
                    		adaptor.AddChild(root_0, NUMBER22_tree);


                    }
                    break;
                case 3 :
                    // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\Parser\\SimpleLanguage.g:41:51: IDENTIFIER
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	IDENTIFIER23=(IToken)Match(input,IDENTIFIER,FOLLOW_IDENTIFIER_in_value227); 
                    		IDENTIFIER23_tree = (CommonTree)adaptor.Create(IDENTIFIER23);
                    		adaptor.AddChild(root_0, IDENTIFIER23_tree);


                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "value"

    // Delegated rules


   	protected DFA6 dfa6;
   	protected DFA8 dfa8;
	private void InitializeCyclicDFAs()
	{
    	this.dfa6 = new DFA6(this);
    	this.dfa8 = new DFA8(this);


	}

    const string DFA6_eotS =
        "\x0f\uffff";
    const string DFA6_eofS =
        "\x01\uffff\x01\x02\x0d\uffff";
    const string DFA6_minS =
        "\x01\x09\x01\x04\x0d\uffff";
    const string DFA6_maxS =
        "\x02\x0d\x0d\uffff";
    const string DFA6_acceptS =
        "\x02\uffff\x01\x02\x01\uffff\x01\x01\x0a\uffff";
    const string DFA6_specialS =
        "\x0f\uffff}>";
    static readonly string[] DFA6_transitionS = {
            "\x01\x02\x02\uffff\x01\x01\x01\x02",
            "\x04\x02\x01\x04\x05\x02",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA6_eot = DFA.UnpackEncodedString(DFA6_eotS);
    static readonly short[] DFA6_eof = DFA.UnpackEncodedString(DFA6_eofS);
    static readonly char[] DFA6_min = DFA.UnpackEncodedStringToUnsignedChars(DFA6_minS);
    static readonly char[] DFA6_max = DFA.UnpackEncodedStringToUnsignedChars(DFA6_maxS);
    static readonly short[] DFA6_accept = DFA.UnpackEncodedString(DFA6_acceptS);
    static readonly short[] DFA6_special = DFA.UnpackEncodedString(DFA6_specialS);
    static readonly short[][] DFA6_transition = DFA.UnpackEncodedStringArray(DFA6_transitionS);

    protected class DFA6 : DFA
    {
        public DFA6(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 6;
            this.eot = DFA6_eot;
            this.eof = DFA6_eof;
            this.min = DFA6_min;
            this.max = DFA6_max;
            this.accept = DFA6_accept;
            this.special = DFA6_special;
            this.transition = DFA6_transition;

        }

        override public string Description
        {
            get { return "28:1: expression : ( assignment | ( term ( ( PLUS | MINUS ) term )* ) );"; }
        }

    }

    const string DFA8_eotS =
        "\x0b\uffff";
    const string DFA8_eofS =
        "\x01\x01\x0a\uffff";
    const string DFA8_minS =
        "\x01\x04\x0a\uffff";
    const string DFA8_maxS =
        "\x01\x0d\x0a\uffff";
    const string DFA8_acceptS =
        "\x01\uffff\x01\x02\x04\uffff\x01\x01\x04\uffff";
    const string DFA8_specialS =
        "\x0b\uffff}>";
    static readonly string[] DFA8_transitionS = {
            "\x02\x01\x02\x06\x01\uffff\x01\x06\x02\x01\x02\x06",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA8_eot = DFA.UnpackEncodedString(DFA8_eotS);
    static readonly short[] DFA8_eof = DFA.UnpackEncodedString(DFA8_eofS);
    static readonly char[] DFA8_min = DFA.UnpackEncodedStringToUnsignedChars(DFA8_minS);
    static readonly char[] DFA8_max = DFA.UnpackEncodedStringToUnsignedChars(DFA8_maxS);
    static readonly short[] DFA8_accept = DFA.UnpackEncodedString(DFA8_acceptS);
    static readonly short[] DFA8_special = DFA.UnpackEncodedString(DFA8_specialS);
    static readonly short[][] DFA8_transition = DFA.UnpackEncodedStringArray(DFA8_transitionS);

    protected class DFA8 : DFA
    {
        public DFA8(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 8;
            this.eot = DFA8_eot;
            this.eof = DFA8_eof;
            this.min = DFA8_min;
            this.max = DFA8_max;
            this.accept = DFA8_accept;
            this.special = DFA8_special;
            this.transition = DFA8_transition;

        }

        override public string Description
        {
            get { return "()* loopback of 37:10: ( ( MULT | DIV | ) value )*"; }
        }

    }

 

    public static readonly BitSet FOLLOW_NEWLINE_in_program104 = new BitSet(new ulong[]{0x0000000000003A00UL});
    public static readonly BitSet FOLLOW_expression_in_program108 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_NEWLINE_in_program111 = new BitSet(new ulong[]{0x0000000000003200UL});
    public static readonly BitSet FOLLOW_expression_in_program114 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_NEWLINE_in_program118 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_EOF_in_program122 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_assignment_in_expression136 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_term_in_expression141 = new BitSet(new ulong[]{0x0000000000000032UL});
    public static readonly BitSet FOLLOW_PLUS_in_expression145 = new BitSet(new ulong[]{0x0000000000003200UL});
    public static readonly BitSet FOLLOW_MINUS_in_expression148 = new BitSet(new ulong[]{0x0000000000003200UL});
    public static readonly BitSet FOLLOW_term_in_expression152 = new BitSet(new ulong[]{0x0000000000000032UL});
    public static readonly BitSet FOLLOW_IDENTIFIER_in_assignment167 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_ASSIGN_in_assignment169 = new BitSet(new ulong[]{0x0000000000003200UL});
    public static readonly BitSet FOLLOW_expression_in_assignment172 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_value_in_term185 = new BitSet(new ulong[]{0x00000000000032C2UL});
    public static readonly BitSet FOLLOW_MULT_in_term189 = new BitSet(new ulong[]{0x0000000000003200UL});
    public static readonly BitSet FOLLOW_DIV_in_term192 = new BitSet(new ulong[]{0x0000000000003200UL});
    public static readonly BitSet FOLLOW_value_in_term197 = new BitSet(new ulong[]{0x00000000000032C2UL});
    public static readonly BitSet FOLLOW_LEFTPAREN_in_value212 = new BitSet(new ulong[]{0x0000000000003200UL});
    public static readonly BitSet FOLLOW_expression_in_value215 = new BitSet(new ulong[]{0x0000000000000400UL});
    public static readonly BitSet FOLLOW_RIGHTPAREN_in_value217 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NUMBER_in_value223 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IDENTIFIER_in_value227 = new BitSet(new ulong[]{0x0000000000000002UL});

}
}