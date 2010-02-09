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


public partial class SimpleLanguageLexer : Lexer {
    public const int LEFTPAREN = 9;
    public const int RIGHTPAREN = 10;
    public const int LETTER = 16;
    public const int IDENTIFIER = 12;
    public const int ASSIGN = 8;
    public const int NUMBER = 13;
    public const int WHITESPACE = 15;
    public const int PLUS = 4;
    public const int SEMICOLON = 11;
    public const int DIGIT = 14;
    public const int LOWER = 17;
    public const int DIV = 7;
    public const int MULT = 6;
    public const int MINUS = 5;
    public const int EOF = -1;
    public const int UPPER = 18;

    // delegates
    // delegators

    public SimpleLanguageLexer() 
    {
		InitializeCyclicDFAs();
    }
    public SimpleLanguageLexer(ICharStream input)
		: this(input, null) {
    }
    public SimpleLanguageLexer(ICharStream input, RecognizerSharedState state)
		: base(input, state) {
		InitializeCyclicDFAs(); 

    }
    
    override public string GrammarFileName
    {
    	get { return "E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g";} 
    }

    // $ANTLR start "PLUS"
    public void mPLUS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = PLUS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:7:6: ( '+' )
            // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:7:8: '+'
            {
            	Match('+'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "PLUS"

    // $ANTLR start "MINUS"
    public void mMINUS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = MINUS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:8:7: ( '-' )
            // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:8:9: '-'
            {
            	Match('-'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "MINUS"

    // $ANTLR start "MULT"
    public void mMULT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = MULT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:9:6: ( '*' )
            // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:9:8: '*'
            {
            	Match('*'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "MULT"

    // $ANTLR start "DIV"
    public void mDIV() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = DIV;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:10:5: ( '/' )
            // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:10:7: '/'
            {
            	Match('/'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "DIV"

    // $ANTLR start "ASSIGN"
    public void mASSIGN() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ASSIGN;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:11:8: ( '=' )
            // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:11:10: '='
            {
            	Match('='); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ASSIGN"

    // $ANTLR start "LEFTPAREN"
    public void mLEFTPAREN() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = LEFTPAREN;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:12:11: ( '(' )
            // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:12:13: '('
            {
            	Match('('); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "LEFTPAREN"

    // $ANTLR start "RIGHTPAREN"
    public void mRIGHTPAREN() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = RIGHTPAREN;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:13:12: ( ')' )
            // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:13:14: ')'
            {
            	Match(')'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "RIGHTPAREN"

    // $ANTLR start "SEMICOLON"
    public void mSEMICOLON() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = SEMICOLON;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:14:11: ( ';' )
            // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:14:13: ';'
            {
            	Match(';'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "SEMICOLON"

    // $ANTLR start "NUMBER"
    public void mNUMBER() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = NUMBER;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:43:8: ( ( DIGIT )+ )
            // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:43:10: ( DIGIT )+
            {
            	// E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:43:10: ( DIGIT )+
            	int cnt1 = 0;
            	do 
            	{
            	    int alt1 = 2;
            	    int LA1_0 = input.LA(1);

            	    if ( ((LA1_0 >= '0' && LA1_0 <= '9')) )
            	    {
            	        alt1 = 1;
            	    }


            	    switch (alt1) 
            		{
            			case 1 :
            			    // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:43:10: DIGIT
            			    {
            			    	mDIGIT(); 

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


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "NUMBER"

    // $ANTLR start "WHITESPACE"
    public void mWHITESPACE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = WHITESPACE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:45:2: ( ( '\\t' | ' ' | '\\r' | '\\n' | '\\u000C' )+ )
            // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:45:4: ( '\\t' | ' ' | '\\r' | '\\n' | '\\u000C' )+
            {
            	// E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:45:4: ( '\\t' | ' ' | '\\r' | '\\n' | '\\u000C' )+
            	int cnt2 = 0;
            	do 
            	{
            	    int alt2 = 2;
            	    int LA2_0 = input.LA(1);

            	    if ( ((LA2_0 >= '\t' && LA2_0 <= '\n') || (LA2_0 >= '\f' && LA2_0 <= '\r') || LA2_0 == ' ') )
            	    {
            	        alt2 = 1;
            	    }


            	    switch (alt2) 
            		{
            			case 1 :
            			    // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:
            			    {
            			    	if ( (input.LA(1) >= '\t' && input.LA(1) <= '\n') || (input.LA(1) >= '\f' && input.LA(1) <= '\r') || input.LA(1) == ' ' ) 
            			    	{
            			    	    input.Consume();

            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    Recover(mse);
            			    	    throw mse;}


            			    }
            			    break;

            			default:
            			    if ( cnt2 >= 1 ) goto loop2;
            		            EarlyExitException eee2 =
            		                new EarlyExitException(2, input);
            		            throw eee2;
            	    }
            	    cnt2++;
            	} while (true);

            	loop2:
            		;	// Stops C# compiler whinging that label 'loop2' has no statements

            	 _channel = HIDDEN; 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "WHITESPACE"

    // $ANTLR start "IDENTIFIER"
    public void mIDENTIFIER() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = IDENTIFIER;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:47:2: ( LETTER ( DIGIT | LETTER )* )
            // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:47:4: LETTER ( DIGIT | LETTER )*
            {
            	mLETTER(); 
            	// E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:47:11: ( DIGIT | LETTER )*
            	do 
            	{
            	    int alt3 = 2;
            	    int LA3_0 = input.LA(1);

            	    if ( ((LA3_0 >= '0' && LA3_0 <= '9') || (LA3_0 >= 'A' && LA3_0 <= 'Z') || (LA3_0 >= 'a' && LA3_0 <= 'z')) )
            	    {
            	        alt3 = 1;
            	    }


            	    switch (alt3) 
            		{
            			case 1 :
            			    // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:
            			    {
            			    	if ( (input.LA(1) >= '0' && input.LA(1) <= '9') || (input.LA(1) >= 'A' && input.LA(1) <= 'Z') || (input.LA(1) >= 'a' && input.LA(1) <= 'z') ) 
            			    	{
            			    	    input.Consume();

            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    Recover(mse);
            			    	    throw mse;}


            			    }
            			    break;

            			default:
            			    goto loop3;
            	    }
            	} while (true);

            	loop3:
            		;	// Stops C# compiler whining that label 'loop3' has no statements


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "IDENTIFIER"

    // $ANTLR start "LETTER"
    public void mLETTER() // throws RecognitionException [2]
    {
    		try
    		{
            // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:49:16: ( LOWER | UPPER )
            // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:
            {
            	if ( (input.LA(1) >= 'A' && input.LA(1) <= 'Z') || (input.LA(1) >= 'a' && input.LA(1) <= 'z') ) 
            	{
            	    input.Consume();

            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}


            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "LETTER"

    // $ANTLR start "LOWER"
    public void mLOWER() // throws RecognitionException [2]
    {
    		try
    		{
            // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:50:15: ( 'a' .. 'z' )
            // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:50:17: 'a' .. 'z'
            {
            	MatchRange('a','z'); 

            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "LOWER"

    // $ANTLR start "UPPER"
    public void mUPPER() // throws RecognitionException [2]
    {
    		try
    		{
            // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:51:15: ( 'A' .. 'Z' )
            // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:51:17: 'A' .. 'Z'
            {
            	MatchRange('A','Z'); 

            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "UPPER"

    // $ANTLR start "DIGIT"
    public void mDIGIT() // throws RecognitionException [2]
    {
    		try
    		{
            // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:52:15: ( '0' .. '9' )
            // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:52:17: '0' .. '9'
            {
            	MatchRange('0','9'); 

            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "DIGIT"

    override public void mTokens() // throws RecognitionException 
    {
        // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:1:8: ( PLUS | MINUS | MULT | DIV | ASSIGN | LEFTPAREN | RIGHTPAREN | SEMICOLON | NUMBER | WHITESPACE | IDENTIFIER )
        int alt4 = 11;
        switch ( input.LA(1) ) 
        {
        case '+':
        	{
            alt4 = 1;
            }
            break;
        case '-':
        	{
            alt4 = 2;
            }
            break;
        case '*':
        	{
            alt4 = 3;
            }
            break;
        case '/':
        	{
            alt4 = 4;
            }
            break;
        case '=':
        	{
            alt4 = 5;
            }
            break;
        case '(':
        	{
            alt4 = 6;
            }
            break;
        case ')':
        	{
            alt4 = 7;
            }
            break;
        case ';':
        	{
            alt4 = 8;
            }
            break;
        case '0':
        case '1':
        case '2':
        case '3':
        case '4':
        case '5':
        case '6':
        case '7':
        case '8':
        case '9':
        	{
            alt4 = 9;
            }
            break;
        case '\t':
        case '\n':
        case '\f':
        case '\r':
        case ' ':
        	{
            alt4 = 10;
            }
            break;
        case 'A':
        case 'B':
        case 'C':
        case 'D':
        case 'E':
        case 'F':
        case 'G':
        case 'H':
        case 'I':
        case 'J':
        case 'K':
        case 'L':
        case 'M':
        case 'N':
        case 'O':
        case 'P':
        case 'Q':
        case 'R':
        case 'S':
        case 'T':
        case 'U':
        case 'V':
        case 'W':
        case 'X':
        case 'Y':
        case 'Z':
        case 'a':
        case 'b':
        case 'c':
        case 'd':
        case 'e':
        case 'f':
        case 'g':
        case 'h':
        case 'i':
        case 'j':
        case 'k':
        case 'l':
        case 'm':
        case 'n':
        case 'o':
        case 'p':
        case 'q':
        case 'r':
        case 's':
        case 't':
        case 'u':
        case 'v':
        case 'w':
        case 'x':
        case 'y':
        case 'z':
        	{
            alt4 = 11;
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
                // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:1:10: PLUS
                {
                	mPLUS(); 

                }
                break;
            case 2 :
                // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:1:15: MINUS
                {
                	mMINUS(); 

                }
                break;
            case 3 :
                // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:1:21: MULT
                {
                	mMULT(); 

                }
                break;
            case 4 :
                // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:1:26: DIV
                {
                	mDIV(); 

                }
                break;
            case 5 :
                // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:1:30: ASSIGN
                {
                	mASSIGN(); 

                }
                break;
            case 6 :
                // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:1:37: LEFTPAREN
                {
                	mLEFTPAREN(); 

                }
                break;
            case 7 :
                // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:1:47: RIGHTPAREN
                {
                	mRIGHTPAREN(); 

                }
                break;
            case 8 :
                // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:1:58: SEMICOLON
                {
                	mSEMICOLON(); 

                }
                break;
            case 9 :
                // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:1:68: NUMBER
                {
                	mNUMBER(); 

                }
                break;
            case 10 :
                // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:1:75: WHITESPACE
                {
                	mWHITESPACE(); 

                }
                break;
            case 11 :
                // E:\\Projects\\my\\parser\\SimpleParser\\SimpleParser\\SimpleLanguage.g:1:86: IDENTIFIER
                {
                	mIDENTIFIER(); 

                }
                break;

        }

    }


	private void InitializeCyclicDFAs()
	{
	}

 
    
}
