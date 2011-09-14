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


using Antlr.Runtime.Tree;
using RewriteRuleITokenStream = Antlr.Runtime.Tree.RewriteRuleTokenStream;

namespace  MessageContracts 
{
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "3.3 Nov 30, 2010 12:45:30")]
[System.CLSCompliant(false)]
public partial class MessageContractsParser : Antlr.Runtime.Parser
{
	internal static readonly string[] tokenNames = new string[] {
		"<invalid>", "<EOR>", "<DOWN>", "<UP>", "TypeToken", "CommandToken", "EventToken", "MemberToken", "BlockToken", "DisctionaryToken", "FragmentGroup", "FragmentEntry", "FragmentReference", "ModifierDefinition", "EntityDefinition", "LET", "ID", "USING", "Modifier", "ENTITY", "INT", "COMMENT", "WS", "'='", "';'", "'('", "','", "')'"
	};
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

    			if (((LA1_0>=LET && LA1_0<=USING)||LA1_0==ENTITY))
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
    				PushFollow(Follow._declaration_in_program101);
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
    // C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:31:1: declaration : ( modifier_declaration | frag_declaration | type_declaration | entity_declaration );
    [GrammarRule("declaration")]
    private MessageContractsParser.declaration_return declaration()
    {

        MessageContractsParser.declaration_return retval = new MessageContractsParser.declaration_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        MessageContractsParser.modifier_declaration_return modifier_declaration2 = default(MessageContractsParser.modifier_declaration_return);
        MessageContractsParser.frag_declaration_return frag_declaration3 = default(MessageContractsParser.frag_declaration_return);
        MessageContractsParser.type_declaration_return type_declaration4 = default(MessageContractsParser.type_declaration_return);
        MessageContractsParser.entity_declaration_return entity_declaration5 = default(MessageContractsParser.entity_declaration_return);


    	try { DebugEnterRule(GrammarFileName, "declaration");
    	DebugLocation(31, 1);
    	try
    	{
    		// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:32:2: ( modifier_declaration | frag_declaration | type_declaration | entity_declaration )
    		int alt2=4;
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
    		case ENTITY:
    			{
    			alt2=4;
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
    			PushFollow(Follow._modifier_declaration_in_declaration114);
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
    			PushFollow(Follow._frag_declaration_in_declaration119);
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
    			PushFollow(Follow._type_declaration_in_declaration124);
    			type_declaration4=type_declaration();
    			PopFollow();

    			adaptor.AddChild(root_0, type_declaration4.Tree);

    			}
    			break;
    		case 4:
    			DebugEnterAlt(4);
    			// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:35:4: entity_declaration
    			{
    			root_0 = (object)adaptor.Nil();

    			DebugLocation(35, 4);
    			PushFollow(Follow._entity_declaration_in_declaration129);
    			entity_declaration5=entity_declaration();
    			PopFollow();

    			adaptor.AddChild(root_0, entity_declaration5.Tree);

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
     	DebugLocation(36, 1);
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
    // C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:38:1: frag_declaration : LET ID '=' ID ID ';' -> ^( FragmentEntry ID ID ID ) ;
    [GrammarRule("frag_declaration")]
    private MessageContractsParser.frag_declaration_return frag_declaration()
    {

        MessageContractsParser.frag_declaration_return retval = new MessageContractsParser.frag_declaration_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken LET6=null;
        IToken ID7=null;
        IToken char_literal8=null;
        IToken ID9=null;
        IToken ID10=null;
        IToken char_literal11=null;

        object LET6_tree=null;
        object ID7_tree=null;
        object char_literal8_tree=null;
        object ID9_tree=null;
        object ID10_tree=null;
        object char_literal11_tree=null;
        RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
        RewriteRuleITokenStream stream_23=new RewriteRuleITokenStream(adaptor,"token 23");
        RewriteRuleITokenStream stream_24=new RewriteRuleITokenStream(adaptor,"token 24");
        RewriteRuleITokenStream stream_LET=new RewriteRuleITokenStream(adaptor,"token LET");

    	try { DebugEnterRule(GrammarFileName, "frag_declaration");
    	DebugLocation(38, 52);
    	try
    	{
    		// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:39:2: ( LET ID '=' ID ID ';' -> ^( FragmentEntry ID ID ID ) )
    		DebugEnterAlt(1);
    		// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:39:4: LET ID '=' ID ID ';'
    		{
    		DebugLocation(39, 4);
    		LET6=(IToken)Match(input,LET,Follow._LET_in_frag_declaration141);  
    		stream_LET.Add(LET6);

    		DebugLocation(39, 8);
    		ID7=(IToken)Match(input,ID,Follow._ID_in_frag_declaration143);  
    		stream_ID.Add(ID7);

    		DebugLocation(39, 11);
    		char_literal8=(IToken)Match(input,23,Follow._23_in_frag_declaration145);  
    		stream_23.Add(char_literal8);

    		DebugLocation(39, 15);
    		ID9=(IToken)Match(input,ID,Follow._ID_in_frag_declaration147);  
    		stream_ID.Add(ID9);

    		DebugLocation(39, 18);
    		ID10=(IToken)Match(input,ID,Follow._ID_in_frag_declaration149);  
    		stream_ID.Add(ID10);

    		DebugLocation(39, 21);
    		char_literal11=(IToken)Match(input,24,Follow._24_in_frag_declaration151);  
    		stream_24.Add(char_literal11);



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
    		// 39:25: -> ^( FragmentEntry ID ID ID )
    		{
    			DebugLocation(39, 28);
    			// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:39:28: ^( FragmentEntry ID ID ID )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(39, 30);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(FragmentEntry, "FragmentEntry"), root_1);

    			DebugLocation(39, 44);
    			adaptor.AddChild(root_1, stream_ID.NextNode());
    			DebugLocation(39, 47);
    			adaptor.AddChild(root_1, stream_ID.NextNode());
    			DebugLocation(39, 50);
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
     	DebugLocation(39, 52);
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
    // C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:41:1: modifier_declaration : USING Modifier '=' ID ';' -> ^( ModifierDefinition ID Modifier ) ;
    [GrammarRule("modifier_declaration")]
    private MessageContractsParser.modifier_declaration_return modifier_declaration()
    {

        MessageContractsParser.modifier_declaration_return retval = new MessageContractsParser.modifier_declaration_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken USING12=null;
        IToken Modifier13=null;
        IToken char_literal14=null;
        IToken ID15=null;
        IToken char_literal16=null;

        object USING12_tree=null;
        object Modifier13_tree=null;
        object char_literal14_tree=null;
        object ID15_tree=null;
        object char_literal16_tree=null;
        RewriteRuleITokenStream stream_USING=new RewriteRuleITokenStream(adaptor,"token USING");
        RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
        RewriteRuleITokenStream stream_23=new RewriteRuleITokenStream(adaptor,"token 23");
        RewriteRuleITokenStream stream_Modifier=new RewriteRuleITokenStream(adaptor,"token Modifier");
        RewriteRuleITokenStream stream_24=new RewriteRuleITokenStream(adaptor,"token 24");

    	try { DebugEnterRule(GrammarFileName, "modifier_declaration");
    	DebugLocation(41, 65);
    	try
    	{
    		// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:42:2: ( USING Modifier '=' ID ';' -> ^( ModifierDefinition ID Modifier ) )
    		DebugEnterAlt(1);
    		// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:42:4: USING Modifier '=' ID ';'
    		{
    		DebugLocation(42, 4);
    		USING12=(IToken)Match(input,USING,Follow._USING_in_modifier_declaration178);  
    		stream_USING.Add(USING12);

    		DebugLocation(42, 10);
    		Modifier13=(IToken)Match(input,Modifier,Follow._Modifier_in_modifier_declaration180);  
    		stream_Modifier.Add(Modifier13);

    		DebugLocation(42, 19);
    		char_literal14=(IToken)Match(input,23,Follow._23_in_modifier_declaration182);  
    		stream_23.Add(char_literal14);

    		DebugLocation(42, 23);
    		ID15=(IToken)Match(input,ID,Follow._ID_in_modifier_declaration184);  
    		stream_ID.Add(ID15);

    		DebugLocation(42, 26);
    		char_literal16=(IToken)Match(input,24,Follow._24_in_modifier_declaration186);  
    		stream_24.Add(char_literal16);



    		{
    		// AST REWRITE
    		// elements: Modifier, ID
    		// token labels: 
    		// rule labels: retval
    		// token list labels: 
    		// rule list labels: 
    		// wildcard labels: 
    		retval.Tree = root_0;
    		RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

    		root_0 = (object)adaptor.Nil();
    		// 42:30: -> ^( ModifierDefinition ID Modifier )
    		{
    			DebugLocation(42, 33);
    			// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:42:33: ^( ModifierDefinition ID Modifier )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(42, 35);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ModifierDefinition, "ModifierDefinition"), root_1);

    			DebugLocation(42, 54);
    			adaptor.AddChild(root_1, stream_ID.NextNode());
    			DebugLocation(42, 57);
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
     	DebugLocation(42, 65);
    	} finally { DebugExitRule(GrammarFileName, "modifier_declaration"); }
    	return retval;

    }
    // $ANTLR end "modifier_declaration"

    public class entity_declaration_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_entity_declaration() {}
    protected virtual void Leave_entity_declaration() {}

    // $ANTLR start "entity_declaration"
    // C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:45:1: entity_declaration : ENTITY ID block ';' -> ^( EntityDefinition ID block ) ;
    [GrammarRule("entity_declaration")]
    private MessageContractsParser.entity_declaration_return entity_declaration()
    {

        MessageContractsParser.entity_declaration_return retval = new MessageContractsParser.entity_declaration_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken ENTITY17=null;
        IToken ID18=null;
        IToken char_literal20=null;
        MessageContractsParser.block_return block19 = default(MessageContractsParser.block_return);

        object ENTITY17_tree=null;
        object ID18_tree=null;
        object char_literal20_tree=null;
        RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
        RewriteRuleITokenStream stream_24=new RewriteRuleITokenStream(adaptor,"token 24");
        RewriteRuleITokenStream stream_ENTITY=new RewriteRuleITokenStream(adaptor,"token ENTITY");
        RewriteRuleSubtreeStream stream_block=new RewriteRuleSubtreeStream(adaptor,"rule block");
    	try { DebugEnterRule(GrammarFileName, "entity_declaration");
    	DebugLocation(45, 54);
    	try
    	{
    		// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:46:2: ( ENTITY ID block ';' -> ^( EntityDefinition ID block ) )
    		DebugEnterAlt(1);
    		// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:46:4: ENTITY ID block ';'
    		{
    		DebugLocation(46, 4);
    		ENTITY17=(IToken)Match(input,ENTITY,Follow._ENTITY_in_entity_declaration211);  
    		stream_ENTITY.Add(ENTITY17);

    		DebugLocation(46, 11);
    		ID18=(IToken)Match(input,ID,Follow._ID_in_entity_declaration213);  
    		stream_ID.Add(ID18);

    		DebugLocation(46, 14);
    		PushFollow(Follow._block_in_entity_declaration215);
    		block19=block();
    		PopFollow();

    		stream_block.Add(block19.Tree);
    		DebugLocation(46, 20);
    		char_literal20=(IToken)Match(input,24,Follow._24_in_entity_declaration217);  
    		stream_24.Add(char_literal20);



    		{
    		// AST REWRITE
    		// elements: block, ID
    		// token labels: 
    		// rule labels: retval
    		// token list labels: 
    		// rule list labels: 
    		// wildcard labels: 
    		retval.Tree = root_0;
    		RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

    		root_0 = (object)adaptor.Nil();
    		// 46:24: -> ^( EntityDefinition ID block )
    		{
    			DebugLocation(46, 27);
    			// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:46:27: ^( EntityDefinition ID block )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(46, 29);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(EntityDefinition, "EntityDefinition"), root_1);

    			DebugLocation(46, 46);
    			adaptor.AddChild(root_1, stream_ID.NextNode());
    			DebugLocation(46, 49);
    			adaptor.AddChild(root_1, stream_block.NextTree());

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
     	DebugLocation(46, 54);
    	} finally { DebugExitRule(GrammarFileName, "entity_declaration"); }
    	return retval;

    }
    // $ANTLR end "entity_declaration"

    public class type_declaration_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
    {
    	private object _tree;
    	public object Tree { get { return _tree; } set { _tree = value; } }
    }

    protected virtual void Enter_type_declaration() {}
    protected virtual void Leave_type_declaration() {}

    // $ANTLR start "type_declaration"
    // C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:48:1: type_declaration : ID ( Modifier )? block -> ^( TypeToken ID block ( Modifier )? ) ;
    [GrammarRule("type_declaration")]
    private MessageContractsParser.type_declaration_return type_declaration()
    {

        MessageContractsParser.type_declaration_return retval = new MessageContractsParser.type_declaration_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken ID21=null;
        IToken Modifier22=null;
        MessageContractsParser.block_return block23 = default(MessageContractsParser.block_return);

        object ID21_tree=null;
        object Modifier22_tree=null;
        RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");
        RewriteRuleITokenStream stream_Modifier=new RewriteRuleITokenStream(adaptor,"token Modifier");
        RewriteRuleSubtreeStream stream_block=new RewriteRuleSubtreeStream(adaptor,"rule block");
    	try { DebugEnterRule(GrammarFileName, "type_declaration");
    	DebugLocation(48, 56);
    	try
    	{
    		// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:49:2: ( ID ( Modifier )? block -> ^( TypeToken ID block ( Modifier )? ) )
    		DebugEnterAlt(1);
    		// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:49:4: ID ( Modifier )? block
    		{
    		DebugLocation(49, 4);
    		ID21=(IToken)Match(input,ID,Follow._ID_in_type_declaration237);  
    		stream_ID.Add(ID21);

    		DebugLocation(49, 7);
    		// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:49:7: ( Modifier )?
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
    			// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:49:7: Modifier
    			{
    			DebugLocation(49, 7);
    			Modifier22=(IToken)Match(input,Modifier,Follow._Modifier_in_type_declaration239);  
    			stream_Modifier.Add(Modifier22);


    			}
    			break;

    		}
    		} finally { DebugExitSubRule(3); }

    		DebugLocation(49, 17);
    		PushFollow(Follow._block_in_type_declaration242);
    		block23=block();
    		PopFollow();

    		stream_block.Add(block23.Tree);


    		{
    		// AST REWRITE
    		// elements: block, Modifier, ID
    		// token labels: 
    		// rule labels: retval
    		// token list labels: 
    		// rule list labels: 
    		// wildcard labels: 
    		retval.Tree = root_0;
    		RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

    		root_0 = (object)adaptor.Nil();
    		// 49:23: -> ^( TypeToken ID block ( Modifier )? )
    		{
    			DebugLocation(49, 26);
    			// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:49:26: ^( TypeToken ID block ( Modifier )? )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(49, 28);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(TypeToken, "TypeToken"), root_1);

    			DebugLocation(49, 38);
    			adaptor.AddChild(root_1, stream_ID.NextNode());
    			DebugLocation(49, 41);
    			adaptor.AddChild(root_1, stream_block.NextTree());
    			DebugLocation(49, 47);
    			// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:49:47: ( Modifier )?
    			if ( stream_Modifier.HasNext )
    			{
    				DebugLocation(49, 47);
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
     	DebugLocation(49, 56);
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
    // C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:51:1: member : ( ID ID -> ^( MemberToken ID ID ) | ID -> ^( FragmentReference ID ) );
    [GrammarRule("member")]
    private MessageContractsParser.member_return member()
    {

        MessageContractsParser.member_return retval = new MessageContractsParser.member_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken ID24=null;
        IToken ID25=null;
        IToken ID26=null;

        object ID24_tree=null;
        object ID25_tree=null;
        object ID26_tree=null;
        RewriteRuleITokenStream stream_ID=new RewriteRuleITokenStream(adaptor,"token ID");

    	try { DebugEnterRule(GrammarFileName, "member");
    	DebugLocation(51, 1);
    	try
    	{
    		// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:52:2: ( ID ID -> ^( MemberToken ID ID ) | ID -> ^( FragmentReference ID ) )
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
    			else if (((LA4_1>=26 && LA4_1<=27)))
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
    			// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:52:4: ID ID
    			{
    			DebugLocation(52, 4);
    			ID24=(IToken)Match(input,ID,Follow._ID_in_member267);  
    			stream_ID.Add(ID24);

    			DebugLocation(52, 7);
    			ID25=(IToken)Match(input,ID,Follow._ID_in_member269);  
    			stream_ID.Add(ID25);



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
    			// 52:10: -> ^( MemberToken ID ID )
    			{
    				DebugLocation(52, 13);
    				// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:52:13: ^( MemberToken ID ID )
    				{
    				object root_1 = (object)adaptor.Nil();
    				DebugLocation(52, 15);
    				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(MemberToken, "MemberToken"), root_1);

    				DebugLocation(52, 27);
    				adaptor.AddChild(root_1, stream_ID.NextNode());
    				DebugLocation(52, 30);
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
    			// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:53:4: ID
    			{
    			DebugLocation(53, 4);
    			ID26=(IToken)Match(input,ID,Follow._ID_in_member284);  
    			stream_ID.Add(ID26);



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
    			// 53:7: -> ^( FragmentReference ID )
    			{
    				DebugLocation(53, 10);
    				// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:53:10: ^( FragmentReference ID )
    				{
    				object root_1 = (object)adaptor.Nil();
    				DebugLocation(53, 12);
    				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(FragmentReference, "FragmentReference"), root_1);

    				DebugLocation(53, 30);
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
     	DebugLocation(54, 1);
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
    // C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:57:1: block : lc= '(' ( member ( ',' member )* )? ')' -> ^( BlockToken[$lc,\"Block\"] ( member )* ) ;
    [GrammarRule("block")]
    private MessageContractsParser.block_return block()
    {

        MessageContractsParser.block_return retval = new MessageContractsParser.block_return();
        retval.Start = (IToken)input.LT(1);

        object root_0 = null;

        IToken lc=null;
        IToken char_literal28=null;
        IToken char_literal30=null;
        MessageContractsParser.member_return member27 = default(MessageContractsParser.member_return);
        MessageContractsParser.member_return member29 = default(MessageContractsParser.member_return);

        object lc_tree=null;
        object char_literal28_tree=null;
        object char_literal30_tree=null;
        RewriteRuleITokenStream stream_25=new RewriteRuleITokenStream(adaptor,"token 25");
        RewriteRuleITokenStream stream_26=new RewriteRuleITokenStream(adaptor,"token 26");
        RewriteRuleITokenStream stream_27=new RewriteRuleITokenStream(adaptor,"token 27");
        RewriteRuleSubtreeStream stream_member=new RewriteRuleSubtreeStream(adaptor,"rule member");
    	try { DebugEnterRule(GrammarFileName, "block");
    	DebugLocation(57, 4);
    	try
    	{
    		// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:58:5: (lc= '(' ( member ( ',' member )* )? ')' -> ^( BlockToken[$lc,\"Block\"] ( member )* ) )
    		DebugEnterAlt(1);
    		// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:58:9: lc= '(' ( member ( ',' member )* )? ')'
    		{
    		DebugLocation(58, 11);
    		lc=(IToken)Match(input,25,Follow._25_in_block312);  
    		stream_25.Add(lc);

    		DebugLocation(59, 13);
    		// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:59:13: ( member ( ',' member )* )?
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
    			// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:59:14: member ( ',' member )*
    			{
    			DebugLocation(59, 14);
    			PushFollow(Follow._member_in_block327);
    			member27=member();
    			PopFollow();

    			stream_member.Add(member27.Tree);
    			DebugLocation(59, 21);
    			// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:59:21: ( ',' member )*
    			try { DebugEnterSubRule(5);
    			while (true)
    			{
    				int alt5=2;
    				try { DebugEnterDecision(5, decisionCanBacktrack[5]);
    				int LA5_0 = input.LA(1);

    				if ((LA5_0==26))
    				{
    					alt5=1;
    				}


    				} finally { DebugExitDecision(5); }
    				switch ( alt5 )
    				{
    				case 1:
    					DebugEnterAlt(1);
    					// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:59:22: ',' member
    					{
    					DebugLocation(59, 22);
    					char_literal28=(IToken)Match(input,26,Follow._26_in_block330);  
    					stream_26.Add(char_literal28);

    					DebugLocation(59, 26);
    					PushFollow(Follow._member_in_block332);
    					member29=member();
    					PopFollow();

    					stream_member.Add(member29.Tree);

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

    		DebugLocation(60, 9);
    		char_literal30=(IToken)Match(input,27,Follow._27_in_block346);  
    		stream_27.Add(char_literal30);



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
    		// 61:9: -> ^( BlockToken[$lc,\"Block\"] ( member )* )
    		{
    			DebugLocation(61, 12);
    			// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:61:12: ^( BlockToken[$lc,\"Block\"] ( member )* )
    			{
    			object root_1 = (object)adaptor.Nil();
    			DebugLocation(61, 14);
    			root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(BlockToken, lc, "Block"), root_1);

    			DebugLocation(61, 38);
    			// C:\\Projects\\lokad-codedsl\\Source\\MessageContracts\\MessageContracts.g:61:38: ( member )*
    			while ( stream_member.HasNext )
    			{
    				DebugLocation(61, 38);
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
     	DebugLocation(62, 4);
    	} finally { DebugExitRule(GrammarFileName, "block"); }
    	return retval;

    }
    // $ANTLR end "block"

	#region Follow sets
	private static class Follow
	{
		public static readonly BitSet _declaration_in_program101 = new BitSet(new ulong[]{0x00000000000B8002UL});
		public static readonly BitSet _modifier_declaration_in_declaration114 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _frag_declaration_in_declaration119 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _type_declaration_in_declaration124 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _entity_declaration_in_declaration129 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _LET_in_frag_declaration141 = new BitSet(new ulong[]{0x0000000000010000UL});
		public static readonly BitSet _ID_in_frag_declaration143 = new BitSet(new ulong[]{0x0000000000800000UL});
		public static readonly BitSet _23_in_frag_declaration145 = new BitSet(new ulong[]{0x0000000000010000UL});
		public static readonly BitSet _ID_in_frag_declaration147 = new BitSet(new ulong[]{0x0000000000010000UL});
		public static readonly BitSet _ID_in_frag_declaration149 = new BitSet(new ulong[]{0x0000000001000000UL});
		public static readonly BitSet _24_in_frag_declaration151 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _USING_in_modifier_declaration178 = new BitSet(new ulong[]{0x0000000000040000UL});
		public static readonly BitSet _Modifier_in_modifier_declaration180 = new BitSet(new ulong[]{0x0000000000800000UL});
		public static readonly BitSet _23_in_modifier_declaration182 = new BitSet(new ulong[]{0x0000000000010000UL});
		public static readonly BitSet _ID_in_modifier_declaration184 = new BitSet(new ulong[]{0x0000000001000000UL});
		public static readonly BitSet _24_in_modifier_declaration186 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _ENTITY_in_entity_declaration211 = new BitSet(new ulong[]{0x0000000000010000UL});
		public static readonly BitSet _ID_in_entity_declaration213 = new BitSet(new ulong[]{0x0000000002000000UL});
		public static readonly BitSet _block_in_entity_declaration215 = new BitSet(new ulong[]{0x0000000001000000UL});
		public static readonly BitSet _24_in_entity_declaration217 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _ID_in_type_declaration237 = new BitSet(new ulong[]{0x0000000002040000UL});
		public static readonly BitSet _Modifier_in_type_declaration239 = new BitSet(new ulong[]{0x0000000002000000UL});
		public static readonly BitSet _block_in_type_declaration242 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _ID_in_member267 = new BitSet(new ulong[]{0x0000000000010000UL});
		public static readonly BitSet _ID_in_member269 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _ID_in_member284 = new BitSet(new ulong[]{0x0000000000000002UL});
		public static readonly BitSet _25_in_block312 = new BitSet(new ulong[]{0x0000000008010000UL});
		public static readonly BitSet _member_in_block327 = new BitSet(new ulong[]{0x000000000C000000UL});
		public static readonly BitSet _26_in_block330 = new BitSet(new ulong[]{0x0000000000010000UL});
		public static readonly BitSet _member_in_block332 = new BitSet(new ulong[]{0x000000000C000000UL});
		public static readonly BitSet _27_in_block346 = new BitSet(new ulong[]{0x0000000000000002UL});

	}
	#endregion Follow sets
}
}