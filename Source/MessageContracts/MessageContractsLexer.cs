// $ANTLR 3.3 Nov 30, 2010 12:45:30 C:\\Projects\\lokad-message-contracts-dsl-sample\\Source\\MessageContracts\\MessageContracts.g 2011-07-05 15:14:17

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
	public const int T__20=20;
	public const int T__21=21;
	public const int T__22=22;
	public const int T__23=23;
	public const int T__24=24;
	public const int T__25=25;
	public const int T__26=26;
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
	public const int ID=14;
	public const int TYPE=15;
	public const int Modifier=16;
	public const int INT=17;
	public const int COMMENT=18;
	public const int WS=19;

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
	public override string GrammarFileName { get { return "C:\\Projects\\lokad-message-contracts-dsl-sample\\Source\\MessageContracts\\MessageContracts.g"; } }

	private static readonly bool[] decisionCanBacktrack = new bool[0];

 
	protected virtual void OnCreated() {}
	protected virtual void EnterRule(string ruleName, int ruleIndex) {}
	protected virtual void LeaveRule(string ruleName, int ruleIndex) {}

    protected virtual void Enter_T__20() {}
    protected virtual void Leave_T__20() {}

    // $ANTLR start "T__20"
    [GrammarRule("T__20")]
    private void mT__20()
    {

    		try
    		{
    		int _type = T__20;
    		int _channel = DefaultTokenChannel;
    		// C:\\Projects\\lokad-message-contracts-dsl-sample\\Source\\MessageContracts\\MessageContracts.g:9:7: ( 'let' )
    		DebugEnterAlt(1);
    		// C:\\Projects\\lokad-message-contracts-dsl-sample\\Source\\MessageContracts\\MessageContracts.g:9:9: 'let'
    		{
    		DebugLocation(9, 9);
    		Match("let"); 


    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "T__20"

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
    		// C:\\Projects\\lokad-message-contracts-dsl-sample\\Source\\MessageContracts\\MessageContracts.g:10:7: ( '=' )
    		DebugEnterAlt(1);
    		// C:\\Projects\\lokad-message-contracts-dsl-sample\\Source\\MessageContracts\\MessageContracts.g:10:9: '='
    		{
    		DebugLocation(10, 9);
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
    		// C:\\Projects\\lokad-message-contracts-dsl-sample\\Source\\MessageContracts\\MessageContracts.g:11:7: ( ';' )
    		DebugEnterAlt(1);
    		// C:\\Projects\\lokad-message-contracts-dsl-sample\\Source\\MessageContracts\\MessageContracts.g:11:9: ';'
    		{
    		DebugLocation(11, 9);
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
    		// C:\\Projects\\lokad-message-contracts-dsl-sample\\Source\\MessageContracts\\MessageContracts.g:12:7: ( 'using' )
    		DebugEnterAlt(1);
    		// C:\\Projects\\lokad-message-contracts-dsl-sample\\Source\\MessageContracts\\MessageContracts.g:12:9: 'using'
    		{
    		DebugLocation(12, 9);
    		Match("using"); 


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
    		// C:\\Projects\\lokad-message-contracts-dsl-sample\\Source\\MessageContracts\\MessageContracts.g:13:7: ( '(' )
    		DebugEnterAlt(1);
    		// C:\\Projects\\lokad-message-contracts-dsl-sample\\Source\\MessageContracts\\MessageContracts.g:13:9: '('
    		{
    		DebugLocation(13, 9);
    		Match('('); 

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
    		// C:\\Projects\\lokad-message-contracts-dsl-sample\\Source\\MessageContracts\\MessageContracts.g:14:7: ( ',' )
    		DebugEnterAlt(1);
    		// C:\\Projects\\lokad-message-contracts-dsl-sample\\Source\\MessageContracts\\MessageContracts.g:14:9: ','
    		{
    		DebugLocation(14, 9);
    		Match(','); 

    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "T__25"

    protected virtual void Enter_T__26() {}
    protected virtual void Leave_T__26() {}

    // $ANTLR start "T__26"
    [GrammarRule("T__26")]
    private void mT__26()
    {

    		try
    		{
    		int _type = T__26;
    		int _channel = DefaultTokenChannel;
    		// C:\\Projects\\lokad-message-contracts-dsl-sample\\Source\\MessageContracts\\MessageContracts.g:15:7: ( ')' )
    		DebugEnterAlt(1);
    		// C:\\Projects\\lokad-message-contracts-dsl-sample\\Source\\MessageContracts\\MessageContracts.g:15:9: ')'
    		{
    		DebugLocation(15, 9);
    		Match(')'); 

    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "T__26"

    protected virtual void Enter_TYPE() {}
    protected virtual void Leave_TYPE() {}

    // $ANTLR start "TYPE"
    [GrammarRule("TYPE")]
    private void mTYPE()
    {

    		try
    		{
    		int _type = TYPE;
    		int _channel = DefaultTokenChannel;
    		// C:\\Projects\\lokad-message-contracts-dsl-sample\\Source\\MessageContracts\\MessageContracts.g:63:8: ( ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '<' | '>' | '[' | ']' )* )
    		DebugEnterAlt(1);
    		// C:\\Projects\\lokad-message-contracts-dsl-sample\\Source\\MessageContracts\\MessageContracts.g:63:10: ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '<' | '>' | '[' | ']' )*
    		{
    		DebugLocation(63, 10);
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

    		DebugLocation(63, 33);
    		// C:\\Projects\\lokad-message-contracts-dsl-sample\\Source\\MessageContracts\\MessageContracts.g:63:33: ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '<' | '>' | '[' | ']' )*
    		try { DebugEnterSubRule(1);
    		while (true)
    		{
    			int alt1=2;
    			try { DebugEnterDecision(1, decisionCanBacktrack[1]);
    			int LA1_0 = input.LA(1);

    			if (((LA1_0>='0' && LA1_0<='9')||LA1_0=='<'||LA1_0=='>'||(LA1_0>='A' && LA1_0<='[')||LA1_0==']'||(LA1_0>='a' && LA1_0<='z')))
    			{
    				alt1=1;
    			}


    			} finally { DebugExitDecision(1); }
    			switch ( alt1 )
    			{
    			case 1:
    				DebugEnterAlt(1);
    				// C:\\Projects\\lokad-message-contracts-dsl-sample\\Source\\MessageContracts\\MessageContracts.g:
    				{
    				DebugLocation(63, 33);
    				if ((input.LA(1)>='0' && input.LA(1)<='9')||input.LA(1)=='<'||input.LA(1)=='>'||(input.LA(1)>='A' && input.LA(1)<='[')||input.LA(1)==']'||(input.LA(1)>='a' && input.LA(1)<='z'))
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
    // $ANTLR end "TYPE"

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
    		// C:\\Projects\\lokad-message-contracts-dsl-sample\\Source\\MessageContracts\\MessageContracts.g:69:2: ( '?' | '!' | ';' )
    		DebugEnterAlt(1);
    		// C:\\Projects\\lokad-message-contracts-dsl-sample\\Source\\MessageContracts\\MessageContracts.g:
    		{
    		DebugLocation(69, 2);
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
    		// C:\\Projects\\lokad-message-contracts-dsl-sample\\Source\\MessageContracts\\MessageContracts.g:75:5: ( ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' )* )
    		DebugEnterAlt(1);
    		// C:\\Projects\\lokad-message-contracts-dsl-sample\\Source\\MessageContracts\\MessageContracts.g:75:7: ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' )*
    		{
    		DebugLocation(75, 7);
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

    		DebugLocation(75, 30);
    		// C:\\Projects\\lokad-message-contracts-dsl-sample\\Source\\MessageContracts\\MessageContracts.g:75:30: ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' )*
    		try { DebugEnterSubRule(2);
    		while (true)
    		{
    			int alt2=2;
    			try { DebugEnterDecision(2, decisionCanBacktrack[2]);
    			int LA2_0 = input.LA(1);

    			if (((LA2_0>='0' && LA2_0<='9')||(LA2_0>='A' && LA2_0<='Z')||LA2_0=='_'||(LA2_0>='a' && LA2_0<='z')))
    			{
    				alt2=1;
    			}


    			} finally { DebugExitDecision(2); }
    			switch ( alt2 )
    			{
    			case 1:
    				DebugEnterAlt(1);
    				// C:\\Projects\\lokad-message-contracts-dsl-sample\\Source\\MessageContracts\\MessageContracts.g:
    				{
    				DebugLocation(75, 30);
    				if ((input.LA(1)>='0' && input.LA(1)<='9')||(input.LA(1)>='A' && input.LA(1)<='Z')||input.LA(1)=='_'||(input.LA(1)>='a' && input.LA(1)<='z'))
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
    				goto loop2;
    			}
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
    // $ANTLR end "ID"

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
    		// C:\\Projects\\lokad-message-contracts-dsl-sample\\Source\\MessageContracts\\MessageContracts.g:77:5: ( ( '0' .. '9' )+ )
    		DebugEnterAlt(1);
    		// C:\\Projects\\lokad-message-contracts-dsl-sample\\Source\\MessageContracts\\MessageContracts.g:77:7: ( '0' .. '9' )+
    		{
    		DebugLocation(77, 7);
    		// C:\\Projects\\lokad-message-contracts-dsl-sample\\Source\\MessageContracts\\MessageContracts.g:77:7: ( '0' .. '9' )+
    		int cnt3=0;
    		try { DebugEnterSubRule(3);
    		while (true)
    		{
    			int alt3=2;
    			try { DebugEnterDecision(3, decisionCanBacktrack[3]);
    			int LA3_0 = input.LA(1);

    			if (((LA3_0>='0' && LA3_0<='9')))
    			{
    				alt3=1;
    			}


    			} finally { DebugExitDecision(3); }
    			switch (alt3)
    			{
    			case 1:
    				DebugEnterAlt(1);
    				// C:\\Projects\\lokad-message-contracts-dsl-sample\\Source\\MessageContracts\\MessageContracts.g:77:7: '0' .. '9'
    				{
    				DebugLocation(77, 7);
    				MatchRange('0','9'); 

    				}
    				break;

    			default:
    				if (cnt3 >= 1)
    					goto loop3;

    				EarlyExitException eee3 = new EarlyExitException( 3, input );
    				DebugRecognitionException(eee3);
    				throw eee3;
    			}
    			cnt3++;
    		}
    		loop3:
    			;

    		} finally { DebugExitSubRule(3); }


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
    		// C:\\Projects\\lokad-message-contracts-dsl-sample\\Source\\MessageContracts\\MessageContracts.g:81:5: ( '//' (~ ( '\\n' | '\\r' ) )* ( '\\r' )? '\\n' | '/*' ( options {greedy=false; } : . )* '*/' )
    		int alt7=2;
    		try { DebugEnterDecision(7, decisionCanBacktrack[7]);
    		int LA7_0 = input.LA(1);

    		if ((LA7_0=='/'))
    		{
    			int LA7_1 = input.LA(2);

    			if ((LA7_1=='/'))
    			{
    				alt7=1;
    			}
    			else if ((LA7_1=='*'))
    			{
    				alt7=2;
    			}
    			else
    			{
    				NoViableAltException nvae = new NoViableAltException("", 7, 1, input);

    				DebugRecognitionException(nvae);
    				throw nvae;
    			}
    		}
    		else
    		{
    			NoViableAltException nvae = new NoViableAltException("", 7, 0, input);

    			DebugRecognitionException(nvae);
    			throw nvae;
    		}
    		} finally { DebugExitDecision(7); }
    		switch (alt7)
    		{
    		case 1:
    			DebugEnterAlt(1);
    			// C:\\Projects\\lokad-message-contracts-dsl-sample\\Source\\MessageContracts\\MessageContracts.g:81:9: '//' (~ ( '\\n' | '\\r' ) )* ( '\\r' )? '\\n'
    			{
    			DebugLocation(81, 9);
    			Match("//"); 

    			DebugLocation(81, 14);
    			// C:\\Projects\\lokad-message-contracts-dsl-sample\\Source\\MessageContracts\\MessageContracts.g:81:14: (~ ( '\\n' | '\\r' ) )*
    			try { DebugEnterSubRule(4);
    			while (true)
    			{
    				int alt4=2;
    				try { DebugEnterDecision(4, decisionCanBacktrack[4]);
    				int LA4_0 = input.LA(1);

    				if (((LA4_0>='\u0000' && LA4_0<='\t')||(LA4_0>='\u000B' && LA4_0<='\f')||(LA4_0>='\u000E' && LA4_0<='\uFFFF')))
    				{
    					alt4=1;
    				}


    				} finally { DebugExitDecision(4); }
    				switch ( alt4 )
    				{
    				case 1:
    					DebugEnterAlt(1);
    					// C:\\Projects\\lokad-message-contracts-dsl-sample\\Source\\MessageContracts\\MessageContracts.g:81:14: ~ ( '\\n' | '\\r' )
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
    					goto loop4;
    				}
    			}

    			loop4:
    				;

    			} finally { DebugExitSubRule(4); }

    			DebugLocation(81, 28);
    			// C:\\Projects\\lokad-message-contracts-dsl-sample\\Source\\MessageContracts\\MessageContracts.g:81:28: ( '\\r' )?
    			int alt5=2;
    			try { DebugEnterSubRule(5);
    			try { DebugEnterDecision(5, decisionCanBacktrack[5]);
    			int LA5_0 = input.LA(1);

    			if ((LA5_0=='\r'))
    			{
    				alt5=1;
    			}
    			} finally { DebugExitDecision(5); }
    			switch (alt5)
    			{
    			case 1:
    				DebugEnterAlt(1);
    				// C:\\Projects\\lokad-message-contracts-dsl-sample\\Source\\MessageContracts\\MessageContracts.g:81:28: '\\r'
    				{
    				DebugLocation(81, 28);
    				Match('\r'); 

    				}
    				break;

    			}
    			} finally { DebugExitSubRule(5); }

    			DebugLocation(81, 34);
    			Match('\n'); 
    			DebugLocation(81, 39);
    			_channel=Hidden;

    			}
    			break;
    		case 2:
    			DebugEnterAlt(2);
    			// C:\\Projects\\lokad-message-contracts-dsl-sample\\Source\\MessageContracts\\MessageContracts.g:82:9: '/*' ( options {greedy=false; } : . )* '*/'
    			{
    			DebugLocation(82, 9);
    			Match("/*"); 

    			DebugLocation(82, 14);
    			// C:\\Projects\\lokad-message-contracts-dsl-sample\\Source\\MessageContracts\\MessageContracts.g:82:14: ( options {greedy=false; } : . )*
    			try { DebugEnterSubRule(6);
    			while (true)
    			{
    				int alt6=2;
    				try { DebugEnterDecision(6, decisionCanBacktrack[6]);
    				int LA6_0 = input.LA(1);

    				if ((LA6_0=='*'))
    				{
    					int LA6_1 = input.LA(2);

    					if ((LA6_1=='/'))
    					{
    						alt6=2;
    					}
    					else if (((LA6_1>='\u0000' && LA6_1<='.')||(LA6_1>='0' && LA6_1<='\uFFFF')))
    					{
    						alt6=1;
    					}


    				}
    				else if (((LA6_0>='\u0000' && LA6_0<=')')||(LA6_0>='+' && LA6_0<='\uFFFF')))
    				{
    					alt6=1;
    				}


    				} finally { DebugExitDecision(6); }
    				switch ( alt6 )
    				{
    				case 1:
    					DebugEnterAlt(1);
    					// C:\\Projects\\lokad-message-contracts-dsl-sample\\Source\\MessageContracts\\MessageContracts.g:82:42: .
    					{
    					DebugLocation(82, 42);
    					MatchAny(); 

    					}
    					break;

    				default:
    					goto loop6;
    				}
    			}

    			loop6:
    				;

    			} finally { DebugExitSubRule(6); }

    			DebugLocation(82, 47);
    			Match("*/"); 

    			DebugLocation(82, 52);
    			_channel=Hidden;

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
    		// C:\\Projects\\lokad-message-contracts-dsl-sample\\Source\\MessageContracts\\MessageContracts.g:85:5: ( ( ' ' | '\\t' | '\\r' | '\\n' ) )
    		DebugEnterAlt(1);
    		// C:\\Projects\\lokad-message-contracts-dsl-sample\\Source\\MessageContracts\\MessageContracts.g:85:9: ( ' ' | '\\t' | '\\r' | '\\n' )
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
    		_channel=Hidden;

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
    	// C:\\Projects\\lokad-message-contracts-dsl-sample\\Source\\MessageContracts\\MessageContracts.g:1:8: ( T__20 | T__21 | T__22 | T__23 | T__24 | T__25 | T__26 | TYPE | Modifier | ID | INT | COMMENT | WS )
    	int alt8=13;
    	try { DebugEnterDecision(8, decisionCanBacktrack[8]);
    	try
    	{
    		alt8 = dfa8.Predict(input);
    	}
    	catch (NoViableAltException nvae)
    	{
    		DebugRecognitionException(nvae);
    		throw;
    	}
    	} finally { DebugExitDecision(8); }
    	switch (alt8)
    	{
    	case 1:
    		DebugEnterAlt(1);
    		// C:\\Projects\\lokad-message-contracts-dsl-sample\\Source\\MessageContracts\\MessageContracts.g:1:10: T__20
    		{
    		DebugLocation(1, 10);
    		mT__20(); 

    		}
    		break;
    	case 2:
    		DebugEnterAlt(2);
    		// C:\\Projects\\lokad-message-contracts-dsl-sample\\Source\\MessageContracts\\MessageContracts.g:1:16: T__21
    		{
    		DebugLocation(1, 16);
    		mT__21(); 

    		}
    		break;
    	case 3:
    		DebugEnterAlt(3);
    		// C:\\Projects\\lokad-message-contracts-dsl-sample\\Source\\MessageContracts\\MessageContracts.g:1:22: T__22
    		{
    		DebugLocation(1, 22);
    		mT__22(); 

    		}
    		break;
    	case 4:
    		DebugEnterAlt(4);
    		// C:\\Projects\\lokad-message-contracts-dsl-sample\\Source\\MessageContracts\\MessageContracts.g:1:28: T__23
    		{
    		DebugLocation(1, 28);
    		mT__23(); 

    		}
    		break;
    	case 5:
    		DebugEnterAlt(5);
    		// C:\\Projects\\lokad-message-contracts-dsl-sample\\Source\\MessageContracts\\MessageContracts.g:1:34: T__24
    		{
    		DebugLocation(1, 34);
    		mT__24(); 

    		}
    		break;
    	case 6:
    		DebugEnterAlt(6);
    		// C:\\Projects\\lokad-message-contracts-dsl-sample\\Source\\MessageContracts\\MessageContracts.g:1:40: T__25
    		{
    		DebugLocation(1, 40);
    		mT__25(); 

    		}
    		break;
    	case 7:
    		DebugEnterAlt(7);
    		// C:\\Projects\\lokad-message-contracts-dsl-sample\\Source\\MessageContracts\\MessageContracts.g:1:46: T__26
    		{
    		DebugLocation(1, 46);
    		mT__26(); 

    		}
    		break;
    	case 8:
    		DebugEnterAlt(8);
    		// C:\\Projects\\lokad-message-contracts-dsl-sample\\Source\\MessageContracts\\MessageContracts.g:1:52: TYPE
    		{
    		DebugLocation(1, 52);
    		mTYPE(); 

    		}
    		break;
    	case 9:
    		DebugEnterAlt(9);
    		// C:\\Projects\\lokad-message-contracts-dsl-sample\\Source\\MessageContracts\\MessageContracts.g:1:57: Modifier
    		{
    		DebugLocation(1, 57);
    		mModifier(); 

    		}
    		break;
    	case 10:
    		DebugEnterAlt(10);
    		// C:\\Projects\\lokad-message-contracts-dsl-sample\\Source\\MessageContracts\\MessageContracts.g:1:66: ID
    		{
    		DebugLocation(1, 66);
    		mID(); 

    		}
    		break;
    	case 11:
    		DebugEnterAlt(11);
    		// C:\\Projects\\lokad-message-contracts-dsl-sample\\Source\\MessageContracts\\MessageContracts.g:1:69: INT
    		{
    		DebugLocation(1, 69);
    		mINT(); 

    		}
    		break;
    	case 12:
    		DebugEnterAlt(12);
    		// C:\\Projects\\lokad-message-contracts-dsl-sample\\Source\\MessageContracts\\MessageContracts.g:1:73: COMMENT
    		{
    		DebugLocation(1, 73);
    		mCOMMENT(); 

    		}
    		break;
    	case 13:
    		DebugEnterAlt(13);
    		// C:\\Projects\\lokad-message-contracts-dsl-sample\\Source\\MessageContracts\\MessageContracts.g:1:81: WS
    		{
    		DebugLocation(1, 81);
    		mWS(); 

    		}
    		break;

    	}

    }


	#region DFA
	DFA8 dfa8;

	protected override void InitDFAs()
	{
		base.InitDFAs();
		dfa8 = new DFA8(this);
	}

	private class DFA8 : DFA
	{
		private const string DFA8_eotS =
			"\x01\uffff\x01\x0f\x02\uffff\x01\x0f\x03\uffff\x01\x0f\x04\uffff\x02"+
			"\x0f\x03\uffff\x01\x0f\x01\x15\x01\x0f\x01\uffff\x01\x0f\x01\x18\x01"+
			"\uffff";
		private const string DFA8_eofS =
			"\x19\uffff";
		private const string DFA8_minS =
			"\x01\x09\x01\x30\x02\uffff\x01\x30\x03\uffff\x01\x30\x04\uffff\x02\x30"+
			"\x03\uffff\x03\x30\x01\uffff\x02\x30\x01\uffff";
		private const string DFA8_maxS =
			"\x02\x7a\x02\uffff\x01\x7a\x03\uffff\x01\x7a\x04\uffff\x02\x7a\x03\uffff"+
			"\x03\x7a\x01\uffff\x02\x7a\x01\uffff";
		private const string DFA8_acceptS =
			"\x02\uffff\x01\x02\x01\x03\x01\uffff\x01\x05\x01\x06\x01\x07\x01\uffff"+
			"\x01\x09\x01\x0b\x01\x0c\x01\x0d\x02\uffff\x01\x08\x01\x0a\x01\x03\x03"+
			"\uffff\x01\x01\x02\uffff\x01\x04";
		private const string DFA8_specialS =
			"\x19\uffff}>";
		private static readonly string[] DFA8_transitionS =
			{
				"\x02\x0c\x02\uffff\x01\x0c\x12\uffff\x01\x0c\x01\x09\x06\uffff\x01"+
				"\x05\x01\x07\x02\uffff\x01\x06\x02\uffff\x01\x0b\x0a\x0a\x01\uffff\x01"+
				"\x03\x01\uffff\x01\x02\x01\uffff\x01\x09\x01\uffff\x1a\x08\x04\uffff"+
				"\x01\x08\x01\uffff\x0b\x08\x01\x01\x08\x08\x01\x04\x05\x08",
				"\x0a\x0e\x07\uffff\x1a\x0e\x04\uffff\x01\x10\x01\uffff\x04\x0e\x01"+
				"\x0d\x15\x0e",
				"",
				"",
				"\x0a\x0e\x07\uffff\x1a\x0e\x04\uffff\x01\x10\x01\uffff\x12\x0e\x01"+
				"\x12\x07\x0e",
				"",
				"",
				"",
				"\x0a\x0e\x07\uffff\x1a\x0e\x04\uffff\x01\x10\x01\uffff\x1a\x0e",
				"",
				"",
				"",
				"",
				"\x0a\x0e\x07\uffff\x1a\x0e\x04\uffff\x01\x10\x01\uffff\x13\x0e\x01"+
				"\x13\x06\x0e",
				"\x0a\x0e\x07\uffff\x1a\x0e\x04\uffff\x01\x10\x01\uffff\x1a\x0e",
				"",
				"",
				"",
				"\x0a\x0e\x07\uffff\x1a\x0e\x04\uffff\x01\x10\x01\uffff\x08\x0e\x01"+
				"\x14\x11\x0e",
				"\x0a\x0e\x02\uffff\x01\x0f\x01\uffff\x01\x0f\x02\uffff\x1a\x0e\x01"+
				"\x0f\x01\uffff\x01\x0f\x01\uffff\x01\x10\x01\uffff\x1a\x0e",
				"\x0a\x0e\x07\uffff\x1a\x0e\x04\uffff\x01\x10\x01\uffff\x0d\x0e\x01"+
				"\x16\x0c\x0e",
				"",
				"\x0a\x0e\x07\uffff\x1a\x0e\x04\uffff\x01\x10\x01\uffff\x06\x0e\x01"+
				"\x17\x13\x0e",
				"\x0a\x0e\x02\uffff\x01\x0f\x01\uffff\x01\x0f\x02\uffff\x1a\x0e\x01"+
				"\x0f\x01\uffff\x01\x0f\x01\uffff\x01\x10\x01\uffff\x1a\x0e",
				""
			};

		private static readonly short[] DFA8_eot = DFA.UnpackEncodedString(DFA8_eotS);
		private static readonly short[] DFA8_eof = DFA.UnpackEncodedString(DFA8_eofS);
		private static readonly char[] DFA8_min = DFA.UnpackEncodedStringToUnsignedChars(DFA8_minS);
		private static readonly char[] DFA8_max = DFA.UnpackEncodedStringToUnsignedChars(DFA8_maxS);
		private static readonly short[] DFA8_accept = DFA.UnpackEncodedString(DFA8_acceptS);
		private static readonly short[] DFA8_special = DFA.UnpackEncodedString(DFA8_specialS);
		private static readonly short[][] DFA8_transition;

		static DFA8()
		{
			int numStates = DFA8_transitionS.Length;
			DFA8_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA8_transition[i] = DFA.UnpackEncodedString(DFA8_transitionS[i]);
			}
		}

		public DFA8( BaseRecognizer recognizer )
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

		public override string Description { get { return "1:1: Tokens : ( T__20 | T__21 | T__22 | T__23 | T__24 | T__25 | T__26 | TYPE | Modifier | ID | INT | COMMENT | WS );"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

 
	#endregion

}
}