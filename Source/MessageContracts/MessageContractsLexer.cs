// $ANTLR 3.3 Nov 30, 2010 12:45:30 C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g 2011-09-14 15:30:05

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
	public const int T__23=23;
	public const int T__24=24;
	public const int T__25=25;
	public const int T__26=26;
	public const int T__27=27;
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
	public const int EntityDefinition=14;
	public const int LET=15;
	public const int ID=16;
	public const int USING=17;
	public const int Modifier=18;
	public const int ENTITY=19;
	public const int INT=20;
	public const int COMMENT=21;
	public const int WS=22;

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
    // $ANTLR end "T__26"

    protected virtual void Enter_T__27() {}
    protected virtual void Leave_T__27() {}

    // $ANTLR start "T__27"
    [GrammarRule("T__27")]
    private void mT__27()
    {

    		try
    		{
    		int _type = T__27;
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
    // $ANTLR end "T__27"

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
    		// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:65:2: ( 'using' )
    		DebugEnterAlt(1);
    		// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:65:4: 'using'
    		{
    		DebugLocation(65, 4);
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
    		// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:67:2: ( 'let' )
    		DebugEnterAlt(1);
    		// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:67:4: 'let'
    		{
    		DebugLocation(67, 4);
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

    protected virtual void Enter_ENTITY() {}
    protected virtual void Leave_ENTITY() {}

    // $ANTLR start "ENTITY"
    [GrammarRule("ENTITY")]
    private void mENTITY()
    {

    		try
    		{
    		int _type = ENTITY;
    		int _channel = DefaultTokenChannel;
    		// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:68:9: ( 'entity' )
    		DebugEnterAlt(1);
    		// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:68:11: 'entity'
    		{
    		DebugLocation(68, 11);
    		Match("entity"); 


    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
        }
    }
    // $ANTLR end "ENTITY"

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
    		// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:69:5: ( ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' | '<' | '>' | '[' | ']' )* )
    		DebugEnterAlt(1);
    		// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:69:7: ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' | '<' | '>' | '[' | ']' )*
    		{
    		DebugLocation(69, 7);
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

    		DebugLocation(69, 30);
    		// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:69:30: ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' | '<' | '>' | '[' | ']' )*
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
    				DebugLocation(69, 30);
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
    		// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:74:2: ( '?' | '!' | ';' )
    		DebugEnterAlt(1);
    		// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:
    		{
    		DebugLocation(74, 2);
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
    		// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:80:5: ( ( '0' .. '9' )+ )
    		DebugEnterAlt(1);
    		// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:80:7: ( '0' .. '9' )+
    		{
    		DebugLocation(80, 7);
    		// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:80:7: ( '0' .. '9' )+
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
    				// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:80:7: '0' .. '9'
    				{
    				DebugLocation(80, 7);
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
    		// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:84:5: ( '//' (~ ( '\\n' | '\\r' ) )* ( '\\r' )? '\\n' | '/*' ( options {greedy=false; } : . )* '*/' )
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
    			// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:84:9: '//' (~ ( '\\n' | '\\r' ) )* ( '\\r' )? '\\n'
    			{
    			DebugLocation(84, 9);
    			Match("//"); 

    			DebugLocation(84, 14);
    			// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:84:14: (~ ( '\\n' | '\\r' ) )*
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
    					// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:84:14: ~ ( '\\n' | '\\r' )
    					{
    					DebugLocation(84, 14);
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

    			DebugLocation(84, 28);
    			// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:84:28: ( '\\r' )?
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
    				// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:84:28: '\\r'
    				{
    				DebugLocation(84, 28);
    				Match('\r'); 

    				}
    				break;

    			}
    			} finally { DebugExitSubRule(4); }

    			DebugLocation(84, 34);
    			Match('\n'); 
    			DebugLocation(84, 39);
    			_channel=HIDDEN;

    			}
    			break;
    		case 2:
    			DebugEnterAlt(2);
    			// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:85:9: '/*' ( options {greedy=false; } : . )* '*/'
    			{
    			DebugLocation(85, 9);
    			Match("/*"); 

    			DebugLocation(85, 14);
    			// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:85:14: ( options {greedy=false; } : . )*
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
    					// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:85:42: .
    					{
    					DebugLocation(85, 42);
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

    			DebugLocation(85, 47);
    			Match("*/"); 

    			DebugLocation(85, 52);
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
    		// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:88:5: ( ( ' ' | '\\t' | '\\r' | '\\n' ) )
    		DebugEnterAlt(1);
    		// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:88:9: ( ' ' | '\\t' | '\\r' | '\\n' )
    		{
    		DebugLocation(88, 9);
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

    		DebugLocation(92, 11);
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
    	// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:1:8: ( T__23 | T__24 | T__25 | T__26 | T__27 | USING | LET | ENTITY | ID | Modifier | INT | COMMENT | WS )
    	int alt7=13;
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
    		// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:1:10: T__23
    		{
    		DebugLocation(1, 10);
    		mT__23(); 

    		}
    		break;
    	case 2:
    		DebugEnterAlt(2);
    		// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:1:16: T__24
    		{
    		DebugLocation(1, 16);
    		mT__24(); 

    		}
    		break;
    	case 3:
    		DebugEnterAlt(3);
    		// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:1:22: T__25
    		{
    		DebugLocation(1, 22);
    		mT__25(); 

    		}
    		break;
    	case 4:
    		DebugEnterAlt(4);
    		// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:1:28: T__26
    		{
    		DebugLocation(1, 28);
    		mT__26(); 

    		}
    		break;
    	case 5:
    		DebugEnterAlt(5);
    		// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:1:34: T__27
    		{
    		DebugLocation(1, 34);
    		mT__27(); 

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
    		// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:1:50: ENTITY
    		{
    		DebugLocation(1, 50);
    		mENTITY(); 

    		}
    		break;
    	case 9:
    		DebugEnterAlt(9);
    		// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:1:57: ID
    		{
    		DebugLocation(1, 57);
    		mID(); 

    		}
    		break;
    	case 10:
    		DebugEnterAlt(10);
    		// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:1:60: Modifier
    		{
    		DebugLocation(1, 60);
    		mModifier(); 

    		}
    		break;
    	case 11:
    		DebugEnterAlt(11);
    		// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:1:69: INT
    		{
    		DebugLocation(1, 69);
    		mINT(); 

    		}
    		break;
    	case 12:
    		DebugEnterAlt(12);
    		// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:1:73: COMMENT
    		{
    		DebugLocation(1, 73);
    		mCOMMENT(); 

    		}
    		break;
    	case 13:
    		DebugEnterAlt(13);
    		// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:1:81: WS
    		{
    		DebugLocation(1, 81);
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
			"\x06\uffff\x03\x09\x06\uffff\x04\x09\x01\x16\x02\x09\x01\uffff\x01\x09"+
			"\x01\x1a\x01\x09\x01\uffff\x01\x1c\x01\uffff";
		private const string DFA7_eofS =
			"\x1d\uffff";
		private const string DFA7_minS =
			"\x01\x09\x05\uffff\x01\x73\x01\x65\x01\x6e\x06\uffff\x01\x69\x02\x74"+
			"\x01\x6e\x01\x30\x01\x69\x01\x67\x01\uffff\x01\x74\x01\x30\x01\x79\x01"+
			"\uffff\x01\x30\x01\uffff";
		private const string DFA7_maxS =
			"\x01\x7a\x05\uffff\x01\x73\x01\x65\x01\x6e\x06\uffff\x01\x69\x02\x74"+
			"\x01\x6e\x01\x7a\x01\x69\x01\x67\x01\uffff\x01\x74\x01\x7a\x01\x79\x01"+
			"\uffff\x01\x7a\x01\uffff";
		private const string DFA7_acceptS =
			"\x01\uffff\x01\x01\x01\x02\x01\x03\x01\x04\x01\x05\x03\uffff\x01\x09"+
			"\x01\x0a\x01\x0b\x01\x0c\x01\x0d\x01\x02\x07\uffff\x01\x07\x03\uffff"+
			"\x01\x06\x01\uffff\x01\x08";
		private const string DFA7_specialS =
			"\x1d\uffff}>";
		private static readonly string[] DFA7_transitionS =
			{
				"\x02\x0d\x02\uffff\x01\x0d\x12\uffff\x01\x0d\x01\x0a\x06\uffff\x01"+
				"\x03\x01\x05\x02\uffff\x01\x04\x02\uffff\x01\x0c\x0a\x0b\x01\uffff\x01"+
				"\x02\x01\uffff\x01\x01\x01\uffff\x01\x0a\x01\uffff\x1a\x09\x04\uffff"+
				"\x01\x09\x01\uffff\x04\x09\x01\x08\x06\x09\x01\x07\x08\x09\x01\x06\x05"+
				"\x09",
				"",
				"",
				"",
				"",
				"",
				"\x01\x0f",
				"\x01\x10",
				"\x01\x11",
				"",
				"",
				"",
				"",
				"",
				"",
				"\x01\x12",
				"\x01\x13",
				"\x01\x14",
				"\x01\x15",
				"\x0a\x09\x02\uffff\x01\x09\x01\uffff\x01\x09\x02\uffff\x1b\x09\x01"+
				"\uffff\x01\x09\x01\uffff\x01\x09\x01\uffff\x1a\x09",
				"\x01\x17",
				"\x01\x18",
				"",
				"\x01\x19",
				"\x0a\x09\x02\uffff\x01\x09\x01\uffff\x01\x09\x02\uffff\x1b\x09\x01"+
				"\uffff\x01\x09\x01\uffff\x01\x09\x01\uffff\x1a\x09",
				"\x01\x1b",
				"",
				"\x0a\x09\x02\uffff\x01\x09\x01\uffff\x01\x09\x02\uffff\x1b\x09\x01"+
				"\uffff\x01\x09\x01\uffff\x01\x09\x01\uffff\x1a\x09",
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

		public override string Description { get { return "1:1: Tokens : ( T__23 | T__24 | T__25 | T__26 | T__27 | USING | LET | ENTITY | ID | Modifier | INT | COMMENT | WS );"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

 
	#endregion

}
}