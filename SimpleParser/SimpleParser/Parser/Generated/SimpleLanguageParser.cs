// $ANTLR 3.1.2 E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\Parser\\SimpleLanguage.g 2010-02-09 14:34:40

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
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "program"
    // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\Parser\\SimpleLanguage.g:23:1: program : ( expression ( NEWLINE )? )* EOF ;
    public SimpleLanguageParser.program_return program() // throws RecognitionException [1]
    {   
        SimpleLanguageParser.program_return retval = new SimpleLanguageParser.program_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken NEWLINE2 = null;
        IToken EOF3 = null;
        SimpleLanguageParser.expression_return expression1 = default(SimpleLanguageParser.expression_return);


        object NEWLINE2_tree=null;
        object EOF3_tree=null;

        try 
    	{
            // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\Parser\\SimpleLanguage.g:23:9: ( ( expression ( NEWLINE )? )* EOF )
            // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\Parser\\SimpleLanguage.g:23:11: ( expression ( NEWLINE )? )* EOF
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\Parser\\SimpleLanguage.g:23:11: ( expression ( NEWLINE )? )*
            	do 
            	{
            	    int alt2 = 2;
            	    int LA2_0 = input.LA(1);

            	    if ( (LA2_0 == LEFTPAREN || (LA2_0 >= IDENTIFIER && LA2_0 <= NUMBER)) )
            	    {
            	        alt2 = 1;
            	    }


            	    switch (alt2) 
            		{
            			case 1 :
            			    // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\Parser\\SimpleLanguage.g:23:12: expression ( NEWLINE )?
            			    {
            			    	PushFollow(FOLLOW_expression_in_program99);
            			    	expression1 = expression();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, expression1.Tree);
            			    	// E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\Parser\\SimpleLanguage.g:23:23: ( NEWLINE )?
            			    	int alt1 = 2;
            			    	int LA1_0 = input.LA(1);

            			    	if ( (LA1_0 == NEWLINE) )
            			    	{
            			    	    alt1 = 1;
            			    	}
            			    	switch (alt1) 
            			    	{
            			    	    case 1 :
            			    	        // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\Parser\\SimpleLanguage.g:23:24: NEWLINE
            			    	        {
            			    	        	NEWLINE2=(IToken)Match(input,NEWLINE,FOLLOW_NEWLINE_in_program102); 

            			    	        }
            			    	        break;

            			    	}


            			    }
            			    break;

            			default:
            			    goto loop2;
            	    }
            	} while (true);

            	loop2:
            		;	// Stops C# compiler whining that label 'loop2' has no statements

            	EOF3=(IToken)Match(input,EOF,FOLLOW_EOF_in_program110); 

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
    // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\Parser\\SimpleLanguage.g:27:1: expression : ( assignment | ( term ( ( PLUS | MINUS ) term )* ) );
    public SimpleLanguageParser.expression_return expression() // throws RecognitionException [1]
    {   
        SimpleLanguageParser.expression_return retval = new SimpleLanguageParser.expression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken PLUS6 = null;
        IToken MINUS7 = null;
        SimpleLanguageParser.assignment_return assignment4 = default(SimpleLanguageParser.assignment_return);

        SimpleLanguageParser.term_return term5 = default(SimpleLanguageParser.term_return);

        SimpleLanguageParser.term_return term8 = default(SimpleLanguageParser.term_return);


        object PLUS6_tree=null;
        object MINUS7_tree=null;

        try 
    	{
            // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\Parser\\SimpleLanguage.g:28:2: ( assignment | ( term ( ( PLUS | MINUS ) term )* ) )
            int alt5 = 2;
            alt5 = dfa5.Predict(input);
            switch (alt5) 
            {
                case 1 :
                    // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\Parser\\SimpleLanguage.g:28:4: assignment
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_assignment_in_expression125);
                    	assignment4 = assignment();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, assignment4.Tree);

                    }
                    break;
                case 2 :
                    // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\Parser\\SimpleLanguage.g:28:17: ( term ( ( PLUS | MINUS ) term )* )
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	// E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\Parser\\SimpleLanguage.g:28:17: ( term ( ( PLUS | MINUS ) term )* )
                    	// E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\Parser\\SimpleLanguage.g:28:18: term ( ( PLUS | MINUS ) term )*
                    	{
                    		PushFollow(FOLLOW_term_in_expression130);
                    		term5 = term();
                    		state.followingStackPointer--;

                    		adaptor.AddChild(root_0, term5.Tree);
                    		// E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\Parser\\SimpleLanguage.g:28:23: ( ( PLUS | MINUS ) term )*
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
                    				    // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\Parser\\SimpleLanguage.g:28:24: ( PLUS | MINUS ) term
                    				    {
                    				    	// E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\Parser\\SimpleLanguage.g:28:24: ( PLUS | MINUS )
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
                    				    	        // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\Parser\\SimpleLanguage.g:28:25: PLUS
                    				    	        {
                    				    	        	PLUS6=(IToken)Match(input,PLUS,FOLLOW_PLUS_in_expression134); 
                    				    	        		PLUS6_tree = (object)adaptor.Create(PLUS6);
                    				    	        		root_0 = (object)adaptor.BecomeRoot(PLUS6_tree, root_0);


                    				    	        }
                    				    	        break;
                    				    	    case 2 :
                    				    	        // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\Parser\\SimpleLanguage.g:28:31: MINUS
                    				    	        {
                    				    	        	MINUS7=(IToken)Match(input,MINUS,FOLLOW_MINUS_in_expression137); 
                    				    	        		MINUS7_tree = (object)adaptor.Create(MINUS7);
                    				    	        		root_0 = (object)adaptor.BecomeRoot(MINUS7_tree, root_0);


                    				    	        }
                    				    	        break;

                    				    	}

                    				    	PushFollow(FOLLOW_term_in_expression141);
                    				    	term8 = term();
                    				    	state.followingStackPointer--;

                    				    	adaptor.AddChild(root_0, term8.Tree);

                    				    }
                    				    break;

                    				default:
                    				    goto loop4;
                    		    }
                    		} while (true);

                    		loop4:
                    			;	// Stops C# compiler whining that label 'loop4' has no statements


                    	}


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
    // $ANTLR end "expression"

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
    // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\Parser\\SimpleLanguage.g:31:1: assignment : IDENTIFIER ASSIGN expression ;
    public SimpleLanguageParser.assignment_return assignment() // throws RecognitionException [1]
    {   
        SimpleLanguageParser.assignment_return retval = new SimpleLanguageParser.assignment_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken IDENTIFIER9 = null;
        IToken ASSIGN10 = null;
        SimpleLanguageParser.expression_return expression11 = default(SimpleLanguageParser.expression_return);


        object IDENTIFIER9_tree=null;
        object ASSIGN10_tree=null;

        try 
    	{
            // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\Parser\\SimpleLanguage.g:32:2: ( IDENTIFIER ASSIGN expression )
            // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\Parser\\SimpleLanguage.g:32:4: IDENTIFIER ASSIGN expression
            {
            	root_0 = (object)adaptor.GetNilNode();

            	IDENTIFIER9=(IToken)Match(input,IDENTIFIER,FOLLOW_IDENTIFIER_in_assignment156); 
            		IDENTIFIER9_tree = (object)adaptor.Create(IDENTIFIER9);
            		adaptor.AddChild(root_0, IDENTIFIER9_tree);

            	ASSIGN10=(IToken)Match(input,ASSIGN,FOLLOW_ASSIGN_in_assignment158); 
            		ASSIGN10_tree = (object)adaptor.Create(ASSIGN10);
            		root_0 = (object)adaptor.BecomeRoot(ASSIGN10_tree, root_0);

            	PushFollow(FOLLOW_expression_in_assignment161);
            	expression11 = expression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, expression11.Tree);

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
    // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\Parser\\SimpleLanguage.g:35:1: term : value ( ( MULT | DIV | ) value )* ;
    public SimpleLanguageParser.term_return term() // throws RecognitionException [1]
    {   
        SimpleLanguageParser.term_return retval = new SimpleLanguageParser.term_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken MULT13 = null;
        IToken DIV14 = null;
        SimpleLanguageParser.value_return value12 = default(SimpleLanguageParser.value_return);

        SimpleLanguageParser.value_return value15 = default(SimpleLanguageParser.value_return);


        object MULT13_tree=null;
        object DIV14_tree=null;

        try 
    	{
            // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\Parser\\SimpleLanguage.g:36:2: ( value ( ( MULT | DIV | ) value )* )
            // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\Parser\\SimpleLanguage.g:36:4: value ( ( MULT | DIV | ) value )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_value_in_term174);
            	value12 = value();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, value12.Tree);
            	// E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\Parser\\SimpleLanguage.g:36:10: ( ( MULT | DIV | ) value )*
            	do 
            	{
            	    int alt7 = 2;
            	    alt7 = dfa7.Predict(input);
            	    switch (alt7) 
            		{
            			case 1 :
            			    // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\Parser\\SimpleLanguage.g:36:11: ( MULT | DIV | ) value
            			    {
            			    	// E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\Parser\\SimpleLanguage.g:36:11: ( MULT | DIV | )
            			    	int alt6 = 3;
            			    	switch ( input.LA(1) ) 
            			    	{
            			    	case MULT:
            			    		{
            			    	    alt6 = 1;
            			    	    }
            			    	    break;
            			    	case DIV:
            			    		{
            			    	    alt6 = 2;
            			    	    }
            			    	    break;
            			    	case LEFTPAREN:
            			    	case IDENTIFIER:
            			    	case NUMBER:
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
            			    	        // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\Parser\\SimpleLanguage.g:36:12: MULT
            			    	        {
            			    	        	MULT13=(IToken)Match(input,MULT,FOLLOW_MULT_in_term178); 
            			    	        		MULT13_tree = (object)adaptor.Create(MULT13);
            			    	        		root_0 = (object)adaptor.BecomeRoot(MULT13_tree, root_0);


            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\Parser\\SimpleLanguage.g:36:18: DIV
            			    	        {
            			    	        	DIV14=(IToken)Match(input,DIV,FOLLOW_DIV_in_term181); 
            			    	        		DIV14_tree = (object)adaptor.Create(DIV14);
            			    	        		root_0 = (object)adaptor.BecomeRoot(DIV14_tree, root_0);


            			    	        }
            			    	        break;
            			    	    case 3 :
            			    	        // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\Parser\\SimpleLanguage.g:36:23: 
            			    	        {
            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_value_in_term186);
            			    	value15 = value();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, value15.Tree);

            			    }
            			    break;

            			default:
            			    goto loop7;
            	    }
            	} while (true);

            	loop7:
            		;	// Stops C# compiler whining that label 'loop7' has no statements


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
    // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\Parser\\SimpleLanguage.g:39:1: value : ( ( LEFTPAREN expression RIGHTPAREN ) | NUMBER | IDENTIFIER );
    public SimpleLanguageParser.value_return value() // throws RecognitionException [1]
    {   
        SimpleLanguageParser.value_return retval = new SimpleLanguageParser.value_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken LEFTPAREN16 = null;
        IToken RIGHTPAREN18 = null;
        IToken NUMBER19 = null;
        IToken IDENTIFIER20 = null;
        SimpleLanguageParser.expression_return expression17 = default(SimpleLanguageParser.expression_return);


        object LEFTPAREN16_tree=null;
        object RIGHTPAREN18_tree=null;
        object NUMBER19_tree=null;
        object IDENTIFIER20_tree=null;

        try 
    	{
            // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\Parser\\SimpleLanguage.g:40:2: ( ( LEFTPAREN expression RIGHTPAREN ) | NUMBER | IDENTIFIER )
            int alt8 = 3;
            switch ( input.LA(1) ) 
            {
            case LEFTPAREN:
            	{
                alt8 = 1;
                }
                break;
            case NUMBER:
            	{
                alt8 = 2;
                }
                break;
            case IDENTIFIER:
            	{
                alt8 = 3;
                }
                break;
            	default:
            	    NoViableAltException nvae_d8s0 =
            	        new NoViableAltException("", 8, 0, input);

            	    throw nvae_d8s0;
            }

            switch (alt8) 
            {
                case 1 :
                    // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\Parser\\SimpleLanguage.g:40:4: ( LEFTPAREN expression RIGHTPAREN )
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	// E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\Parser\\SimpleLanguage.g:40:4: ( LEFTPAREN expression RIGHTPAREN )
                    	// E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\Parser\\SimpleLanguage.g:40:5: LEFTPAREN expression RIGHTPAREN
                    	{
                    		LEFTPAREN16=(IToken)Match(input,LEFTPAREN,FOLLOW_LEFTPAREN_in_value201); 
                    		PushFollow(FOLLOW_expression_in_value204);
                    		expression17 = expression();
                    		state.followingStackPointer--;

                    		adaptor.AddChild(root_0, expression17.Tree);
                    		RIGHTPAREN18=(IToken)Match(input,RIGHTPAREN,FOLLOW_RIGHTPAREN_in_value206); 

                    	}


                    }
                    break;
                case 2 :
                    // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\Parser\\SimpleLanguage.g:40:42: NUMBER
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	NUMBER19=(IToken)Match(input,NUMBER,FOLLOW_NUMBER_in_value212); 
                    		NUMBER19_tree = (object)adaptor.Create(NUMBER19);
                    		adaptor.AddChild(root_0, NUMBER19_tree);


                    }
                    break;
                case 3 :
                    // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\Parser\\SimpleLanguage.g:40:51: IDENTIFIER
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	IDENTIFIER20=(IToken)Match(input,IDENTIFIER,FOLLOW_IDENTIFIER_in_value216); 
                    		IDENTIFIER20_tree = (object)adaptor.Create(IDENTIFIER20);
                    		adaptor.AddChild(root_0, IDENTIFIER20_tree);


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


   	protected DFA5 dfa5;
   	protected DFA7 dfa7;
	private void InitializeCyclicDFAs()
	{
    	this.dfa5 = new DFA5(this);
    	this.dfa7 = new DFA7(this);


	}

    const string DFA5_eotS =
        "\x0f\uffff";
    const string DFA5_eofS =
        "\x01\uffff\x01\x02\x0d\uffff";
    const string DFA5_minS =
        "\x01\x09\x01\x04\x0d\uffff";
    const string DFA5_maxS =
        "\x02\x0d\x0d\uffff";
    const string DFA5_acceptS =
        "\x02\uffff\x01\x02\x01\uffff\x01\x01\x0a\uffff";
    const string DFA5_specialS =
        "\x0f\uffff}>";
    static readonly string[] DFA5_transitionS = {
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

    static readonly short[] DFA5_eot = DFA.UnpackEncodedString(DFA5_eotS);
    static readonly short[] DFA5_eof = DFA.UnpackEncodedString(DFA5_eofS);
    static readonly char[] DFA5_min = DFA.UnpackEncodedStringToUnsignedChars(DFA5_minS);
    static readonly char[] DFA5_max = DFA.UnpackEncodedStringToUnsignedChars(DFA5_maxS);
    static readonly short[] DFA5_accept = DFA.UnpackEncodedString(DFA5_acceptS);
    static readonly short[] DFA5_special = DFA.UnpackEncodedString(DFA5_specialS);
    static readonly short[][] DFA5_transition = DFA.UnpackEncodedStringArray(DFA5_transitionS);

    protected class DFA5 : DFA
    {
        public DFA5(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 5;
            this.eot = DFA5_eot;
            this.eof = DFA5_eof;
            this.min = DFA5_min;
            this.max = DFA5_max;
            this.accept = DFA5_accept;
            this.special = DFA5_special;
            this.transition = DFA5_transition;

        }

        override public string Description
        {
            get { return "27:1: expression : ( assignment | ( term ( ( PLUS | MINUS ) term )* ) );"; }
        }

    }

    const string DFA7_eotS =
        "\x0e\uffff";
    const string DFA7_eofS =
        "\x01\x01\x0d\uffff";
    const string DFA7_minS =
        "\x01\x04\x05\uffff\x01\x09\x07\uffff";
    const string DFA7_maxS =
        "\x01\x0d\x05\uffff\x01\x0d\x07\uffff";
    const string DFA7_acceptS =
        "\x01\uffff\x01\x02\x03\uffff\x01\x01\x01\uffff\x01\x01\x03\uffff"+
        "\x03\x01";
    const string DFA7_specialS =
        "\x0e\uffff}>";
    static readonly string[] DFA7_transitionS = {
            "\x02\x01\x02\x07\x01\uffff\x01\x06\x02\x01\x01\x05\x01\x07",
            "",
            "",
            "",
            "",
            "",
            "\x01\x0c\x02\uffff\x01\x0b\x01\x0d",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA7_eot = DFA.UnpackEncodedString(DFA7_eotS);
    static readonly short[] DFA7_eof = DFA.UnpackEncodedString(DFA7_eofS);
    static readonly char[] DFA7_min = DFA.UnpackEncodedStringToUnsignedChars(DFA7_minS);
    static readonly char[] DFA7_max = DFA.UnpackEncodedStringToUnsignedChars(DFA7_maxS);
    static readonly short[] DFA7_accept = DFA.UnpackEncodedString(DFA7_acceptS);
    static readonly short[] DFA7_special = DFA.UnpackEncodedString(DFA7_specialS);
    static readonly short[][] DFA7_transition = DFA.UnpackEncodedStringArray(DFA7_transitionS);

    protected class DFA7 : DFA
    {
        public DFA7(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 7;
            this.eot = DFA7_eot;
            this.eof = DFA7_eof;
            this.min = DFA7_min;
            this.max = DFA7_max;
            this.accept = DFA7_accept;
            this.special = DFA7_special;
            this.transition = DFA7_transition;

        }

        override public string Description
        {
            get { return "()* loopback of 36:10: ( ( MULT | DIV | ) value )*"; }
        }

    }

 

    public static readonly BitSet FOLLOW_expression_in_program99 = new BitSet(new ulong[]{0x0000000000003A00UL});
    public static readonly BitSet FOLLOW_NEWLINE_in_program102 = new BitSet(new ulong[]{0x0000000000003A00UL});
    public static readonly BitSet FOLLOW_EOF_in_program110 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_assignment_in_expression125 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_term_in_expression130 = new BitSet(new ulong[]{0x0000000000000032UL});
    public static readonly BitSet FOLLOW_PLUS_in_expression134 = new BitSet(new ulong[]{0x0000000000003A00UL});
    public static readonly BitSet FOLLOW_MINUS_in_expression137 = new BitSet(new ulong[]{0x0000000000003A00UL});
    public static readonly BitSet FOLLOW_term_in_expression141 = new BitSet(new ulong[]{0x0000000000000032UL});
    public static readonly BitSet FOLLOW_IDENTIFIER_in_assignment156 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_ASSIGN_in_assignment158 = new BitSet(new ulong[]{0x0000000000003A00UL});
    public static readonly BitSet FOLLOW_expression_in_assignment161 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_value_in_term174 = new BitSet(new ulong[]{0x0000000000003AC2UL});
    public static readonly BitSet FOLLOW_MULT_in_term178 = new BitSet(new ulong[]{0x0000000000003A00UL});
    public static readonly BitSet FOLLOW_DIV_in_term181 = new BitSet(new ulong[]{0x0000000000003A00UL});
    public static readonly BitSet FOLLOW_value_in_term186 = new BitSet(new ulong[]{0x0000000000003AC2UL});
    public static readonly BitSet FOLLOW_LEFTPAREN_in_value201 = new BitSet(new ulong[]{0x0000000000003A00UL});
    public static readonly BitSet FOLLOW_expression_in_value204 = new BitSet(new ulong[]{0x0000000000000400UL});
    public static readonly BitSet FOLLOW_RIGHTPAREN_in_value206 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NUMBER_in_value212 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IDENTIFIER_in_value216 = new BitSet(new ulong[]{0x0000000000000002UL});

}
}