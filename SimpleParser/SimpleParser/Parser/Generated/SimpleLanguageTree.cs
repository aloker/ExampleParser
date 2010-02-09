// $ANTLR 3.1.2 E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\Parser\\SimpleLanguageTree.g 2010-02-09 14:36:14

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162
namespace  SimpleParser.Parser 
{
	
using SimpleParser.Parser.Expressions;


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
		get { return "E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\Parser\\SimpleLanguageTree.g"; }
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
    // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\Parser\\SimpleLanguageTree.g:23:1: program returns [ParsedProgram Result] : (s= expression )* ;
    public SimpleLanguageTree.program_return program() // throws RecognitionException [1]
    {   
        SimpleLanguageTree.program_return retval = new SimpleLanguageTree.program_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        CommonTree _first_0 = null;
        CommonTree _last = null;

        SimpleLanguageTree.expression_return s = default(SimpleLanguageTree.expression_return);



        try 
    	{
            // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\Parser\\SimpleLanguageTree.g:24:2: ( (s= expression )* )
            // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\Parser\\SimpleLanguageTree.g:24:4: (s= expression )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	// E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\Parser\\SimpleLanguageTree.g:24:4: (s= expression )*
            	do 
            	{
            	    int alt1 = 2;
            	    int LA1_0 = input.LA(1);

            	    if ( ((LA1_0 >= PLUS && LA1_0 <= ASSIGN) || (LA1_0 >= IDENTIFIER && LA1_0 <= NUMBER)) )
            	    {
            	        alt1 = 1;
            	    }


            	    switch (alt1) 
            		{
            			case 1 :
            			    // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\Parser\\SimpleLanguageTree.g:24:5: s= expression
            			    {
            			    	_last = (CommonTree)input.LT(1);
            			    	PushFollow(FOLLOW_expression_in_program66);
            			    	s = expression();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, s.Tree);
            			    	prog.AddExpression(((s != null) ? s.result : default(IExpression)));

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
    // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\Parser\\SimpleLanguageTree.g:28:1: expression returns [IExpression result] : ( ^( ASSIGN id= IDENTIFIER expr= expression ) | ^( PLUS left= expression right= expression ) | ^( MINUS left= expression right= expression ) | ^( MULT left= expression right= expression ) | ^( DIV left= expression right= expression ) | NUMBER | IDENTIFIER );
    public SimpleLanguageTree.expression_return expression() // throws RecognitionException [1]
    {   
        SimpleLanguageTree.expression_return retval = new SimpleLanguageTree.expression_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        CommonTree _first_0 = null;
        CommonTree _last = null;

        CommonTree id = null;
        CommonTree ASSIGN1 = null;
        CommonTree PLUS2 = null;
        CommonTree MINUS3 = null;
        CommonTree MULT4 = null;
        CommonTree DIV5 = null;
        CommonTree NUMBER6 = null;
        CommonTree IDENTIFIER7 = null;
        SimpleLanguageTree.expression_return expr = default(SimpleLanguageTree.expression_return);

        SimpleLanguageTree.expression_return left = default(SimpleLanguageTree.expression_return);

        SimpleLanguageTree.expression_return right = default(SimpleLanguageTree.expression_return);


        CommonTree id_tree=null;
        CommonTree ASSIGN1_tree=null;
        CommonTree PLUS2_tree=null;
        CommonTree MINUS3_tree=null;
        CommonTree MULT4_tree=null;
        CommonTree DIV5_tree=null;
        CommonTree NUMBER6_tree=null;
        CommonTree IDENTIFIER7_tree=null;

        try 
    	{
            // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\Parser\\SimpleLanguageTree.g:29:2: ( ^( ASSIGN id= IDENTIFIER expr= expression ) | ^( PLUS left= expression right= expression ) | ^( MINUS left= expression right= expression ) | ^( MULT left= expression right= expression ) | ^( DIV left= expression right= expression ) | NUMBER | IDENTIFIER )
            int alt2 = 7;
            switch ( input.LA(1) ) 
            {
            case ASSIGN:
            	{
                alt2 = 1;
                }
                break;
            case PLUS:
            	{
                alt2 = 2;
                }
                break;
            case MINUS:
            	{
                alt2 = 3;
                }
                break;
            case MULT:
            	{
                alt2 = 4;
                }
                break;
            case DIV:
            	{
                alt2 = 5;
                }
                break;
            case NUMBER:
            	{
                alt2 = 6;
                }
                break;
            case IDENTIFIER:
            	{
                alt2 = 7;
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
                    // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\Parser\\SimpleLanguageTree.g:29:6: ^( ASSIGN id= IDENTIFIER expr= expression )
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	_last = (CommonTree)input.LT(1);
                    	{
                    	CommonTree _save_last_1 = _last;
                    	CommonTree _first_1 = null;
                    	CommonTree root_1 = (CommonTree)adaptor.GetNilNode();_last = (CommonTree)input.LT(1);
                    	ASSIGN1=(CommonTree)Match(input,ASSIGN,FOLLOW_ASSIGN_in_expression93); 
                    		ASSIGN1_tree = (CommonTree)adaptor.DupNode(ASSIGN1);

                    		root_1 = (CommonTree)adaptor.BecomeRoot(ASSIGN1_tree, root_1);



                    	Match(input, Token.DOWN, null); 
                    	_last = (CommonTree)input.LT(1);
                    	id=(CommonTree)Match(input,IDENTIFIER,FOLLOW_IDENTIFIER_in_expression97); 
                    		id_tree = (CommonTree)adaptor.DupNode(id);

                    		adaptor.AddChild(root_1, id_tree);

                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_expression_in_expression101);
                    	expr = expression();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_1, expr.Tree);

                    	Match(input, Token.UP, null); adaptor.AddChild(root_0, root_1);_last = _save_last_1;
                    	}

                    	 retval.result =  new Assignment(((id != null) ? id.Text : null), ((expr != null) ? expr.result : default(IExpression)));

                    }
                    break;
                case 2 :
                    // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\Parser\\SimpleLanguageTree.g:30:5: ^( PLUS left= expression right= expression )
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	_last = (CommonTree)input.LT(1);
                    	{
                    	CommonTree _save_last_1 = _last;
                    	CommonTree _first_1 = null;
                    	CommonTree root_1 = (CommonTree)adaptor.GetNilNode();_last = (CommonTree)input.LT(1);
                    	PLUS2=(CommonTree)Match(input,PLUS,FOLLOW_PLUS_in_expression111); 
                    		PLUS2_tree = (CommonTree)adaptor.DupNode(PLUS2);

                    		root_1 = (CommonTree)adaptor.BecomeRoot(PLUS2_tree, root_1);



                    	Match(input, Token.DOWN, null); 
                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_expression_in_expression115);
                    	left = expression();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_1, left.Tree);
                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_expression_in_expression119);
                    	right = expression();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_1, right.Tree);

                    	Match(input, Token.UP, null); adaptor.AddChild(root_0, root_1);_last = _save_last_1;
                    	}

                    	 retval.result =  SimpleBinaryExpression.Add(left.result, right.result);

                    }
                    break;
                case 3 :
                    // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\Parser\\SimpleLanguageTree.g:31:5: ^( MINUS left= expression right= expression )
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	_last = (CommonTree)input.LT(1);
                    	{
                    	CommonTree _save_last_1 = _last;
                    	CommonTree _first_1 = null;
                    	CommonTree root_1 = (CommonTree)adaptor.GetNilNode();_last = (CommonTree)input.LT(1);
                    	MINUS3=(CommonTree)Match(input,MINUS,FOLLOW_MINUS_in_expression130); 
                    		MINUS3_tree = (CommonTree)adaptor.DupNode(MINUS3);

                    		root_1 = (CommonTree)adaptor.BecomeRoot(MINUS3_tree, root_1);



                    	Match(input, Token.DOWN, null); 
                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_expression_in_expression134);
                    	left = expression();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_1, left.Tree);
                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_expression_in_expression138);
                    	right = expression();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_1, right.Tree);

                    	Match(input, Token.UP, null); adaptor.AddChild(root_0, root_1);_last = _save_last_1;
                    	}

                    	 retval.result =  SimpleBinaryExpression.Subtract(left.result, right.result);

                    }
                    break;
                case 4 :
                    // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\Parser\\SimpleLanguageTree.g:32:5: ^( MULT left= expression right= expression )
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	_last = (CommonTree)input.LT(1);
                    	{
                    	CommonTree _save_last_1 = _last;
                    	CommonTree _first_1 = null;
                    	CommonTree root_1 = (CommonTree)adaptor.GetNilNode();_last = (CommonTree)input.LT(1);
                    	MULT4=(CommonTree)Match(input,MULT,FOLLOW_MULT_in_expression148); 
                    		MULT4_tree = (CommonTree)adaptor.DupNode(MULT4);

                    		root_1 = (CommonTree)adaptor.BecomeRoot(MULT4_tree, root_1);



                    	Match(input, Token.DOWN, null); 
                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_expression_in_expression152);
                    	left = expression();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_1, left.Tree);
                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_expression_in_expression156);
                    	right = expression();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_1, right.Tree);

                    	Match(input, Token.UP, null); adaptor.AddChild(root_0, root_1);_last = _save_last_1;
                    	}

                    	 retval.result =  SimpleBinaryExpression.Multiply(left.result, right.result);

                    }
                    break;
                case 5 :
                    // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\Parser\\SimpleLanguageTree.g:33:5: ^( DIV left= expression right= expression )
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	_last = (CommonTree)input.LT(1);
                    	{
                    	CommonTree _save_last_1 = _last;
                    	CommonTree _first_1 = null;
                    	CommonTree root_1 = (CommonTree)adaptor.GetNilNode();_last = (CommonTree)input.LT(1);
                    	DIV5=(CommonTree)Match(input,DIV,FOLLOW_DIV_in_expression167); 
                    		DIV5_tree = (CommonTree)adaptor.DupNode(DIV5);

                    		root_1 = (CommonTree)adaptor.BecomeRoot(DIV5_tree, root_1);



                    	Match(input, Token.DOWN, null); 
                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_expression_in_expression171);
                    	left = expression();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_1, left.Tree);
                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_expression_in_expression175);
                    	right = expression();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_1, right.Tree);

                    	Match(input, Token.UP, null); adaptor.AddChild(root_0, root_1);_last = _save_last_1;
                    	}

                    	 retval.result =  SimpleBinaryExpression.Divide(left.result, right.result);

                    }
                    break;
                case 6 :
                    // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\Parser\\SimpleLanguageTree.g:34:12: NUMBER
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	_last = (CommonTree)input.LT(1);
                    	NUMBER6=(CommonTree)Match(input,NUMBER,FOLLOW_NUMBER_in_expression191); 
                    		NUMBER6_tree = (CommonTree)adaptor.DupNode(NUMBER6);

                    		adaptor.AddChild(root_0, NUMBER6_tree);

                    	 retval.result =  new ConstantExpression(Convert.ToInt32(((NUMBER6 != null) ? NUMBER6.Text : null)));

                    }
                    break;
                case 7 :
                    // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\Parser\\SimpleLanguageTree.g:35:5: IDENTIFIER
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	_last = (CommonTree)input.LT(1);
                    	IDENTIFIER7=(CommonTree)Match(input,IDENTIFIER,FOLLOW_IDENTIFIER_in_expression199); 
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

 

    public static readonly BitSet FOLLOW_expression_in_program66 = new BitSet(new ulong[]{0x00000000000031F2UL});
    public static readonly BitSet FOLLOW_ASSIGN_in_expression93 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_IDENTIFIER_in_expression97 = new BitSet(new ulong[]{0x00000000000031F8UL});
    public static readonly BitSet FOLLOW_expression_in_expression101 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_PLUS_in_expression111 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression115 = new BitSet(new ulong[]{0x00000000000031F8UL});
    public static readonly BitSet FOLLOW_expression_in_expression119 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_MINUS_in_expression130 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression134 = new BitSet(new ulong[]{0x00000000000031F8UL});
    public static readonly BitSet FOLLOW_expression_in_expression138 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_MULT_in_expression148 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression152 = new BitSet(new ulong[]{0x00000000000031F8UL});
    public static readonly BitSet FOLLOW_expression_in_expression156 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_DIV_in_expression167 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression171 = new BitSet(new ulong[]{0x00000000000031F8UL});
    public static readonly BitSet FOLLOW_expression_in_expression175 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_NUMBER_in_expression191 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IDENTIFIER_in_expression199 = new BitSet(new ulong[]{0x0000000000000002UL});

}
}