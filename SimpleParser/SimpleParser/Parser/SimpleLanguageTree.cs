// $ANTLR 3.1.2 E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguageTree.g 2010-02-09 14:20:48

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162
namespace  SimpleParser.Parser 
{

using SimpleParser;	
using SimpleParser.Statements;
using SimpleParser.Expressions; 


using System;
using Antlr.Runtime;
using Antlr.Runtime.Tree;using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;



public partial class SimpleLanguageTree : TreeParser
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
    public const int ASSIGN = 8;
    public const int NUMBER = 13;
    public const int WHITESPACE = 15;
    public const int PLUS = 4;
    public const int DIGIT = 14;
    public const int LOWER = 17;
    public const int DIV = 7;
    public const int MULT = 6;
    public const int MINUS = 5;
    public const int EOF = -1;
    public const int UPPER = 18;

    // delegates
    // delegators



        public SimpleLanguageTree(ITreeNodeStream input)
    		: this(input, new RecognizerSharedState()) {
        }

        public SimpleLanguageTree(ITreeNodeStream input, RecognizerSharedState state)
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
		get { return SimpleLanguageTree.tokenNames; }
    }

    override public string GrammarFileName {
		get { return "E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguageTree.g"; }
    }


    	private ParsedProgram prog = new ParsedProgram();



    public class program_return : TreeRuleReturnScope
    {
        public ParsedProgram Result;
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "program"
    // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguageTree.g:25:1: program returns [ParsedProgram Result] : (s= statement )* ;
    public SimpleLanguageTree.program_return program() // throws RecognitionException [1]
    {   
        SimpleLanguageTree.program_return retval = new SimpleLanguageTree.program_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        CommonTree _first_0 = null;
        CommonTree _last = null;

        SimpleLanguageTree.statement_return s = default(SimpleLanguageTree.statement_return);



        try 
    	{
            // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguageTree.g:26:2: ( (s= statement )* )
            // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguageTree.g:26:4: (s= statement )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	// E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguageTree.g:26:4: (s= statement )*
            	do 
            	{
            	    int alt1 = 2;
            	    int LA1_0 = input.LA(1);

            	    if ( (LA1_0 == ASSIGN) )
            	    {
            	        alt1 = 1;
            	    }


            	    switch (alt1) 
            		{
            			case 1 :
            			    // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguageTree.g:26:5: s= statement
            			    {
            			    	_last = (CommonTree)input.LT(1);
            			    	PushFollow(FOLLOW_statement_in_program66);
            			    	s = statement();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, s.Tree);
            			    	prog.AddStatement(((s != null) ? s.result : default(IStatement)));

            			    }
            			    break;

            			default:
            			    goto loop1;
            	    }
            	} while (true);

            	loop1:
            		;	// Stops C# compiler whining that label 'loop1' has no statements

            	 retval.Result =  prog;

            }

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "program"

    public class statement_return : TreeRuleReturnScope
    {
        public IStatement result;
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "statement"
    // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguageTree.g:29:1: statement returns [IStatement result] : ^( ASSIGN id= IDENTIFIER expr= expression ) ;
    public SimpleLanguageTree.statement_return statement() // throws RecognitionException [1]
    {   
        SimpleLanguageTree.statement_return retval = new SimpleLanguageTree.statement_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        CommonTree _first_0 = null;
        CommonTree _last = null;

        CommonTree id = null;
        CommonTree ASSIGN1 = null;
        SimpleLanguageTree.expression_return expr = default(SimpleLanguageTree.expression_return);


        CommonTree id_tree=null;
        CommonTree ASSIGN1_tree=null;

        try 
    	{
            // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguageTree.g:30:2: ( ^( ASSIGN id= IDENTIFIER expr= expression ) )
            // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguageTree.g:30:4: ^( ASSIGN id= IDENTIFIER expr= expression )
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	_last = (CommonTree)input.LT(1);
            	{
            	CommonTree _save_last_1 = _last;
            	CommonTree _first_1 = null;
            	CommonTree root_1 = (CommonTree)adaptor.GetNilNode();_last = (CommonTree)input.LT(1);
            	ASSIGN1=(CommonTree)Match(input,ASSIGN,FOLLOW_ASSIGN_in_statement88); 
            		ASSIGN1_tree = (CommonTree)adaptor.DupNode(ASSIGN1);

            		root_1 = (CommonTree)adaptor.BecomeRoot(ASSIGN1_tree, root_1);



            	Match(input, Token.DOWN, null); 
            	_last = (CommonTree)input.LT(1);
            	id=(CommonTree)Match(input,IDENTIFIER,FOLLOW_IDENTIFIER_in_statement92); 
            		id_tree = (CommonTree)adaptor.DupNode(id);

            		adaptor.AddChild(root_1, id_tree);

            	_last = (CommonTree)input.LT(1);
            	PushFollow(FOLLOW_expression_in_statement96);
            	expr = expression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_1, expr.Tree);

            	Match(input, Token.UP, null); adaptor.AddChild(root_0, root_1);_last = _save_last_1;
            	}

            	 retval.result =  new Assignment(((id != null) ? id.Text : null), ((expr != null) ? expr.result : default(IExpression)));

            }

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "statement"

    public class expression_return : TreeRuleReturnScope
    {
        public IExpression result;
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "expression"
    // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguageTree.g:34:1: expression returns [IExpression result] : ( ^( PLUS left= expression right= expression ) | ^( MINUS left= expression right= expression ) | ^( MULT left= expression right= expression ) | ^( DIV left= expression right= expression ) | NUMBER | IDENTIFIER );
    public SimpleLanguageTree.expression_return expression() // throws RecognitionException [1]
    {   
        SimpleLanguageTree.expression_return retval = new SimpleLanguageTree.expression_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        CommonTree _first_0 = null;
        CommonTree _last = null;

        CommonTree PLUS2 = null;
        CommonTree MINUS3 = null;
        CommonTree MULT4 = null;
        CommonTree DIV5 = null;
        CommonTree NUMBER6 = null;
        CommonTree IDENTIFIER7 = null;
        SimpleLanguageTree.expression_return left = default(SimpleLanguageTree.expression_return);

        SimpleLanguageTree.expression_return right = default(SimpleLanguageTree.expression_return);


        CommonTree PLUS2_tree=null;
        CommonTree MINUS3_tree=null;
        CommonTree MULT4_tree=null;
        CommonTree DIV5_tree=null;
        CommonTree NUMBER6_tree=null;
        CommonTree IDENTIFIER7_tree=null;

        try 
    	{
            // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguageTree.g:35:2: ( ^( PLUS left= expression right= expression ) | ^( MINUS left= expression right= expression ) | ^( MULT left= expression right= expression ) | ^( DIV left= expression right= expression ) | NUMBER | IDENTIFIER )
            int alt2 = 6;
            switch ( input.LA(1) ) 
            {
            case PLUS:
            	{
                alt2 = 1;
                }
                break;
            case MINUS:
            	{
                alt2 = 2;
                }
                break;
            case MULT:
            	{
                alt2 = 3;
                }
                break;
            case DIV:
            	{
                alt2 = 4;
                }
                break;
            case NUMBER:
            	{
                alt2 = 5;
                }
                break;
            case IDENTIFIER:
            	{
                alt2 = 6;
                }
                break;
            	default:
            	    NoViableAltException nvae_d2s0 =
            	        new NoViableAltException("", 2, 0, input);

            	    throw nvae_d2s0;
            }

            switch (alt2) 
            {
                case 1 :
                    // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguageTree.g:35:5: ^( PLUS left= expression right= expression )
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	_last = (CommonTree)input.LT(1);
                    	{
                    	CommonTree _save_last_1 = _last;
                    	CommonTree _first_1 = null;
                    	CommonTree root_1 = (CommonTree)adaptor.GetNilNode();_last = (CommonTree)input.LT(1);
                    	PLUS2=(CommonTree)Match(input,PLUS,FOLLOW_PLUS_in_expression119); 
                    		PLUS2_tree = (CommonTree)adaptor.DupNode(PLUS2);

                    		root_1 = (CommonTree)adaptor.BecomeRoot(PLUS2_tree, root_1);



                    	Match(input, Token.DOWN, null); 
                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_expression_in_expression123);
                    	left = expression();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_1, left.Tree);
                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_expression_in_expression127);
                    	right = expression();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_1, right.Tree);

                    	Match(input, Token.UP, null); adaptor.AddChild(root_0, root_1);_last = _save_last_1;
                    	}

                    	 retval.result =  SimpleBinaryExpression.Add(left.result, right.result);

                    }
                    break;
                case 2 :
                    // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguageTree.g:36:4: ^( MINUS left= expression right= expression )
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	_last = (CommonTree)input.LT(1);
                    	{
                    	CommonTree _save_last_1 = _last;
                    	CommonTree _first_1 = null;
                    	CommonTree root_1 = (CommonTree)adaptor.GetNilNode();_last = (CommonTree)input.LT(1);
                    	MINUS3=(CommonTree)Match(input,MINUS,FOLLOW_MINUS_in_expression137); 
                    		MINUS3_tree = (CommonTree)adaptor.DupNode(MINUS3);

                    		root_1 = (CommonTree)adaptor.BecomeRoot(MINUS3_tree, root_1);



                    	Match(input, Token.DOWN, null); 
                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_expression_in_expression141);
                    	left = expression();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_1, left.Tree);
                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_expression_in_expression145);
                    	right = expression();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_1, right.Tree);

                    	Match(input, Token.UP, null); adaptor.AddChild(root_0, root_1);_last = _save_last_1;
                    	}

                    	 retval.result =  SimpleBinaryExpression.Subtract(left.result, right.result);

                    }
                    break;
                case 3 :
                    // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguageTree.g:37:4: ^( MULT left= expression right= expression )
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	_last = (CommonTree)input.LT(1);
                    	{
                    	CommonTree _save_last_1 = _last;
                    	CommonTree _first_1 = null;
                    	CommonTree root_1 = (CommonTree)adaptor.GetNilNode();_last = (CommonTree)input.LT(1);
                    	MULT4=(CommonTree)Match(input,MULT,FOLLOW_MULT_in_expression154); 
                    		MULT4_tree = (CommonTree)adaptor.DupNode(MULT4);

                    		root_1 = (CommonTree)adaptor.BecomeRoot(MULT4_tree, root_1);



                    	Match(input, Token.DOWN, null); 
                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_expression_in_expression158);
                    	left = expression();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_1, left.Tree);
                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_expression_in_expression162);
                    	right = expression();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_1, right.Tree);

                    	Match(input, Token.UP, null); adaptor.AddChild(root_0, root_1);_last = _save_last_1;
                    	}

                    	 retval.result =  SimpleBinaryExpression.Multiply(left.result, right.result);

                    }
                    break;
                case 4 :
                    // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguageTree.g:38:4: ^( DIV left= expression right= expression )
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	_last = (CommonTree)input.LT(1);
                    	{
                    	CommonTree _save_last_1 = _last;
                    	CommonTree _first_1 = null;
                    	CommonTree root_1 = (CommonTree)adaptor.GetNilNode();_last = (CommonTree)input.LT(1);
                    	DIV5=(CommonTree)Match(input,DIV,FOLLOW_DIV_in_expression172); 
                    		DIV5_tree = (CommonTree)adaptor.DupNode(DIV5);

                    		root_1 = (CommonTree)adaptor.BecomeRoot(DIV5_tree, root_1);



                    	Match(input, Token.DOWN, null); 
                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_expression_in_expression176);
                    	left = expression();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_1, left.Tree);
                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_expression_in_expression180);
                    	right = expression();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_1, right.Tree);

                    	Match(input, Token.UP, null); adaptor.AddChild(root_0, root_1);_last = _save_last_1;
                    	}

                    	 retval.result =  SimpleBinaryExpression.Divide(left.result, right.result);

                    }
                    break;
                case 5 :
                    // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguageTree.g:39:11: NUMBER
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	_last = (CommonTree)input.LT(1);
                    	NUMBER6=(CommonTree)Match(input,NUMBER,FOLLOW_NUMBER_in_expression195); 
                    		NUMBER6_tree = (CommonTree)adaptor.DupNode(NUMBER6);

                    		adaptor.AddChild(root_0, NUMBER6_tree);

                    	 retval.result =  new ConstantExpression(Convert.ToInt32(((NUMBER6 != null) ? NUMBER6.Text : null)));

                    }
                    break;
                case 6 :
                    // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguageTree.g:40:4: IDENTIFIER
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	_last = (CommonTree)input.LT(1);
                    	IDENTIFIER7=(CommonTree)Match(input,IDENTIFIER,FOLLOW_IDENTIFIER_in_expression202); 
                    		IDENTIFIER7_tree = (CommonTree)adaptor.DupNode(IDENTIFIER7);

                    		adaptor.AddChild(root_0, IDENTIFIER7_tree);

                    	 retval.result =  new VariableExpression( ((IDENTIFIER7 != null) ? IDENTIFIER7.Text : null));

                    }
                    break;

            }
            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "expression"

    // Delegated rules


	private void InitializeCyclicDFAs()
	{
	}

 

    public static readonly BitSet FOLLOW_statement_in_program66 = new BitSet(new ulong[]{0x0000000000000102UL});
    public static readonly BitSet FOLLOW_ASSIGN_in_statement88 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_IDENTIFIER_in_statement92 = new BitSet(new ulong[]{0x00000000000030F0UL});
    public static readonly BitSet FOLLOW_expression_in_statement96 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_PLUS_in_expression119 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression123 = new BitSet(new ulong[]{0x00000000000030F0UL});
    public static readonly BitSet FOLLOW_expression_in_expression127 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_MINUS_in_expression137 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression141 = new BitSet(new ulong[]{0x00000000000030F0UL});
    public static readonly BitSet FOLLOW_expression_in_expression145 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_MULT_in_expression154 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression158 = new BitSet(new ulong[]{0x00000000000030F0UL});
    public static readonly BitSet FOLLOW_expression_in_expression162 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_DIV_in_expression172 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression176 = new BitSet(new ulong[]{0x00000000000030F0UL});
    public static readonly BitSet FOLLOW_expression_in_expression180 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_NUMBER_in_expression195 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IDENTIFIER_in_expression202 = new BitSet(new ulong[]{0x0000000000000002UL});

}
}