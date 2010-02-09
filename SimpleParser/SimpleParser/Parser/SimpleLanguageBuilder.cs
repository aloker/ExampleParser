// $ANTLR 3.1.2 E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguageBuilder.g 2010-02-09 12:24:05

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162

using SimpleParser;	
using SimpleParser.Statements;
using SimpleParser.Expressions; 


using System;
using Antlr.Runtime;
using Antlr.Runtime.Tree;using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;



public partial class SimpleLanguageBuilder : TreeParser
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
    public const int ASSIGN = 8;
    public const int NUMBER = 12;
    public const int WHITESPACE = 14;
    public const int PLUS = 4;
    public const int DIGIT = 13;
    public const int LOWER = 16;
    public const int DIV = 7;
    public const int MULT = 6;
    public const int MINUS = 5;
    public const int EOF = -1;
    public const int UPPER = 17;

    // delegates
    // delegators



        public SimpleLanguageBuilder(ITreeNodeStream input)
    		: this(input, new RecognizerSharedState()) {
        }

        public SimpleLanguageBuilder(ITreeNodeStream input, RecognizerSharedState state)
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
		get { return SimpleLanguageBuilder.tokenNames; }
    }

    override public string GrammarFileName {
		get { return "E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguageBuilder.g"; }
    }


    	public Storage Storage{get;set;}
    	
    	Variable GetVariable(string name){
    		return Storage.GetVariable(name, true);
    	}


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
    // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguageBuilder.g:25:1: statement returns [IStatement result] : ^( ASSIGN id= IDENTIFIER expr= expression ) ;
    public SimpleLanguageBuilder.statement_return statement() // throws RecognitionException [1]
    {   
        SimpleLanguageBuilder.statement_return retval = new SimpleLanguageBuilder.statement_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        CommonTree _first_0 = null;
        CommonTree _last = null;

        CommonTree id = null;
        CommonTree ASSIGN1 = null;
        SimpleLanguageBuilder.expression_return expr = default(SimpleLanguageBuilder.expression_return);


        CommonTree id_tree=null;
        CommonTree ASSIGN1_tree=null;

        try 
    	{
            // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguageBuilder.g:26:2: ( ^( ASSIGN id= IDENTIFIER expr= expression ) )
            // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguageBuilder.g:26:4: ^( ASSIGN id= IDENTIFIER expr= expression )
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	_last = (CommonTree)input.LT(1);
            	{
            	CommonTree _save_last_1 = _last;
            	CommonTree _first_1 = null;
            	CommonTree root_1 = (CommonTree)adaptor.GetNilNode();_last = (CommonTree)input.LT(1);
            	ASSIGN1=(CommonTree)Match(input,ASSIGN,FOLLOW_ASSIGN_in_statement57); 
            		ASSIGN1_tree = (CommonTree)adaptor.DupNode(ASSIGN1);

            		root_1 = (CommonTree)adaptor.BecomeRoot(ASSIGN1_tree, root_1);



            	Match(input, Token.DOWN, null); 
            	_last = (CommonTree)input.LT(1);
            	id=(CommonTree)Match(input,IDENTIFIER,FOLLOW_IDENTIFIER_in_statement61); 
            		id_tree = (CommonTree)adaptor.DupNode(id);

            		adaptor.AddChild(root_1, id_tree);

            	_last = (CommonTree)input.LT(1);
            	PushFollow(FOLLOW_expression_in_statement65);
            	expr = expression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_1, expr.Tree);

            	Match(input, Token.UP, null); adaptor.AddChild(root_0, root_1);_last = _save_last_1;
            	}

            	 retval.result =  new Assignment(Storage.GetVariable(((id != null) ? id.Text : null), true), ((expr != null) ? expr.result : default(IExpression)));

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
    // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguageBuilder.g:30:1: expression returns [IExpression result] : ( ^( PLUS left= expression right= expression ) | ^( MINUS left= expression right= expression ) | ^( MULT left= expression right= expression ) | ^( DIV left= expression right= expression ) | NUMBER | IDENTIFIER );
    public SimpleLanguageBuilder.expression_return expression() // throws RecognitionException [1]
    {   
        SimpleLanguageBuilder.expression_return retval = new SimpleLanguageBuilder.expression_return();
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
        SimpleLanguageBuilder.expression_return left = default(SimpleLanguageBuilder.expression_return);

        SimpleLanguageBuilder.expression_return right = default(SimpleLanguageBuilder.expression_return);


        CommonTree PLUS2_tree=null;
        CommonTree MINUS3_tree=null;
        CommonTree MULT4_tree=null;
        CommonTree DIV5_tree=null;
        CommonTree NUMBER6_tree=null;
        CommonTree IDENTIFIER7_tree=null;

        try 
    	{
            // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguageBuilder.g:31:2: ( ^( PLUS left= expression right= expression ) | ^( MINUS left= expression right= expression ) | ^( MULT left= expression right= expression ) | ^( DIV left= expression right= expression ) | NUMBER | IDENTIFIER )
            int alt1 = 6;
            switch ( input.LA(1) ) 
            {
            case PLUS:
            	{
                alt1 = 1;
                }
                break;
            case MINUS:
            	{
                alt1 = 2;
                }
                break;
            case MULT:
            	{
                alt1 = 3;
                }
                break;
            case DIV:
            	{
                alt1 = 4;
                }
                break;
            case NUMBER:
            	{
                alt1 = 5;
                }
                break;
            case IDENTIFIER:
            	{
                alt1 = 6;
                }
                break;
            	default:
            	    NoViableAltException nvae_d1s0 =
            	        new NoViableAltException("", 1, 0, input);

            	    throw nvae_d1s0;
            }

            switch (alt1) 
            {
                case 1 :
                    // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguageBuilder.g:31:5: ^( PLUS left= expression right= expression )
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	_last = (CommonTree)input.LT(1);
                    	{
                    	CommonTree _save_last_1 = _last;
                    	CommonTree _first_1 = null;
                    	CommonTree root_1 = (CommonTree)adaptor.GetNilNode();_last = (CommonTree)input.LT(1);
                    	PLUS2=(CommonTree)Match(input,PLUS,FOLLOW_PLUS_in_expression88); 
                    		PLUS2_tree = (CommonTree)adaptor.DupNode(PLUS2);

                    		root_1 = (CommonTree)adaptor.BecomeRoot(PLUS2_tree, root_1);



                    	Match(input, Token.DOWN, null); 
                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_expression_in_expression92);
                    	left = expression();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_1, left.Tree);
                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_expression_in_expression96);
                    	right = expression();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_1, right.Tree);

                    	Match(input, Token.UP, null); adaptor.AddChild(root_0, root_1);_last = _save_last_1;
                    	}

                    	 retval.result =  SimpleBinaryExpression.Add(left.result, right.result);

                    }
                    break;
                case 2 :
                    // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguageBuilder.g:32:4: ^( MINUS left= expression right= expression )
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	_last = (CommonTree)input.LT(1);
                    	{
                    	CommonTree _save_last_1 = _last;
                    	CommonTree _first_1 = null;
                    	CommonTree root_1 = (CommonTree)adaptor.GetNilNode();_last = (CommonTree)input.LT(1);
                    	MINUS3=(CommonTree)Match(input,MINUS,FOLLOW_MINUS_in_expression106); 
                    		MINUS3_tree = (CommonTree)adaptor.DupNode(MINUS3);

                    		root_1 = (CommonTree)adaptor.BecomeRoot(MINUS3_tree, root_1);



                    	Match(input, Token.DOWN, null); 
                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_expression_in_expression110);
                    	left = expression();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_1, left.Tree);
                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_expression_in_expression114);
                    	right = expression();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_1, right.Tree);

                    	Match(input, Token.UP, null); adaptor.AddChild(root_0, root_1);_last = _save_last_1;
                    	}

                    	 retval.result =  SimpleBinaryExpression.Subtract(left.result, right.result);

                    }
                    break;
                case 3 :
                    // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguageBuilder.g:33:4: ^( MULT left= expression right= expression )
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	_last = (CommonTree)input.LT(1);
                    	{
                    	CommonTree _save_last_1 = _last;
                    	CommonTree _first_1 = null;
                    	CommonTree root_1 = (CommonTree)adaptor.GetNilNode();_last = (CommonTree)input.LT(1);
                    	MULT4=(CommonTree)Match(input,MULT,FOLLOW_MULT_in_expression123); 
                    		MULT4_tree = (CommonTree)adaptor.DupNode(MULT4);

                    		root_1 = (CommonTree)adaptor.BecomeRoot(MULT4_tree, root_1);



                    	Match(input, Token.DOWN, null); 
                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_expression_in_expression127);
                    	left = expression();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_1, left.Tree);
                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_expression_in_expression131);
                    	right = expression();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_1, right.Tree);

                    	Match(input, Token.UP, null); adaptor.AddChild(root_0, root_1);_last = _save_last_1;
                    	}

                    	 retval.result =  SimpleBinaryExpression.Multiply(left.result, right.result);

                    }
                    break;
                case 4 :
                    // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguageBuilder.g:34:4: ^( DIV left= expression right= expression )
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	_last = (CommonTree)input.LT(1);
                    	{
                    	CommonTree _save_last_1 = _last;
                    	CommonTree _first_1 = null;
                    	CommonTree root_1 = (CommonTree)adaptor.GetNilNode();_last = (CommonTree)input.LT(1);
                    	DIV5=(CommonTree)Match(input,DIV,FOLLOW_DIV_in_expression141); 
                    		DIV5_tree = (CommonTree)adaptor.DupNode(DIV5);

                    		root_1 = (CommonTree)adaptor.BecomeRoot(DIV5_tree, root_1);



                    	Match(input, Token.DOWN, null); 
                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_expression_in_expression145);
                    	left = expression();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_1, left.Tree);
                    	_last = (CommonTree)input.LT(1);
                    	PushFollow(FOLLOW_expression_in_expression149);
                    	right = expression();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_1, right.Tree);

                    	Match(input, Token.UP, null); adaptor.AddChild(root_0, root_1);_last = _save_last_1;
                    	}

                    	 retval.result =  SimpleBinaryExpression.Divide(left.result, right.result);

                    }
                    break;
                case 5 :
                    // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguageBuilder.g:35:11: NUMBER
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	_last = (CommonTree)input.LT(1);
                    	NUMBER6=(CommonTree)Match(input,NUMBER,FOLLOW_NUMBER_in_expression164); 
                    		NUMBER6_tree = (CommonTree)adaptor.DupNode(NUMBER6);

                    		adaptor.AddChild(root_0, NUMBER6_tree);

                    	 retval.result =  new ConstantExpression(Convert.ToInt32(((NUMBER6 != null) ? NUMBER6.Text : null)));

                    }
                    break;
                case 6 :
                    // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguageBuilder.g:36:4: IDENTIFIER
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	_last = (CommonTree)input.LT(1);
                    	IDENTIFIER7=(CommonTree)Match(input,IDENTIFIER,FOLLOW_IDENTIFIER_in_expression171); 
                    		IDENTIFIER7_tree = (CommonTree)adaptor.DupNode(IDENTIFIER7);

                    		adaptor.AddChild(root_0, IDENTIFIER7_tree);

                    	 retval.result =  new VariableExpression( Storage.GetVariable(((IDENTIFIER7 != null) ? IDENTIFIER7.Text : null), true));

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

 

    public static readonly BitSet FOLLOW_ASSIGN_in_statement57 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_IDENTIFIER_in_statement61 = new BitSet(new ulong[]{0x00000000000018F0UL});
    public static readonly BitSet FOLLOW_expression_in_statement65 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_PLUS_in_expression88 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression92 = new BitSet(new ulong[]{0x00000000000018F0UL});
    public static readonly BitSet FOLLOW_expression_in_expression96 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_MINUS_in_expression106 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression110 = new BitSet(new ulong[]{0x00000000000018F0UL});
    public static readonly BitSet FOLLOW_expression_in_expression114 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_MULT_in_expression123 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression127 = new BitSet(new ulong[]{0x00000000000018F0UL});
    public static readonly BitSet FOLLOW_expression_in_expression131 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_DIV_in_expression141 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression145 = new BitSet(new ulong[]{0x00000000000018F0UL});
    public static readonly BitSet FOLLOW_expression_in_expression149 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_NUMBER_in_expression164 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IDENTIFIER_in_expression171 = new BitSet(new ulong[]{0x0000000000000002UL});

}
