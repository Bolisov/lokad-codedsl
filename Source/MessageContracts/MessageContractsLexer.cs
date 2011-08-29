// $ANTLR 3.3 Nov 30, 2010 12:45:30 C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g 2011-08-29 11:42:36

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162


using System;
using System.Collections.Generic;
using Antlr.Runtime;
using Stack = System.Collections.Generic.Stack<object>;
using List = System.Collections.IList;
using ArrayList = System.Collections.Generic.List<object>;

namespace  MessageContracts 
{
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "3.3 Nov 30, 2010 12:45:30")]
[System.CLSCompliant(false)]
public partial class MessageContractsLexer : Antlr.Runtime.Lexer
{
	public const int EOF=-1;
	public const int T__21=21;
	public const int T__22=22;
	public const int T__23=23;
	public const int T__24=24;
	public const int T__25=25;
	public const int TypeToken=4;
	public const int CommandToken=5;
	public const int EventToken=6;
	public const int MemberToken=7;
	public const int BlockToken=8;
	public const int DisctionaryToken=9;
	public const int FragmentGroup=10;
	public const int FragmentEntry=11;
	public const int FragmentReference=12;
	public const int ModifierDefinition=13;
	public const int LET=14;
	public const int ID=15;
	public const int USING=16;
	public const int Modifier=17;
	public const int INT=18;
	public const int COMMENT=19;
	public const int WS=20;

    // delegates
    // delegators

	public MessageContractsLexer()
	{
		OnCreated();
	}

	public MessageContractsLexer(ICharStream input )
		: this(input, new RecognizerSharedState())
	{
	}

	public MessageContractsLexer(ICharStream input, RecognizerSharedState state)
		: base(input, state)
	{


		OnCreated();
	}
	public override string GrammarFileName { get { return "C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g"; } }

	private static readonly bool[] decisionCanBacktrack = new bool[0];

 
	protected virtual void OnCreated() {}
	protected virtual void EnterRule(string ruleName, int ruleIndex) {}
	protected virtual void LeaveRule(string ruleName, int ruleIndex) {}

    protected virtual void Enter_T__21() {}
    protected virtual void Leave_T__21() {}

    // $ANTLR start "T__21"
    [GrammarRule("T__21")]
    private void mT__21()
    {

    		try
    		{
    		int _type = T__21;
    		int _channel = DefaultTokenChannel;
    		// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:9:7: ( '=' )
    		DebugEnterAlt(1);
    		// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:9:9: '='
    		{
    		DebugLocation(9, 9);
    		Match('='); 

    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "T__21"

    protected virtual void Enter_T__22() {}
    protected virtual void Leave_T__22() {}

    // $ANTLR start "T__22"
    [GrammarRule("T__22")]
    private void mT__22()
    {

    		try
    		{
    		int _type = T__22;
    		int _channel = DefaultTokenChannel;
    		// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:10:7: ( ';' )
    		DebugEnterAlt(1);
    		// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:10:9: ';'
    		{
    		DebugLocation(10, 9);
    		Match(';'); 

    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "T__22"

    protected virtual void Enter_T__23() {}
    protected virtual void Leave_T__23() {}

    // $ANTLR start "T__23"
    [GrammarRule("T__23")]
    private void mT__23()
    {

    		try
    		{
    		int _type = T__23;
    		int _channel = DefaultTokenChannel;
    		// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:11:7: ( '(' )
    		DebugEnterAlt(1);
    		// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:11:9: '('
    		{
    		DebugLocation(11, 9);
    		Match('('); 

    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "T__23"

    protected virtual void Enter_T__24() {}
    protected virtual void Leave_T__24() {}

    // $ANTLR start "T__24"
    [GrammarRule("T__24")]
    private void mT__24()
    {

    		try
    		{
    		int _type = T__24;
    		int _channel = DefaultTokenChannel;
    		// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:12:7: ( ',' )
    		DebugEnterAlt(1);
    		// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:12:9: ','
    		{
    		DebugLocation(12, 9);
    		Match(','); 

    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "T__24"

    protected virtual void Enter_T__25() {}
    protected virtual void Leave_T__25() {}

    // $ANTLR start "T__25"
    [GrammarRule("T__25")]
    private void mT__25()
    {

    		try
    		{
    		int _type = T__25;
    		int _channel = DefaultTokenChannel;
    		// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:13:7: ( ')' )
    		DebugEnterAlt(1);
    		// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:13:9: ')'
    		{
    		DebugLocation(13, 9);
    		Match(')'); 

    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "T__25"

    protected virtual void Enter_USING() {}
    protected virtual void Leave_USING() {}

    // $ANTLR start "USING"
    [GrammarRule("USING")]
    private void mUSING()
    {

    		try
    		{
    		int _type = USING;
    		int _channel = DefaultTokenChannel;
    		// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:63:2: ( 'using' )
    		DebugEnterAlt(1);
    		// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:63:4: 'using'
    		{
    		DebugLocation(63, 4);
    		Match("using"); 


    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "USING"

    protected virtual void Enter_LET() {}
    protected virtual void Leave_LET() {}

    // $ANTLR start "LET"
    [GrammarRule("LET")]
    private void mLET()
    {

    		try
    		{
    		int _type = LET;
    		int _channel = DefaultTokenChannel;
    		// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:65:2: ( 'let' )
    		DebugEnterAlt(1);
    		// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:65:4: 'let'
    		{
    		DebugLocation(65, 4);
    		Match("let"); 


    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "LET"

    protected virtual void Enter_ID() {}
    protected virtual void Leave_ID() {}

    // $ANTLR start "ID"
    [GrammarRule("ID")]
    private void mID()
    {

    		try
    		{
    		int _type = ID;
    		int _channel = DefaultTokenChannel;
    		// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:66:5: ( ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' | '<' | '>' | '[' | ']' )* )
    		DebugEnterAlt(1);
    		// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:66:7: ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' | '<' | '>' | '[' | ']' )*
    		{
    		DebugLocation(66, 7);
    		if ((input.LA(1)>='A' && input.LA(1)<='Z')||input.LA(1)=='_'||(input.LA(1)>='a' && input.LA(1)<='z'))
    		{
    			input.Consume();

    		}
    		else
    		{
    			MismatchedSetException mse = new MismatchedSetException(null,input);
    			DebugRecognitionException(mse);
    			Recover(mse);
    			throw mse;}

    		DebugLocation(66, 30);
    		// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:66:30: ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' | '<' | '>' | '[' | ']' )*
    		try { DebugEnterSubRule(1);
    		while (true)
    		{
    			int alt1=2;
    			try { DebugEnterDecision(1, decisionCanBacktrack[1]);
    			int LA1_0 = input.LA(1);

    			if (((LA1_0>='0' && LA1_0<='9')||LA1_0=='<'||LA1_0=='>'||(LA1_0>='A' && LA1_0<='[')||LA1_0==']'||LA1_0=='_'||(LA1_0>='a' && LA1_0<='z')))
    			{
    				alt1=1;
    			}


    			} finally { DebugExitDecision(1); }
    			switch ( alt1 )
    			{
    			case 1:
    				DebugEnterAlt(1);
    				// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:
    				{
    				DebugLocation(66, 30);
    				if ((input.LA(1)>='0' && input.LA(1)<='9')||input.LA(1)=='<'||input.LA(1)=='>'||(input.LA(1)>='A' && input.LA(1)<='[')||input.LA(1)==']'||input.LA(1)=='_'||(input.LA(1)>='a' && input.LA(1)<='z'))
    				{
    					input.Consume();

    				}
    				else
    				{
    					MismatchedSetException mse = new MismatchedSetException(null,input);
    					DebugRecognitionException(mse);
    					Recover(mse);
    					throw mse;}


    				}
    				break;

    			default:
    				goto loop1;
    			}
    		}

    		loop1:
    			;

    		} finally { DebugExitSubRule(1); }


    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "ID"

    protected virtual void Enter_Modifier() {}
    protected virtual void Leave_Modifier() {}

    // $ANTLR start "Modifier"
    [GrammarRule("Modifier")]
    private void mModifier()
    {

    		try
    		{
    		int _type = Modifier;
    		int _channel = DefaultTokenChannel;
    		// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:71:2: ( '?' | '!' | ';' )
    		DebugEnterAlt(1);
    		// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:
    		{
    		DebugLocation(71, 2);
    		if (input.LA(1)=='!'||input.LA(1)==';'||input.LA(1)=='?')
    		{
    			input.Consume();

    		}
    		else
    		{
    			MismatchedSetException mse = new MismatchedSetException(null,input);
    			DebugRecognitionException(mse);
    			Recover(mse);
    			throw mse;}


    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "Modifier"

    protected virtual void Enter_INT() {}
    protected virtual void Leave_INT() {}

    // $ANTLR start "INT"
    [GrammarRule("INT")]
    private void mINT()
    {

    		try
    		{
    		int _type = INT;
    		int _channel = DefaultTokenChannel;
    		// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:77:5: ( ( '0' .. '9' )+ )
    		DebugEnterAlt(1);
    		// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:77:7: ( '0' .. '9' )+
    		{
    		DebugLocation(77, 7);
    		// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:77:7: ( '0' .. '9' )+
    		int cnt2=0;
    		try { DebugEnterSubRule(2);
    		while (true)
    		{
    			int alt2=2;
    			try { DebugEnterDecision(2, decisionCanBacktrack[2]);
    			int LA2_0 = input.LA(1);

    			if (((LA2_0>='0' && LA2_0<='9')))
    			{
    				alt2=1;
    			}


    			} finally { DebugExitDecision(2); }
    			switch (alt2)
    			{
    			case 1:
    				DebugEnterAlt(1);
    				// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:77:7: '0' .. '9'
    				{
    				DebugLocation(77, 7);
    				MatchRange('0','9'); 

    				}
    				break;

    			default:
    				if (cnt2 >= 1)
    					goto loop2;

    				EarlyExitException eee2 = new EarlyExitException( 2, input );
    				DebugRecognitionException(eee2);
    				throw eee2;
    			}
    			cnt2++;
    		}
    		loop2:
    			;

    		} finally { DebugExitSubRule(2); }


    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "INT"

    protected virtual void Enter_COMMENT() {}
    protected virtual void Leave_COMMENT() {}

    // $ANTLR start "COMMENT"
    [GrammarRule("COMMENT")]
    private void mCOMMENT()
    {

    		try
    		{
    		int _type = COMMENT;
    		int _channel = DefaultTokenChannel;
    		// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:81:5: ( '//' (~ ( '\\n' | '\\r' ) )* ( '\\r' )? '\\n' | '/*' ( options {greedy=false; } : . )* '*/' )
    		int alt6=2;
    		try { DebugEnterDecision(6, decisionCanBacktrack[6]);
    		int LA6_0 = input.LA(1);

    		if ((LA6_0=='/'))
    		{
    			int LA6_1 = input.LA(2);

    			if ((LA6_1=='/'))
    			{
    				alt6=1;
    			}
    			else if ((LA6_1=='*'))
    			{
    				alt6=2;
    			}
    			else
    			{
    				NoViableAltException nvae = new NoViableAltException("", 6, 1, input);

    				DebugRecognitionException(nvae);
    				throw nvae;
    			}
    		}
    		else
    		{
    			NoViableAltException nvae = new NoViableAltException("", 6, 0, input);

    			DebugRecognitionException(nvae);
    			throw nvae;
    		}
    		} finally { DebugExitDecision(6); }
    		switch (alt6)
    		{
    		case 1:
    			DebugEnterAlt(1);
    			// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:81:9: '//' (~ ( '\\n' | '\\r' ) )* ( '\\r' )? '\\n'
    			{
    			DebugLocation(81, 9);
    			Match("//"); 

    			DebugLocation(81, 14);
    			// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:81:14: (~ ( '\\n' | '\\r' ) )*
    			try { DebugEnterSubRule(3);
    			while (true)
    			{
    				int alt3=2;
    				try { DebugEnterDecision(3, decisionCanBacktrack[3]);
    				int LA3_0 = input.LA(1);

    				if (((LA3_0>='\u0000' && LA3_0<='\t')||(LA3_0>='\u000B' && LA3_0<='\f')||(LA3_0>='\u000E' && LA3_0<='\uFFFF')))
    				{
    					alt3=1;
    				}


    				} finally { DebugExitDecision(3); }
    				switch ( alt3 )
    				{
    				case 1:
    					DebugEnterAlt(1);
    					// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:81:14: ~ ( '\\n' | '\\r' )
    					{
    					DebugLocation(81, 14);
    					if ((input.LA(1)>='\u0000' && input.LA(1)<='\t')||(input.LA(1)>='\u000B' && input.LA(1)<='\f')||(input.LA(1)>='\u000E' && input.LA(1)<='\uFFFF'))
    					{
    						input.Consume();

    					}
    					else
    					{
    						MismatchedSetException mse = new MismatchedSetException(null,input);
    						DebugRecognitionException(mse);
    						Recover(mse);
    						throw mse;}


    					}
    					break;

    				default:
    					goto loop3;
    				}
    			}

    			loop3:
    				;

    			} finally { DebugExitSubRule(3); }

    			DebugLocation(81, 28);
    			// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:81:28: ( '\\r' )?
    			int alt4=2;
    			try { DebugEnterSubRule(4);
    			try { DebugEnterDecision(4, decisionCanBacktrack[4]);
    			int LA4_0 = input.LA(1);

    			if ((LA4_0=='\r'))
    			{
    				alt4=1;
    			}
    			} finally { DebugExitDecision(4); }
    			switch (alt4)
    			{
    			case 1:
    				DebugEnterAlt(1);
    				// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:81:28: '\\r'
    				{
    				DebugLocation(81, 28);
    				Match('\r'); 

    				}
    				break;

    			}
    			} finally { DebugExitSubRule(4); }

    			DebugLocation(81, 34);
    			Match('\n'); 
    			DebugLocation(81, 39);
    			_channel=HIDDEN;

    			}
    			break;
    		case 2:
    			DebugEnterAlt(2);
    			// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:82:9: '/*' ( options {greedy=false; } : . )* '*/'
    			{
    			DebugLocation(82, 9);
    			Match("/*"); 

    			DebugLocation(82, 14);
    			// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:82:14: ( options {greedy=false; } : . )*
    			try { DebugEnterSubRule(5);
    			while (true)
    			{
    				int alt5=2;
    				try { DebugEnterDecision(5, decisionCanBacktrack[5]);
    				int LA5_0 = input.LA(1);

    				if ((LA5_0=='*'))
    				{
    					int LA5_1 = input.LA(2);

    					if ((LA5_1=='/'))
    					{
    						alt5=2;
    					}
    					else if (((LA5_1>='\u0000' && LA5_1<='.')||(LA5_1>='0' && LA5_1<='\uFFFF')))
    					{
    						alt5=1;
    					}


    				}
    				else if (((LA5_0>='\u0000' && LA5_0<=')')||(LA5_0>='+' && LA5_0<='\uFFFF')))
    				{
    					alt5=1;
    				}


    				} finally { DebugExitDecision(5); }
    				switch ( alt5 )
    				{
    				case 1:
    					DebugEnterAlt(1);
    					// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:82:42: .
    					{
    					DebugLocation(82, 42);
    					MatchAny(); 

    					}
    					break;

    				default:
    					goto loop5;
    				}
    			}

    			loop5:
    				;

    			} finally { DebugExitSubRule(5); }

    			DebugLocation(82, 47);
    			Match("*/"); 

    			DebugLocation(82, 52);
    			_channel=HIDDEN;

    			}
    			break;

    		}
    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "COMMENT"

    protected virtual void Enter_WS() {}
    protected virtual void Leave_WS() {}

    // $ANTLR start "WS"
    [GrammarRule("WS")]
    private void mWS()
    {

    		try
    		{
    		int _type = WS;
    		int _channel = DefaultTokenChannel;
    		// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:85:5: ( ( ' ' | '\\t' | '\\r' | '\\n' ) )
    		DebugEnterAlt(1);
    		// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:85:9: ( ' ' | '\\t' | '\\r' | '\\n' )
    		{
    		DebugLocation(85, 9);
    		if ((input.LA(1)>='\t' && input.LA(1)<='\n')||input.LA(1)=='\r'||input.LA(1)==' ')
    		{
    			input.Consume();

    		}
    		else
    		{
    			MismatchedSetException mse = new MismatchedSetException(null,input);
    			DebugRecognitionException(mse);
    			Recover(mse);
    			throw mse;}

    		DebugLocation(89, 11);
    		_channel=HIDDEN;

    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "WS"

    public override void mTokens()
    {
    	// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:1:8: ( T__21 | T__22 | T__23 | T__24 | T__25 | USING | LET | ID | Modifier | INT | COMMENT | WS )
    	int alt7=12;
    	try { DebugEnterDecision(7, decisionCanBacktrack[7]);
    	try
    	{
    		alt7 = dfa7.Predict(input);
    	}
    	catch (NoViableAltException nvae)
    	{
    		DebugRecognitionException(nvae);
    		throw;
    	}
    	} finally { DebugExitDecision(7); }
    	switch (alt7)
    	{
    	case 1:
    		DebugEnterAlt(1);
    		// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:1:10: T__21
    		{
    		DebugLocation(1, 10);
    		mT__21(); 

    		}
    		break;
    	case 2:
    		DebugEnterAlt(2);
    		// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:1:16: T__22
    		{
    		DebugLocation(1, 16);
    		mT__22(); 

    		}
    		break;
    	case 3:
    		DebugEnterAlt(3);
    		// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:1:22: T__23
    		{
    		DebugLocation(1, 22);
    		mT__23(); 

    		}
    		break;
    	case 4:
    		DebugEnterAlt(4);
    		// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:1:28: T__24
    		{
    		DebugLocation(1, 28);
    		mT__24(); 

    		}
    		break;
    	case 5:
    		DebugEnterAlt(5);
    		// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:1:34: T__25
    		{
    		DebugLocation(1, 34);
    		mT__25(); 

    		}
    		break;
    	case 6:
    		DebugEnterAlt(6);
    		// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:1:40: USING
    		{
    		DebugLocation(1, 40);
    		mUSING(); 

    		}
    		break;
    	case 7:
    		DebugEnterAlt(7);
    		// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:1:46: LET
    		{
    		DebugLocation(1, 46);
    		mLET(); 

    		}
    		break;
    	case 8:
    		DebugEnterAlt(8);
    		// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:1:50: ID
    		{
    		DebugLocation(1, 50);
    		mID(); 

    		}
    		break;
    	case 9:
    		DebugEnterAlt(9);
    		// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:1:53: Modifier
    		{
    		DebugLocation(1, 53);
    		mModifier(); 

    		}
    		break;
    	case 10:
    		DebugEnterAlt(10);
    		// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:1:62: INT
    		{
    		DebugLocation(1, 62);
    		mINT(); 

    		}
    		break;
    	case 11:
    		DebugEnterAlt(11);
    		// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:1:66: COMMENT
    		{
    		DebugLocation(1, 66);
    		mCOMMENT(); 

    		}
    		break;
    	case 12:
    		DebugEnterAlt(12);
    		// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:1:74: WS
    		{
    		DebugLocation(1, 74);
    		mWS(); 

    		}
    		break;

    	}

    }


	#region DFA
	DFA7 dfa7;

	protected override void InitDFAs()
	{
		base.InitDFAs();
		dfa7 = new DFA7(this);
	}

	private class DFA7 : DFA
	{
		private const string DFA7_eotS =
			"\x06\uffff\x02\x08\x06\uffff\x03\x08\x01\x13\x01\x08\x01\uffff\x01\x15"+
			"\x01\uffff";
		private const string DFA7_eofS =
			"\x16\uffff";
		private const string DFA7_minS =
			"\x01\x09\x05\uffff\x01\x73\x01\x65\x06\uffff\x01\x69\x01\x74\x01\x6e"+
			"\x01\x30\x01\x67\x01\uffff\x01\x30\x01\uffff";
		private const string DFA7_maxS =
			"\x01\x7a\x05\uffff\x01\x73\x01\x65\x06\uffff\x01\x69\x01\x74\x01\x6e"+
			"\x01\x7a\x01\x67\x01\uffff\x01\x7a\x01\uffff";
		private const string DFA7_acceptS =
			"\x01\uffff\x01\x01\x01\x02\x01\x03\x01\x04\x01\x05\x02\uffff\x01\x08"+
			"\x01\x09\x01\x0a\x01\x0b\x01\x0c\x01\x02\x05\uffff\x01\x07\x01\uffff"+
			"\x01\x06";
		private const string DFA7_specialS =
			"\x16\uffff}>";
		private static readonly string[] DFA7_transitionS =
			{
				"\x02\x0c\x02\uffff\x01\x0c\x12\uffff\x01\x0c\x01\x09\x06\uffff\x01"+
				"\x03\x01\x05\x02\uffff\x01\x04\x02\uffff\x01\x0b\x0a\x0a\x01\uffff\x01"+
				"\x02\x01\uffff\x01\x01\x01\uffff\x01\x09\x01\uffff\x1a\x08\x04\uffff"+
				"\x01\x08\x01\uffff\x0b\x08\x01\x07\x08\x08\x01\x06\x05\x08",
				"",
				"",
				"",
				"",
				"",
				"\x01\x0e",
				"\x01\x0f",
				"",
				"",
				"",
				"",
				"",
				"",
				"\x01\x10",
				"\x01\x11",
				"\x01\x12",
				"\x0a\x08\x02\uffff\x01\x08\x01\uffff\x01\x08\x02\uffff\x1b\x08\x01"+
				"\uffff\x01\x08\x01\uffff\x01\x08\x01\uffff\x1a\x08",
				"\x01\x14",
				"",
				"\x0a\x08\x02\uffff\x01\x08\x01\uffff\x01\x08\x02\uffff\x1b\x08\x01"+
				"\uffff\x01\x08\x01\uffff\x01\x08\x01\uffff\x1a\x08",
				""
			};

		private static readonly short[] DFA7_eot = DFA.UnpackEncodedString(DFA7_eotS);
		private static readonly short[] DFA7_eof = DFA.UnpackEncodedString(DFA7_eofS);
		private static readonly char[] DFA7_min = DFA.UnpackEncodedStringToUnsignedChars(DFA7_minS);
		private static readonly char[] DFA7_max = DFA.UnpackEncodedStringToUnsignedChars(DFA7_maxS);
		private static readonly short[] DFA7_accept = DFA.UnpackEncodedString(DFA7_acceptS);
		private static readonly short[] DFA7_special = DFA.UnpackEncodedString(DFA7_specialS);
		private static readonly short[][] DFA7_transition;

		static DFA7()
		{
			int numStates = DFA7_transitionS.Length;
			DFA7_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA7_transition[i] = DFA.UnpackEncodedString(DFA7_transitionS[i]);
			}
		}

		public DFA7( BaseRecognizer recognizer )
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

		public override string Description { get { return "1:1: Tokens : ( T__21 | T__22 | T__23 | T__24 | T__25 | USING | LET | ID | Modifier | INT | COMMENT | WS );"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

 
	#endregion

}
}