// $ANTLR 3.3 Nov 30, 2010 12:45:30 C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g 2011-08-29 11:42:35

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


using Antlr.Runtime.Tree;
using RewriteRuleITokenStream = Antlr.Runtime.Tree.RewriteRuleTokenStream;

namespace  MessageContracts 
{
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "3.3 Nov 30, 2010 12:45:30")]
[System.CLSCompliant(false)]
public partial class MessageContractsParser : Antlr.Runtime.Parser
{
	internal static readonly string[] tokenNames = new string[] {
		"<invalid>", "<EOR>", "<DOWN>", "<UP>", "TypeToken", "CommandToken", "EventToken", "MemberToken", "BlockToken", "DisctionaryToken", "FragmentGroup", "FragmentEntry", "FragmentReference", "ModifierDefinition", "LET", "ID", "USING", "Modifier", "INT", "COMMENT", "WS", "'='", "';'", "'('", "','", "')'"
	};
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

	#if ANTLR_DEBUG
		private static readonly bool[] decisionCanBacktrack =
			new bool[]
			{
				false, // invalid decision
				false, false, false, false, false, false
			};
	#else
		private static readonly bool[] decisionCanBacktrack = new bool[0];
	#endif
	public MessageContractsParser( ITokenStream input )
		: this( input, new RecognizerSharedState() )
	{
	}
	public MessageContractsParser(ITokenStream input, RecognizerSharedState state)
		: base(input, state)
	{
		ITreeAdaptor treeAdaptor = null;
		CreateTreeAdaptor(ref treeAdaptor);
		TreeAdaptor = treeAdaptor ?? new CommonTreeAdaptor();

		OnCreated();
	}
		
	// Implement this function in your helper file to use a custom tree adaptor
	void CreateTreeAdaptor(ref ITreeAdaptor adaptor) {}

	private ITreeAdaptor adaptor;

	public ITreeAdaptor TreeAdaptor
	{
		get
		{
			return adaptor;
		}
		set
		{
			this.adaptor = value;
		}
	}

	public override string[] TokenNames { get { return MessageContractsParser.tokenNames; } }
	public override string GrammarFileName { get { return "C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g"; } }



 	protected virtual void OnCreated() {}
	protected virtual void EnterRule(string ruleName, int ruleIndex) {}
	protected virtual void LeaveRule(string ruleName, int ruleIndex) {}

    public class program_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_program() {}
    protected virtual void Leave_program() {}

    // $ANTLR start "program"
    // C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:27:1: program : ( declaration )+ ;
    [GrammarRule("program")]
    private MessageContractsParser.program_return program()
    {

        MessageContractsParser.program_return retval = new MessageContractsParser.program_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        MessageContractsParser.declaration_return declaration1 = default(MessageContractsParser.declaration_return);


    	try { DebugEnterRule(GrammarFileName, "program");
    	DebugLocation(27, 1);
    	try
    	{
    		// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:28:2: ( ( declaration )+ )
    		DebugEnterAlt(1);
    		// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:28:4: ( declaration )+
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(28, 4);
    		// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:28:4: ( declaration )+
    		int cnt1=0;
    		try { DebugEnterSubRule(1);
    		while (true)
    		{
    			int alt1=2;
    			try { DebugEnterDecision(1, decisionCanBacktrack[1]);
    			int LA1_0 = input.LA(1);

    			if (((LA1_0>=LET && LA1_0<=USING)))
    			{
    				alt1=1;
    			}


    			} finally { DebugExitDecision(1); }
    			switch (alt1)
    			{
    			case 1:
    				DebugEnterAlt(1);
    				// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:28:4: declaration
    				{
    				DebugLocation(28, 4);
    				PushFollow(Follow._declaration_in_program98);
    				declaration1=declaration();
    				PopFollow();

    				adaptor.AddChild(root_0, declaration1.Tree);

    				}
    				break;

    			default:
    				if (cnt1 >= 1)
    					goto loop1;

    				EarlyExitException eee1 = new EarlyExitException( 1, input );
    				DebugRecognitionException(eee1);
    				throw eee1;
    			}
    			cnt1++;
    		}
    		loop1:
    			;

    		} finally { DebugExitSubRule(1); }


    		}

    		retval.Stop = (IToken)input.LT(-1);

    		retval.Tree = (object)adaptor.RulePostProcessing(root_0);
    		adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

    	}
    	catch (RecognitionException re)
    	{
    		ReportError(re);
    		Recover(input,re);
    	retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

    	}
    	finally
    	{
        }
     	DebugLocation(29, 1);
    	} finally { DebugExitRule(GrammarFileName, "program"); }
    	return retval;

    }
    // $ANTLR end "program"

    public class declaration_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_declaration() {}
    protected virtual void Leave_declaration() {}

    // $ANTLR start "declaration"
    // C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:31:1: declaration : ( modifier_declaration | frag_declaration | type_declaration );
    [GrammarRule("declaration")]
    private MessageContractsParser.declaration_return declaration()
    {

        MessageContractsParser.declaration_return retval = new MessageContractsParser.declaration_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        MessageContractsParser.modifier_declaration_return modifier_declaration2 = default(MessageContractsParser.modifier_declaration_return);
        MessageContractsParser.frag_declaration_return frag_declaration3 = default(MessageContractsParser.frag_declaration_return);
        MessageContractsParser.type_declaration_return type_declaration4 = default(MessageContractsParser.type_declaration_return);


    	try { DebugEnterRule(GrammarFileName, "declaration");
    	DebugLocation(31, 1);
    	try
    	{
    		// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:32:2: ( modifier_declaration | frag_declaration | type_declaration )
    		int alt2=3;
    		try { DebugEnterDecision(2, decisionCanBacktrack[2]);
    		switch (input.LA(1))
    		{
    		case USING:
    			{
    			alt2=1;
    			}
    			break;
    		case LET:
    			{
    			alt2=2;
    			}
    			break;
    		case ID:
    			{
    			alt2=3;
    			}
    			break;
    		default:
    			{
    				NoViableAltException nvae = new NoViableAltException("", 2, 0, input);

    				DebugRecognitionException(nvae);
    				throw nvae;
    			}
    		}

    		} finally { DebugExitDecision(2); }
    		switch (alt2)
    		{
    		case 1:
    			DebugEnterAlt(1);
    			// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:32:4: modifier_declaration
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(32, 4);
    			PushFollow(Follow._modifier_declaration_in_declaration111);
    			modifier_declaration2=modifier_declaration();
    			PopFollow();

    			adaptor.AddChild(root_0, modifier_declaration2.Tree);

    			}
    			break;
    		case 2:
    			DebugEnterAlt(2);
    			// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:33:4: frag_declaration
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(33, 4);
    			PushFollow(Follow._frag_declaration_in_declaration116);
    			frag_declaration3=frag_declaration();
    			PopFollow();

    			adaptor.AddChild(root_0, frag_declaration3.Tree);

    			}
    			break;
    		case 3:
    			DebugEnterAlt(3);
    			// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:34:4: type_declaration
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(34, 4);
    			PushFollow(Follow._type_declaration_in_declaration121);
    			type_declaration4=type_declaration();
    			PopFollow();

    			adaptor.AddChild(root_0, type_declaration4.Tree);

    			}
    			break;

    		}
    		retval.Stop = (IToken)input.LT(-1);

    		retval.Tree = (object)adaptor.RulePostProcessing(root_0);
    		adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

    	}
    	catch (RecognitionException re)
    	{
    		ReportError(re);
    		Recover(input,re);
    	retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

    	}
    	finally
    	{
        }
     	DebugLocation(35, 1);
    	} finally { DebugExitRule(GrammarFileName, "declaration"); }
    	return retval;

    }
    // $ANTLR end "declaration"

    public class frag_declaration_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_frag_declaration() {}
    protected virtual void Leave_frag_declaration() {}

    // $ANTLR start "frag_declaration"
    // C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:37:1: frag_declaration : LET ID '=' ID ID ';' -> ^( FragmentEntry ID ID ID ) ;
    [GrammarRule("frag_declaration")]
    private MessageContractsParser.frag_declaration_return frag_declaration()
    {

        MessageContractsParser.frag_declaration_return retval = new MessageContractsParser.frag_declaration_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken LET5=null;
        IToken ID6=null;
        IToken char_literal7=null;
        IToken ID8=null;
        IToken ID9=null;
        IToken char_literal10=null;

        object LET5_tree=null;
        object ID6_tree=null;
        object char_literal7_tree=null;
        object ID8_tree=null;
        object ID9_tree=null;
        object char_literal10_tree=null;
        RewriteRuleITokenStream stream_21=new RewriteRuleITokenStream(adaptor,"token 21");
        RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
        RewriteRuleITokenStream stream_22=new RewriteRuleITokenStream(adaptor,"token 22");
        RewriteRuleITokenStream stream_LET=new RewriteRuleITokenStream(adaptor,"token LET");

    	try { DebugEnterRule(GrammarFileName, "frag_declaration");
    	DebugLocation(37, 52);
    	try
    	{
    		// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:38:2: ( LET ID '=' ID ID ';' -> ^( FragmentEntry ID ID ID ) )
    		DebugEnterAlt(1);
    		// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:38:4: LET ID '=' ID ID ';'
    		{
    		DebugLocation(38, 4);
    		LET5=(IToken)Match(input,LET,Follow._LET_in_frag_declaration133);  
    		stream_LET.Add(LET5);

    		DebugLocation(38, 8);
    		ID6=(IToken)Match(input,ID,Follow._ID_in_frag_declaration135);  
    		stream_ID.Add(ID6);

    		DebugLocation(38, 11);
    		char_literal7=(IToken)Match(input,21,Follow._21_in_frag_declaration137);  
    		stream_21.Add(char_literal7);

    		DebugLocation(38, 15);
    		ID8=(IToken)Match(input,ID,Follow._ID_in_frag_declaration139);  
    		stream_ID.Add(ID8);

    		DebugLocation(38, 18);
    		ID9=(IToken)Match(input,ID,Follow._ID_in_frag_declaration141);  
    		stream_ID.Add(ID9);

    		DebugLocation(38, 21);
    		char_literal10=(IToken)Match(input,22,Follow._22_in_frag_declaration143);  
    		stream_22.Add(char_literal10);



    		{
    		// AST REWRITE
    		// elements: ID, ID, ID
    		// token labels: 
    		// rule labels: retval
    		// token list labels: 
    		// rule list labels: 
    		// wildcard labels: 
    		retval.Tree = root_0;
    		RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

    		root_0 = (object)adaptor.Nil();
    		// 38:25: -> ^( FragmentEntry ID ID ID )
    		{
    			DebugLocation(38, 28);
    			// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:38:28: ^( FragmentEntry ID ID ID )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(38, 30);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(FragmentEntry, "FragmentEntry"), root_1);

    			DebugLocation(38, 44);
    			adaptor.AddChild(root_1, stream_ID.NextNode());
    			DebugLocation(38, 47);
    			adaptor.AddChild(root_1, stream_ID.NextNode());
    			DebugLocation(38, 50);
    			adaptor.AddChild(root_1, stream_ID.NextNode());

    			adaptor.AddChild(root_0, root_1);
    			}

    		}

    		retval.Tree = root_0;
    		}

    		}

    		retval.Stop = (IToken)input.LT(-1);

    		retval.Tree = (object)adaptor.RulePostProcessing(root_0);
    		adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

    	}
    	catch (RecognitionException re)
    	{
    		ReportError(re);
    		Recover(input,re);
    	retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

    	}
    	finally
    	{
        }
     	DebugLocation(38, 52);
    	} finally { DebugExitRule(GrammarFileName, "frag_declaration"); }
    	return retval;

    }
    // $ANTLR end "frag_declaration"

    public class modifier_declaration_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_modifier_declaration() {}
    protected virtual void Leave_modifier_declaration() {}

    // $ANTLR start "modifier_declaration"
    // C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:40:1: modifier_declaration : USING Modifier '=' ID ';' -> ^( ModifierDefinition ID Modifier ) ;
    [GrammarRule("modifier_declaration")]
    private MessageContractsParser.modifier_declaration_return modifier_declaration()
    {

        MessageContractsParser.modifier_declaration_return retval = new MessageContractsParser.modifier_declaration_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken USING11=null;
        IToken Modifier12=null;
        IToken char_literal13=null;
        IToken ID14=null;
        IToken char_literal15=null;

        object USING11_tree=null;
        object Modifier12_tree=null;
        object char_literal13_tree=null;
        object ID14_tree=null;
        object char_literal15_tree=null;
        RewriteRuleITokenStream stream_21=new RewriteRuleITokenStream(adaptor,"token 21");
        RewriteRuleITokenStream stream_USING=new RewriteRuleITokenStream(adaptor,"token USING");
        RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
        RewriteRuleITokenStream stream_22=new RewriteRuleITokenStream(adaptor,"token 22");
        RewriteRuleITokenStream stream_Modifier=new RewriteRuleITokenStream(adaptor,"token Modifier");

    	try { DebugEnterRule(GrammarFileName, "modifier_declaration");
    	DebugLocation(40, 65);
    	try
    	{
    		// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:41:2: ( USING Modifier '=' ID ';' -> ^( ModifierDefinition ID Modifier ) )
    		DebugEnterAlt(1);
    		// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:41:4: USING Modifier '=' ID ';'
    		{
    		DebugLocation(41, 4);
    		USING11=(IToken)Match(input,USING,Follow._USING_in_modifier_declaration170);  
    		stream_USING.Add(USING11);

    		DebugLocation(41, 10);
    		Modifier12=(IToken)Match(input,Modifier,Follow._Modifier_in_modifier_declaration172);  
    		stream_Modifier.Add(Modifier12);

    		DebugLocation(41, 19);
    		char_literal13=(IToken)Match(input,21,Follow._21_in_modifier_declaration174);  
    		stream_21.Add(char_literal13);

    		DebugLocation(41, 23);
    		ID14=(IToken)Match(input,ID,Follow._ID_in_modifier_declaration176);  
    		stream_ID.Add(ID14);

    		DebugLocation(41, 26);
    		char_literal15=(IToken)Match(input,22,Follow._22_in_modifier_declaration178);  
    		stream_22.Add(char_literal15);



    		{
    		// AST REWRITE
    		// elements: ID, Modifier
    		// token labels: 
    		// rule labels: retval
    		// token list labels: 
    		// rule list labels: 
    		// wildcard labels: 
    		retval.Tree = root_0;
    		RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

    		root_0 = (object)adaptor.Nil();
    		// 41:30: -> ^( ModifierDefinition ID Modifier )
    		{
    			DebugLocation(41, 33);
    			// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:41:33: ^( ModifierDefinition ID Modifier )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(41, 35);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ModifierDefinition, "ModifierDefinition"), root_1);

    			DebugLocation(41, 54);
    			adaptor.AddChild(root_1, stream_ID.NextNode());
    			DebugLocation(41, 57);
    			adaptor.AddChild(root_1, stream_Modifier.NextNode());

    			adaptor.AddChild(root_0, root_1);
    			}

    		}

    		retval.Tree = root_0;
    		}

    		}

    		retval.Stop = (IToken)input.LT(-1);

    		retval.Tree = (object)adaptor.RulePostProcessing(root_0);
    		adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

    	}
    	catch (RecognitionException re)
    	{
    		ReportError(re);
    		Recover(input,re);
    	retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

    	}
    	finally
    	{
        }
     	DebugLocation(41, 65);
    	} finally { DebugExitRule(GrammarFileName, "modifier_declaration"); }
    	return retval;

    }
    // $ANTLR end "modifier_declaration"

    public class type_declaration_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_type_declaration() {}
    protected virtual void Leave_type_declaration() {}

    // $ANTLR start "type_declaration"
    // C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:46:1: type_declaration : ID ( Modifier )? block -> ^( TypeToken ID block ( Modifier )? ) ;
    [GrammarRule("type_declaration")]
    private MessageContractsParser.type_declaration_return type_declaration()
    {

        MessageContractsParser.type_declaration_return retval = new MessageContractsParser.type_declaration_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken ID16=null;
        IToken Modifier17=null;
        MessageContractsParser.block_return block18 = default(MessageContractsParser.block_return);

        object ID16_tree=null;
        object Modifier17_tree=null;
        RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
        RewriteRuleITokenStream stream_Modifier=new RewriteRuleITokenStream(adaptor,"token Modifier");
        RewriteRuleSubtreeStream stream_block=new RewriteRuleSubtreeStream(adaptor,"rule block");
    	try { DebugEnterRule(GrammarFileName, "type_declaration");
    	DebugLocation(46, 56);
    	try
    	{
    		// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:47:2: ( ID ( Modifier )? block -> ^( TypeToken ID block ( Modifier )? ) )
    		DebugEnterAlt(1);
    		// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:47:4: ID ( Modifier )? block
    		{
    		DebugLocation(47, 4);
    		ID16=(IToken)Match(input,ID,Follow._ID_in_type_declaration206);  
    		stream_ID.Add(ID16);

    		DebugLocation(47, 7);
    		// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:47:7: ( Modifier )?
    		int alt3=2;
    		try { DebugEnterSubRule(3);
    		try { DebugEnterDecision(3, decisionCanBacktrack[3]);
    		int LA3_0 = input.LA(1);

    		if ((LA3_0==Modifier))
    		{
    			alt3=1;
    		}
    		} finally { DebugExitDecision(3); }
    		switch (alt3)
    		{
    		case 1:
    			DebugEnterAlt(1);
    			// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:47:7: Modifier
    			{
    			DebugLocation(47, 7);
    			Modifier17=(IToken)Match(input,Modifier,Follow._Modifier_in_type_declaration208);  
    			stream_Modifier.Add(Modifier17);


    			}
    			break;

    		}
    		} finally { DebugExitSubRule(3); }

    		DebugLocation(47, 17);
    		PushFollow(Follow._block_in_type_declaration211);
    		block18=block();
    		PopFollow();

    		stream_block.Add(block18.Tree);


    		{
    		// AST REWRITE
    		// elements: Modifier, ID, block
    		// token labels: 
    		// rule labels: retval
    		// token list labels: 
    		// rule list labels: 
    		// wildcard labels: 
    		retval.Tree = root_0;
    		RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

    		root_0 = (object)adaptor.Nil();
    		// 47:23: -> ^( TypeToken ID block ( Modifier )? )
    		{
    			DebugLocation(47, 26);
    			// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:47:26: ^( TypeToken ID block ( Modifier )? )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(47, 28);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(TypeToken, "TypeToken"), root_1);

    			DebugLocation(47, 38);
    			adaptor.AddChild(root_1, stream_ID.NextNode());
    			DebugLocation(47, 41);
    			adaptor.AddChild(root_1, stream_block.NextTree());
    			DebugLocation(47, 47);
    			// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:47:47: ( Modifier )?
    			if ( stream_Modifier.HasNext )
    			{
    				DebugLocation(47, 47);
    				adaptor.AddChild(root_1, stream_Modifier.NextNode());

    			}
    			stream_Modifier.Reset();

    			adaptor.AddChild(root_0, root_1);
    			}

    		}

    		retval.Tree = root_0;
    		}

    		}

    		retval.Stop = (IToken)input.LT(-1);

    		retval.Tree = (object)adaptor.RulePostProcessing(root_0);
    		adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

    	}
    	catch (RecognitionException re)
    	{
    		ReportError(re);
    		Recover(input,re);
    	retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

    	}
    	finally
    	{
        }
     	DebugLocation(47, 56);
    	} finally { DebugExitRule(GrammarFileName, "type_declaration"); }
    	return retval;

    }
    // $ANTLR end "type_declaration"

    public class member_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_member() {}
    protected virtual void Leave_member() {}

    // $ANTLR start "member"
    // C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:49:1: member : ( ID ID -> ^( MemberToken ID ID ) | ID -> ^( FragmentReference ID ) );
    [GrammarRule("member")]
    private MessageContractsParser.member_return member()
    {

        MessageContractsParser.member_return retval = new MessageContractsParser.member_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken ID19=null;
        IToken ID20=null;
        IToken ID21=null;

        object ID19_tree=null;
        object ID20_tree=null;
        object ID21_tree=null;
        RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");

    	try { DebugEnterRule(GrammarFileName, "member");
    	DebugLocation(49, 1);
    	try
    	{
    		// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:50:2: ( ID ID -> ^( MemberToken ID ID ) | ID -> ^( FragmentReference ID ) )
    		int alt4=2;
    		try { DebugEnterDecision(4, decisionCanBacktrack[4]);
    		int LA4_0 = input.LA(1);

    		if ((LA4_0==ID))
    		{
    			int LA4_1 = input.LA(2);

    			if ((LA4_1==ID))
    			{
    				alt4=1;
    			}
    			else if (((LA4_1>=24 && LA4_1<=25)))
    			{
    				alt4=2;
    			}
    			else
    			{
    				NoViableAltException nvae = new NoViableAltException("", 4, 1, input);

    				DebugRecognitionException(nvae);
    				throw nvae;
    			}
    		}
    		else
    		{
    			NoViableAltException nvae = new NoViableAltException("", 4, 0, input);

    			DebugRecognitionException(nvae);
    			throw nvae;
    		}
    		} finally { DebugExitDecision(4); }
    		switch (alt4)
    		{
    		case 1:
    			DebugEnterAlt(1);
    			// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:50:4: ID ID
    			{
    			DebugLocation(50, 4);
    			ID19=(IToken)Match(input,ID,Follow._ID_in_member236);  
    			stream_ID.Add(ID19);

    			DebugLocation(50, 7);
    			ID20=(IToken)Match(input,ID,Follow._ID_in_member238);  
    			stream_ID.Add(ID20);



    			{
    			// AST REWRITE
    			// elements: ID, ID
    			// token labels: 
    			// rule labels: retval
    			// token list labels: 
    			// rule list labels: 
    			// wildcard labels: 
    			retval.Tree = root_0;
    			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

    			root_0 = (object)adaptor.Nil();
    			// 50:10: -> ^( MemberToken ID ID )
    			{
    				DebugLocation(50, 13);
    				// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:50:13: ^( MemberToken ID ID )
    				{
    				object root_1 = (object)adaptor.Nil();
    				DebugLocation(50, 15);
    				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(MemberToken, "MemberToken"), root_1);

    				DebugLocation(50, 27);
    				adaptor.AddChild(root_1, stream_ID.NextNode());
    				DebugLocation(50, 30);
    				adaptor.AddChild(root_1, stream_ID.NextNode());

    				adaptor.AddChild(root_0, root_1);
    				}

    			}

    			retval.Tree = root_0;
    			}

    			}
    			break;
    		case 2:
    			DebugEnterAlt(2);
    			// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:51:4: ID
    			{
    			DebugLocation(51, 4);
    			ID21=(IToken)Match(input,ID,Follow._ID_in_member253);  
    			stream_ID.Add(ID21);



    			{
    			// AST REWRITE
    			// elements: ID
    			// token labels: 
    			// rule labels: retval
    			// token list labels: 
    			// rule list labels: 
    			// wildcard labels: 
    			retval.Tree = root_0;
    			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

    			root_0 = (object)adaptor.Nil();
    			// 51:7: -> ^( FragmentReference ID )
    			{
    				DebugLocation(51, 10);
    				// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:51:10: ^( FragmentReference ID )
    				{
    				object root_1 = (object)adaptor.Nil();
    				DebugLocation(51, 12);
    				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(FragmentReference, "FragmentReference"), root_1);

    				DebugLocation(51, 30);
    				adaptor.AddChild(root_1, stream_ID.NextNode());

    				adaptor.AddChild(root_0, root_1);
    				}

    			}

    			retval.Tree = root_0;
    			}

    			}
    			break;

    		}
    		retval.Stop = (IToken)input.LT(-1);

    		retval.Tree = (object)adaptor.RulePostProcessing(root_0);
    		adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

    	}
    	catch (RecognitionException re)
    	{
    		ReportError(re);
    		Recover(input,re);
    	retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

    	}
    	finally
    	{
        }
     	DebugLocation(52, 1);
    	} finally { DebugExitRule(GrammarFileName, "member"); }
    	return retval;

    }
    // $ANTLR end "member"

    public class block_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_block() {}
    protected virtual void Leave_block() {}

    // $ANTLR start "block"
    // C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:55:1: block : lc= '(' ( member ( ',' member )* )? ')' -> ^( BlockToken[$lc,\"Block\"] ( member )* ) ;
    [GrammarRule("block")]
    private MessageContractsParser.block_return block()
    {

        MessageContractsParser.block_return retval = new MessageContractsParser.block_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken lc=null;
        IToken char_literal23=null;
        IToken char_literal25=null;
        MessageContractsParser.member_return member22 = default(MessageContractsParser.member_return);
        MessageContractsParser.member_return member24 = default(MessageContractsParser.member_return);

        object lc_tree=null;
        object char_literal23_tree=null;
        object char_literal25_tree=null;
        RewriteRuleITokenStream stream_23=new RewriteRuleITokenStream(adaptor,"token 23");
        RewriteRuleITokenStream stream_24=new RewriteRuleITokenStream(adaptor,"token 24");
        RewriteRuleITokenStream stream_25=new RewriteRuleITokenStream(adaptor,"token 25");
        RewriteRuleSubtreeStream stream_member=new RewriteRuleSubtreeStream(adaptor,"rule member");
    	try { DebugEnterRule(GrammarFileName, "block");
    	DebugLocation(55, 4);
    	try
    	{
    		// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:56:5: (lc= '(' ( member ( ',' member )* )? ')' -> ^( BlockToken[$lc,\"Block\"] ( member )* ) )
    		DebugEnterAlt(1);
    		// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:56:9: lc= '(' ( member ( ',' member )* )? ')'
    		{
    		DebugLocation(56, 11);
    		lc=(IToken)Match(input,23,Follow._23_in_block281);  
    		stream_23.Add(lc);

    		DebugLocation(57, 13);
    		// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:57:13: ( member ( ',' member )* )?
    		int alt6=2;
    		try { DebugEnterSubRule(6);
    		try { DebugEnterDecision(6, decisionCanBacktrack[6]);
    		int LA6_0 = input.LA(1);

    		if ((LA6_0==ID))
    		{
    			alt6=1;
    		}
    		} finally { DebugExitDecision(6); }
    		switch (alt6)
    		{
    		case 1:
    			DebugEnterAlt(1);
    			// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:57:14: member ( ',' member )*
    			{
    			DebugLocation(57, 14);
    			PushFollow(Follow._member_in_block296);
    			member22=member();
    			PopFollow();

    			stream_member.Add(member22.Tree);
    			DebugLocation(57, 21);
    			// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:57:21: ( ',' member )*
    			try { DebugEnterSubRule(5);
    			while (true)
    			{
    				int alt5=2;
    				try { DebugEnterDecision(5, decisionCanBacktrack[5]);
    				int LA5_0 = input.LA(1);

    				if ((LA5_0==24))
    				{
    					alt5=1;
    				}


    				} finally { DebugExitDecision(5); }
    				switch ( alt5 )
    				{
    				case 1:
    					DebugEnterAlt(1);
    					// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:57:22: ',' member
    					{
    					DebugLocation(57, 22);
    					char_literal23=(IToken)Match(input,24,Follow._24_in_block299);  
    					stream_24.Add(char_literal23);

    					DebugLocation(57, 26);
    					PushFollow(Follow._member_in_block301);
    					member24=member();
    					PopFollow();

    					stream_member.Add(member24.Tree);

    					}
    					break;

    				default:
    					goto loop5;
    				}
    			}

    			loop5:
    				;

    			} finally { DebugExitSubRule(5); }


    			}
    			break;

    		}
    		} finally { DebugExitSubRule(6); }

    		DebugLocation(58, 9);
    		char_literal25=(IToken)Match(input,25,Follow._25_in_block315);  
    		stream_25.Add(char_literal25);



    		{
    		// AST REWRITE
    		// elements: member
    		// token labels: 
    		// rule labels: retval
    		// token list labels: 
    		// rule list labels: 
    		// wildcard labels: 
    		retval.Tree = root_0;
    		RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

    		root_0 = (object)adaptor.Nil();
    		// 59:9: -> ^( BlockToken[$lc,\"Block\"] ( member )* )
    		{
    			DebugLocation(59, 12);
    			// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:59:12: ^( BlockToken[$lc,\"Block\"] ( member )* )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(59, 14);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(BlockToken, lc, "Block"), root_1);

    			DebugLocation(59, 38);
    			// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:59:38: ( member )*
    			while ( stream_member.HasNext )
    			{
    				DebugLocation(59, 38);
    				adaptor.AddChild(root_1, stream_member.NextTree());

    			}
    			stream_member.Reset();

    			adaptor.AddChild(root_0, root_1);
    			}

    		}

    		retval.Tree = root_0;
    		}

    		}

    		retval.Stop = (IToken)input.LT(-1);

    		retval.Tree = (object)adaptor.RulePostProcessing(root_0);
    		adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

    	}
    	catch (RecognitionException re)
    	{
    		ReportError(re);
    		Recover(input,re);
    	retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

    	}
    	finally
    	{
        }
     	DebugLocation(60, 4);
    	} finally { DebugExitRule(GrammarFileName, "block"); }
    	return retval;

    }
    // $ANTLR end "block"

	#region Follow sets
	private static class Follow
	{
		public static readonly BitSet _declaration_in_program98 = new BitSet(new ulong[]{0x000000000001C002UL});
		public static readonly BitSet _modifier_declaration_in_declaration111 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _frag_declaration_in_declaration116 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _type_declaration_in_declaration121 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _LET_in_frag_declaration133 = new BitSet(new ulong[]{0x0000000000008000UL});
		public static readonly BitSet _ID_in_frag_declaration135 = new BitSet(new ulong[]{0x0000000000200000UL});
		public static readonly BitSet _21_in_frag_declaration137 = new BitSet(new ulong[]{0x0000000000008000UL});
		public static readonly BitSet _ID_in_frag_declaration139 = new BitSet(new ulong[]{0x0000000000008000UL});
		public static readonly BitSet _ID_in_frag_declaration141 = new BitSet(new ulong[]{0x0000000000400000UL});
		public static readonly BitSet _22_in_frag_declaration143 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _USING_in_modifier_declaration170 = new BitSet(new ulong[]{0x0000000000020000UL});
		public static readonly BitSet _Modifier_in_modifier_declaration172 = new BitSet(new ulong[]{0x0000000000200000UL});
		public static readonly BitSet _21_in_modifier_declaration174 = new BitSet(new ulong[]{0x0000000000008000UL});
		public static readonly BitSet _ID_in_modifier_declaration176 = new BitSet(new ulong[]{0x0000000000400000UL});
		public static readonly BitSet _22_in_modifier_declaration178 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _ID_in_type_declaration206 = new BitSet(new ulong[]{0x0000000000820000UL});
		public static readonly BitSet _Modifier_in_type_declaration208 = new BitSet(new ulong[]{0x0000000000820000UL});
		public static readonly BitSet _block_in_type_declaration211 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _ID_in_member236 = new BitSet(new ulong[]{0x0000000000008000UL});
		public static readonly BitSet _ID_in_member238 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _ID_in_member253 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _23_in_block281 = new BitSet(new ulong[]{0x0000000002008000UL});
		public static readonly BitSet _member_in_block296 = new BitSet(new ulong[]{0x0000000003000000UL});
		public static readonly BitSet _24_in_block299 = new BitSet(new ulong[]{0x0000000000008000UL});
		public static readonly BitSet _member_in_block301 = new BitSet(new ulong[]{0x0000000003000000UL});
		public static readonly BitSet _25_in_block315 = new BitSet(new ulong[]{0x0000000000000002UL});

	}
	#endregion Follow sets
}
}