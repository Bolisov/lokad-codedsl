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


using Antlr.Runtime.Tree;
using RewriteRuleITokenStream = Antlr.Runtime.Tree.RewriteRuleTokenStream;

namespace  MessageContracts 
{
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "3.3 Nov 30, 2010 12:45:30")]
[System.CLSCompliant(false)]
public partial class MessageContractsParser : Antlr.Runtime.Parser
{
	internal static readonly string[] tokenNames = new string[] {
		"<invalid>", "<EOR>", "<DOWN>", "<UP>", "TypeToken", "CommandToken", "EventToken", "MemberToken", "BlockToken", "DisctionaryToken", "FragmentGroup", "FragmentEntry", "FragmentReference", "ModifierDefinition", "ID", "TYPE", "Modifier", "INT", "COMMENT", "WS", "'let'", "'='", "';'", "'using'", "'('", "','", "')'"
	};
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
	public override string GrammarFileName { get { return "C:\\Projects\\lokad-message-contracts-dsl-sample\\Source\\MessageContracts\\MessageContracts.g"; } }



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
    // C:\\Projects\\lokad-message-contracts-dsl-sample\\Source\\MessageContracts\\MessageContracts.g:27:1: program : ( declaration )+ ;
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
    		// C:\\Projects\\lokad-message-contracts-dsl-sample\\Source\\MessageContracts\\MessageContracts.g:28:2: ( ( declaration )+ )
    		DebugEnterAlt(1);
    		// C:\\Projects\\lokad-message-contracts-dsl-sample\\Source\\MessageContracts\\MessageContracts.g:28:4: ( declaration )+
    		{
    		root_0 = (object)adaptor.Nil();

    		DebugLocation(28, 4);
    		// C:\\Projects\\lokad-message-contracts-dsl-sample\\Source\\MessageContracts\\MessageContracts.g:28:4: ( declaration )+
    		int cnt1=0;
    		try { DebugEnterSubRule(1);
    		while (true)
    		{
    			int alt1=2;
    			try { DebugEnterDecision(1, decisionCanBacktrack[1]);
    			int LA1_0 = input.LA(1);

    			if ((LA1_0==ID||LA1_0==20||LA1_0==23))
    			{
    				alt1=1;
    			}


    			} finally { DebugExitDecision(1); }
    			switch (alt1)
    			{
    			case 1:
    				DebugEnterAlt(1);
    				// C:\\Projects\\lokad-message-contracts-dsl-sample\\Source\\MessageContracts\\MessageContracts.g:28:4: declaration
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
    // C:\\Projects\\lokad-message-contracts-dsl-sample\\Source\\MessageContracts\\MessageContracts.g:31:1: declaration : ( modifier_declaration | frag_declaration | type_declaration );
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
    		// C:\\Projects\\lokad-message-contracts-dsl-sample\\Source\\MessageContracts\\MessageContracts.g:32:2: ( modifier_declaration | frag_declaration | type_declaration )
    		int alt2=3;
    		try { DebugEnterDecision(2, decisionCanBacktrack[2]);
    		switch (input.LA(1))
    		{
    		case 23:
    			{
    			alt2=1;
    			}
    			break;
    		case 20:
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
    			// C:\\Projects\\lokad-message-contracts-dsl-sample\\Source\\MessageContracts\\MessageContracts.g:32:4: modifier_declaration
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
    			// C:\\Projects\\lokad-message-contracts-dsl-sample\\Source\\MessageContracts\\MessageContracts.g:33:4: frag_declaration
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
    			// C:\\Projects\\lokad-message-contracts-dsl-sample\\Source\\MessageContracts\\MessageContracts.g:34:4: type_declaration
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
    // C:\\Projects\\lokad-message-contracts-dsl-sample\\Source\\MessageContracts\\MessageContracts.g:37:1: frag_declaration : 'let' ID '=' TYPE ID ';' -> ^( FragmentEntry ID TYPE ID ) ;
    [GrammarRule("frag_declaration")]
    private MessageContractsParser.frag_declaration_return frag_declaration()
    {

        MessageContractsParser.frag_declaration_return retval = new MessageContractsParser.frag_declaration_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken string_literal5=null;
        IToken ID6=null;
        IToken char_literal7=null;
        IToken TYPE8=null;
        IToken ID9=null;
        IToken char_literal10=null;

        object string_literal5_tree=null;
        object ID6_tree=null;
        object char_literal7_tree=null;
        object TYPE8_tree=null;
        object ID9_tree=null;
        object char_literal10_tree=null;
        RewriteRuleITokenStream stream_21=new RewriteRuleITokenStream(adaptor,"token 21");
        RewriteRuleITokenStream stream_20=new RewriteRuleITokenStream(adaptor,"token 20");
        RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
        RewriteRuleITokenStream stream_22=new RewriteRuleITokenStream(adaptor,"token 22");
        RewriteRuleITokenStream stream_TYPE=new RewriteRuleITokenStream(adaptor,"token TYPE");

    	try { DebugEnterRule(GrammarFileName, "frag_declaration");
    	DebugLocation(37, 4);
    	try
    	{
    		// C:\\Projects\\lokad-message-contracts-dsl-sample\\Source\\MessageContracts\\MessageContracts.g:38:5: ( 'let' ID '=' TYPE ID ';' -> ^( FragmentEntry ID TYPE ID ) )
    		DebugEnterAlt(1);
    		// C:\\Projects\\lokad-message-contracts-dsl-sample\\Source\\MessageContracts\\MessageContracts.g:38:7: 'let' ID '=' TYPE ID ';'
    		{
    		DebugLocation(38, 7);
    		string_literal5=(IToken)Match(input,20,Follow._20_in_frag_declaration135);  
    		stream_20.Add(string_literal5);

    		DebugLocation(38, 13);
    		ID6=(IToken)Match(input,ID,Follow._ID_in_frag_declaration137);  
    		stream_ID.Add(ID6);

    		DebugLocation(38, 16);
    		char_literal7=(IToken)Match(input,21,Follow._21_in_frag_declaration139);  
    		stream_21.Add(char_literal7);

    		DebugLocation(38, 20);
    		TYPE8=(IToken)Match(input,TYPE,Follow._TYPE_in_frag_declaration141);  
    		stream_TYPE.Add(TYPE8);

    		DebugLocation(38, 25);
    		ID9=(IToken)Match(input,ID,Follow._ID_in_frag_declaration143);  
    		stream_ID.Add(ID9);

    		DebugLocation(38, 28);
    		char_literal10=(IToken)Match(input,22,Follow._22_in_frag_declaration145);  
    		stream_22.Add(char_literal10);



    		{
    		// AST REWRITE
    		// elements: ID, ID, TYPE
    		// token labels: 
    		// rule labels: retval
    		// token list labels: 
    		// rule list labels: 
    		// wildcard labels: 
    		retval.Tree = root_0;
    		RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

    		root_0 = (object)adaptor.Nil();
    		// 38:32: -> ^( FragmentEntry ID TYPE ID )
    		{
    			DebugLocation(38, 35);
    			// C:\\Projects\\lokad-message-contracts-dsl-sample\\Source\\MessageContracts\\MessageContracts.g:38:35: ^( FragmentEntry ID TYPE ID )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(38, 37);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(FragmentEntry, "FragmentEntry"), root_1);

    			DebugLocation(38, 51);
    			adaptor.AddChild(root_1, stream_ID.NextNode());
    			DebugLocation(38, 54);
    			adaptor.AddChild(root_1, stream_TYPE.NextNode());
    			DebugLocation(38, 59);
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
     	DebugLocation(39, 4);
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
    // C:\\Projects\\lokad-message-contracts-dsl-sample\\Source\\MessageContracts\\MessageContracts.g:41:1: modifier_declaration : 'using' Modifier '=' TYPE ';' -> ^( ModifierDefinition TYPE Modifier ) ;
    [GrammarRule("modifier_declaration")]
    private MessageContractsParser.modifier_declaration_return modifier_declaration()
    {

        MessageContractsParser.modifier_declaration_return retval = new MessageContractsParser.modifier_declaration_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken string_literal11=null;
        IToken Modifier12=null;
        IToken char_literal13=null;
        IToken TYPE14=null;
        IToken char_literal15=null;

        object string_literal11_tree=null;
        object Modifier12_tree=null;
        object char_literal13_tree=null;
        object TYPE14_tree=null;
        object char_literal15_tree=null;
        RewriteRuleITokenStream stream_21=new RewriteRuleITokenStream(adaptor,"token 21");
        RewriteRuleITokenStream stream_22=new RewriteRuleITokenStream(adaptor,"token 22");
        RewriteRuleITokenStream stream_23=new RewriteRuleITokenStream(adaptor,"token 23");
        RewriteRuleITokenStream stream_Modifier=new RewriteRuleITokenStream(adaptor,"token Modifier");
        RewriteRuleITokenStream stream_TYPE=new RewriteRuleITokenStream(adaptor,"token TYPE");

    	try { DebugEnterRule(GrammarFileName, "modifier_declaration");
    	DebugLocation(41, 71);
    	try
    	{
    		// C:\\Projects\\lokad-message-contracts-dsl-sample\\Source\\MessageContracts\\MessageContracts.g:42:2: ( 'using' Modifier '=' TYPE ';' -> ^( ModifierDefinition TYPE Modifier ) )
    		DebugEnterAlt(1);
    		// C:\\Projects\\lokad-message-contracts-dsl-sample\\Source\\MessageContracts\\MessageContracts.g:42:4: 'using' Modifier '=' TYPE ';'
    		{
    		DebugLocation(42, 4);
    		string_literal11=(IToken)Match(input,23,Follow._23_in_modifier_declaration177);  
    		stream_23.Add(string_literal11);

    		DebugLocation(42, 12);
    		Modifier12=(IToken)Match(input,Modifier,Follow._Modifier_in_modifier_declaration179);  
    		stream_Modifier.Add(Modifier12);

    		DebugLocation(42, 21);
    		char_literal13=(IToken)Match(input,21,Follow._21_in_modifier_declaration181);  
    		stream_21.Add(char_literal13);

    		DebugLocation(42, 25);
    		TYPE14=(IToken)Match(input,TYPE,Follow._TYPE_in_modifier_declaration183);  
    		stream_TYPE.Add(TYPE14);

    		DebugLocation(42, 30);
    		char_literal15=(IToken)Match(input,22,Follow._22_in_modifier_declaration185);  
    		stream_22.Add(char_literal15);



    		{
    		// AST REWRITE
    		// elements: Modifier, TYPE
    		// token labels: 
    		// rule labels: retval
    		// token list labels: 
    		// rule list labels: 
    		// wildcard labels: 
    		retval.Tree = root_0;
    		RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

    		root_0 = (object)adaptor.Nil();
    		// 42:34: -> ^( ModifierDefinition TYPE Modifier )
    		{
    			DebugLocation(42, 37);
    			// C:\\Projects\\lokad-message-contracts-dsl-sample\\Source\\MessageContracts\\MessageContracts.g:42:37: ^( ModifierDefinition TYPE Modifier )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(42, 39);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ModifierDefinition, "ModifierDefinition"), root_1);

    			DebugLocation(42, 58);
    			adaptor.AddChild(root_1, stream_TYPE.NextNode());
    			DebugLocation(42, 63);
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
     	DebugLocation(42, 71);
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
    // C:\\Projects\\lokad-message-contracts-dsl-sample\\Source\\MessageContracts\\MessageContracts.g:47:1: type_declaration : ID ( Modifier )? block -> ^( TypeToken ID block ( Modifier )? ) ;
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
    	DebugLocation(47, 56);
    	try
    	{
    		// C:\\Projects\\lokad-message-contracts-dsl-sample\\Source\\MessageContracts\\MessageContracts.g:48:2: ( ID ( Modifier )? block -> ^( TypeToken ID block ( Modifier )? ) )
    		DebugEnterAlt(1);
    		// C:\\Projects\\lokad-message-contracts-dsl-sample\\Source\\MessageContracts\\MessageContracts.g:48:4: ID ( Modifier )? block
    		{
    		DebugLocation(48, 4);
    		ID16=(IToken)Match(input,ID,Follow._ID_in_type_declaration213);  
    		stream_ID.Add(ID16);

    		DebugLocation(48, 7);
    		// C:\\Projects\\lokad-message-contracts-dsl-sample\\Source\\MessageContracts\\MessageContracts.g:48:7: ( Modifier )?
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
    			// C:\\Projects\\lokad-message-contracts-dsl-sample\\Source\\MessageContracts\\MessageContracts.g:48:7: Modifier
    			{
    			DebugLocation(48, 7);
    			Modifier17=(IToken)Match(input,Modifier,Follow._Modifier_in_type_declaration215);  
    			stream_Modifier.Add(Modifier17);


    			}
    			break;

    		}
    		} finally { DebugExitSubRule(3); }

    		DebugLocation(48, 17);
    		PushFollow(Follow._block_in_type_declaration218);
    		block18=block();
    		PopFollow();

    		stream_block.Add(block18.Tree);


    		{
    		// AST REWRITE
    		// elements: ID, block, Modifier
    		// token labels: 
    		// rule labels: retval
    		// token list labels: 
    		// rule list labels: 
    		// wildcard labels: 
    		retval.Tree = root_0;
    		RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

    		root_0 = (object)adaptor.Nil();
    		// 48:23: -> ^( TypeToken ID block ( Modifier )? )
    		{
    			DebugLocation(48, 26);
    			// C:\\Projects\\lokad-message-contracts-dsl-sample\\Source\\MessageContracts\\MessageContracts.g:48:26: ^( TypeToken ID block ( Modifier )? )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(48, 28);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(TypeToken, "TypeToken"), root_1);

    			DebugLocation(48, 38);
    			adaptor.AddChild(root_1, stream_ID.NextNode());
    			DebugLocation(48, 41);
    			adaptor.AddChild(root_1, stream_block.NextTree());
    			DebugLocation(48, 47);
    			// C:\\Projects\\lokad-message-contracts-dsl-sample\\Source\\MessageContracts\\MessageContracts.g:48:47: ( Modifier )?
    			if ( stream_Modifier.HasNext )
    			{
    				DebugLocation(48, 47);
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
     	DebugLocation(48, 56);
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
    // C:\\Projects\\lokad-message-contracts-dsl-sample\\Source\\MessageContracts\\MessageContracts.g:50:1: member : ( TYPE ID -> ^( MemberToken TYPE ID ) | ID -> ^( FragmentReference ID ) );
    [GrammarRule("member")]
    private MessageContractsParser.member_return member()
    {

        MessageContractsParser.member_return retval = new MessageContractsParser.member_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken TYPE19=null;
        IToken ID20=null;
        IToken ID21=null;

        object TYPE19_tree=null;
        object ID20_tree=null;
        object ID21_tree=null;
        RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
        RewriteRuleITokenStream stream_TYPE=new RewriteRuleITokenStream(adaptor,"token TYPE");

    	try { DebugEnterRule(GrammarFileName, "member");
    	DebugLocation(50, 1);
    	try
    	{
    		// C:\\Projects\\lokad-message-contracts-dsl-sample\\Source\\MessageContracts\\MessageContracts.g:51:2: ( TYPE ID -> ^( MemberToken TYPE ID ) | ID -> ^( FragmentReference ID ) )
    		int alt4=2;
    		try { DebugEnterDecision(4, decisionCanBacktrack[4]);
    		int LA4_0 = input.LA(1);

    		if ((LA4_0==TYPE))
    		{
    			alt4=1;
    		}
    		else if ((LA4_0==ID))
    		{
    			alt4=2;
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
    			// C:\\Projects\\lokad-message-contracts-dsl-sample\\Source\\MessageContracts\\MessageContracts.g:51:4: TYPE ID
    			{
    			DebugLocation(51, 4);
    			TYPE19=(IToken)Match(input,TYPE,Follow._TYPE_in_member243);  
    			stream_TYPE.Add(TYPE19);

    			DebugLocation(51, 9);
    			ID20=(IToken)Match(input,ID,Follow._ID_in_member245);  
    			stream_ID.Add(ID20);



    			{
    			// AST REWRITE
    			// elements: TYPE, ID
    			// token labels: 
    			// rule labels: retval
    			// token list labels: 
    			// rule list labels: 
    			// wildcard labels: 
    			retval.Tree = root_0;
    			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

    			root_0 = (object)adaptor.Nil();
    			// 51:12: -> ^( MemberToken TYPE ID )
    			{
    				DebugLocation(51, 15);
    				// C:\\Projects\\lokad-message-contracts-dsl-sample\\Source\\MessageContracts\\MessageContracts.g:51:15: ^( MemberToken TYPE ID )
    				{
    				object root_1 = (object)adaptor.Nil();
    				DebugLocation(51, 17);
    				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(MemberToken, "MemberToken"), root_1);

    				DebugLocation(51, 29);
    				adaptor.AddChild(root_1, stream_TYPE.NextNode());
    				DebugLocation(51, 34);
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
    			// C:\\Projects\\lokad-message-contracts-dsl-sample\\Source\\MessageContracts\\MessageContracts.g:52:4: ID
    			{
    			DebugLocation(52, 4);
    			ID21=(IToken)Match(input,ID,Follow._ID_in_member260);  
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
    			// 52:7: -> ^( FragmentReference ID )
    			{
    				DebugLocation(52, 10);
    				// C:\\Projects\\lokad-message-contracts-dsl-sample\\Source\\MessageContracts\\MessageContracts.g:52:10: ^( FragmentReference ID )
    				{
    				object root_1 = (object)adaptor.Nil();
    				DebugLocation(52, 12);
    				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(FragmentReference, "FragmentReference"), root_1);

    				DebugLocation(52, 30);
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
     	DebugLocation(53, 1);
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
    // C:\\Projects\\lokad-message-contracts-dsl-sample\\Source\\MessageContracts\\MessageContracts.g:56:1: block : lc= '(' ( member ( ',' member )* )? ')' -> ^( BlockToken[$lc,\"Block\"] ( member )* ) ;
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
        RewriteRuleITokenStream stream_24=new RewriteRuleITokenStream(adaptor,"token 24");
        RewriteRuleITokenStream stream_25=new RewriteRuleITokenStream(adaptor,"token 25");
        RewriteRuleITokenStream stream_26=new RewriteRuleITokenStream(adaptor,"token 26");
        RewriteRuleSubtreeStream stream_member=new RewriteRuleSubtreeStream(adaptor,"rule member");
    	try { DebugEnterRule(GrammarFileName, "block");
    	DebugLocation(56, 4);
    	try
    	{
    		// C:\\Projects\\lokad-message-contracts-dsl-sample\\Source\\MessageContracts\\MessageContracts.g:57:5: (lc= '(' ( member ( ',' member )* )? ')' -> ^( BlockToken[$lc,\"Block\"] ( member )* ) )
    		DebugEnterAlt(1);
    		// C:\\Projects\\lokad-message-contracts-dsl-sample\\Source\\MessageContracts\\MessageContracts.g:57:9: lc= '(' ( member ( ',' member )* )? ')'
    		{
    		DebugLocation(57, 11);
    		lc=(IToken)Match(input,24,Follow._24_in_block288);  
    		stream_24.Add(lc);

    		DebugLocation(58, 13);
    		// C:\\Projects\\lokad-message-contracts-dsl-sample\\Source\\MessageContracts\\MessageContracts.g:58:13: ( member ( ',' member )* )?
    		int alt6=2;
    		try { DebugEnterSubRule(6);
    		try { DebugEnterDecision(6, decisionCanBacktrack[6]);
    		int LA6_0 = input.LA(1);

    		if (((LA6_0>=ID && LA6_0<=TYPE)))
    		{
    			alt6=1;
    		}
    		} finally { DebugExitDecision(6); }
    		switch (alt6)
    		{
    		case 1:
    			DebugEnterAlt(1);
    			// C:\\Projects\\lokad-message-contracts-dsl-sample\\Source\\MessageContracts\\MessageContracts.g:58:14: member ( ',' member )*
    			{
    			DebugLocation(58, 14);
    			PushFollow(Follow._member_in_block303);
    			member22=member();
    			PopFollow();

    			stream_member.Add(member22.Tree);
    			DebugLocation(58, 21);
    			// C:\\Projects\\lokad-message-contracts-dsl-sample\\Source\\MessageContracts\\MessageContracts.g:58:21: ( ',' member )*
    			try { DebugEnterSubRule(5);
    			while (true)
    			{
    				int alt5=2;
    				try { DebugEnterDecision(5, decisionCanBacktrack[5]);
    				int LA5_0 = input.LA(1);

    				if ((LA5_0==25))
    				{
    					alt5=1;
    				}


    				} finally { DebugExitDecision(5); }
    				switch ( alt5 )
    				{
    				case 1:
    					DebugEnterAlt(1);
    					// C:\\Projects\\lokad-message-contracts-dsl-sample\\Source\\MessageContracts\\MessageContracts.g:58:22: ',' member
    					{
    					DebugLocation(58, 22);
    					char_literal23=(IToken)Match(input,25,Follow._25_in_block306);  
    					stream_25.Add(char_literal23);

    					DebugLocation(58, 26);
    					PushFollow(Follow._member_in_block308);
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

    		DebugLocation(59, 9);
    		char_literal25=(IToken)Match(input,26,Follow._26_in_block322);  
    		stream_26.Add(char_literal25);



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
    		// 60:9: -> ^( BlockToken[$lc,\"Block\"] ( member )* )
    		{
    			DebugLocation(60, 12);
    			// C:\\Projects\\lokad-message-contracts-dsl-sample\\Source\\MessageContracts\\MessageContracts.g:60:12: ^( BlockToken[$lc,\"Block\"] ( member )* )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(60, 14);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(BlockToken, lc, "Block"), root_1);

    			DebugLocation(60, 38);
    			// C:\\Projects\\lokad-message-contracts-dsl-sample\\Source\\MessageContracts\\MessageContracts.g:60:38: ( member )*
    			while ( stream_member.HasNext )
    			{
    				DebugLocation(60, 38);
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
     	DebugLocation(61, 4);
    	} finally { DebugExitRule(GrammarFileName, "block"); }
    	return retval;

    }
    // $ANTLR end "block"

	#region Follow sets
	private static class Follow
	{
		public static readonly BitSet _declaration_in_program98 = new BitSet(new ulong[]{0x0000000000904002UL});
		public static readonly BitSet _modifier_declaration_in_declaration111 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _frag_declaration_in_declaration116 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _type_declaration_in_declaration121 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _20_in_frag_declaration135 = new BitSet(new ulong[]{0x0000000000004000UL});
		public static readonly BitSet _ID_in_frag_declaration137 = new BitSet(new ulong[]{0x0000000000200000UL});
		public static readonly BitSet _21_in_frag_declaration139 = new BitSet(new ulong[]{0x0000000000008000UL});
		public static readonly BitSet _TYPE_in_frag_declaration141 = new BitSet(new ulong[]{0x0000000000004000UL});
		public static readonly BitSet _ID_in_frag_declaration143 = new BitSet(new ulong[]{0x0000000000400000UL});
		public static readonly BitSet _22_in_frag_declaration145 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _23_in_modifier_declaration177 = new BitSet(new ulong[]{0x0000000000010000UL});
		public static readonly BitSet _Modifier_in_modifier_declaration179 = new BitSet(new ulong[]{0x0000000000200000UL});
		public static readonly BitSet _21_in_modifier_declaration181 = new BitSet(new ulong[]{0x0000000000008000UL});
		public static readonly BitSet _TYPE_in_modifier_declaration183 = new BitSet(new ulong[]{0x0000000000400000UL});
		public static readonly BitSet _22_in_modifier_declaration185 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _ID_in_type_declaration213 = new BitSet(new ulong[]{0x0000000001010000UL});
		public static readonly BitSet _Modifier_in_type_declaration215 = new BitSet(new ulong[]{0x0000000001010000UL});
		public static readonly BitSet _block_in_type_declaration218 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _TYPE_in_member243 = new BitSet(new ulong[]{0x0000000000004000UL});
		public static readonly BitSet _ID_in_member245 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _ID_in_member260 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _24_in_block288 = new BitSet(new ulong[]{0x000000000400C000UL});
		public static readonly BitSet _member_in_block303 = new BitSet(new ulong[]{0x0000000006000000UL});
		public static readonly BitSet _25_in_block306 = new BitSet(new ulong[]{0x000000000000C000UL});
		public static readonly BitSet _member_in_block308 = new BitSet(new ulong[]{0x0000000006000000UL});
		public static readonly BitSet _26_in_block322 = new BitSet(new ulong[]{0x0000000000000002UL});

	}
	#endregion Follow sets
}
}