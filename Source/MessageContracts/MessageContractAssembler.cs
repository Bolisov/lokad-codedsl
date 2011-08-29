using System;
using System.Collections.Generic;
using System.IO;
using Antlr.Runtime;
using Antlr.Runtime.Tree;
using System.Linq;
using MessageContracts;

namespace Lokad.CodeDsl
{
	public sealed class MessageContractAssembler
	{
	    static void WalkContractMember(ITree tree, Context context, Contract contract)
		{
			if (tree.Type == MessageContractsLexer.FragmentReference)
			{
				var fragmentId = tree.GetChild(0).Text;

				if (!context.Fragments.ContainsKey(fragmentId))
				{
					throw Errors.InvalidOperation("Unknown fragment '{0}'", fragmentId);
				}

				var fragment = context.Fragments[fragmentId];
				contract.Members.Add(new Member(fragment.Type, fragment.Name));
				return;
			}
			if (tree.Type == MessageContractsLexer.MemberToken)
			{
			    var type = tree.GetChild(0).Text;
			    var name = tree.GetChild(1).Text;
                if (type == "ref")
                {
                    var match = context.Contracts.Where(c => c.Name == name).ToArray();
                    if (match.Length == 1)
                    {
                        foreach (var member in match[0].Members)
                        {
                            contract.Members.Add(member);
                        }
                        return;
                    }
                    throw Errors.InvalidOperation("Unknown include '{0}'", name);
                }
			    contract.Members.Add(new Member(type, name));

			    return;
			}
			throw new InvalidOperationException("Unexpected token: " + tree.Text);
		}

		public void WalkDeclarations(object tree, Context context)
		{
			var t = (CommonTree)tree;
			switch (t.Type)
			{
				case MessageContractsLexer.FragmentEntry:
					var fragmentId = t.GetChild(0).Text;
					var fragmentType = t.GetChild(1).Text;
					var fragmentName = t.GetChild(2).Text;
					context.Fragments[fragmentId] = new Fragment(fragmentType, fragmentName);
					break;
                case MessageContractsLexer.ModifierDefinition:
                    Console.WriteLine(t);

			        var modifier = t.GetChild(1).Text;
			        var type = t.GetChild(0).Text;
			        context.Modifiers[modifier] = type;
			        break;


				case MessageContractsLexer.TypeToken:
					var name = t.GetChild(0).Text;
					var block = t.GetChild(1);

			        var modifiers = new List<string>();
					if (t.ChildCount>2)
					{
						var mod = t.GetChild(2).Text;
					    string typeName;
					    if (!context.Modifiers.TryGetValue(mod, out typeName))
					    {
					        throw new InvalidOperationException("Unknown modifier reference: " + mod);
					    }
					    modifiers.Add(typeName);
					}

					var contract = new Contract(name, modifiers);
					for (int i = 0; i < block.ChildCount; i++)
					{
						WalkContractMember(block.GetChild(i), context, contract);
					}

                    if (contract.Name == "fixed")
                    {
                        context.Fixed.Clear();
                        context.Fixed.AddRange(contract.Members);
                    }
                    else
                    {
                        foreach (var member in ((IEnumerable<Member>)context.Fixed).Reverse())
                        {
                            contract.Members.Insert(0,member);
                        }
                        context.Contracts.Add(contract);
                    }

					break;
				default:
					throw new InvalidOperationException("Unexpected token: " + t.Text);
			}
		}

		public Context From(string source)
		{
			var stream = new ANTLRStringStream(source);
			var lexer = new MessageContractsLexer(stream);

			var tokens = new CommonTokenStream(lexer);

			var parser = new MessageContractsParser(tokens);
            
			var program = parser.GetProgram();

			var commonTree = (CommonTree)program.Tree;

		    var node = commonTree as CommonErrorNode;

		    if (node != null)
		    {
                
		        throw new InvalidOperationException(node.ToString());
		    }


			var ctx = new Context();
			foreach (var child in commonTree.Children)
			{
				WalkDeclarations(child, ctx);
			}
			return ctx;
		}
	}

}

namespace MessageContracts
{
    public partial class MessageContractsParser
    {
        public program_return GetProgram()
        {
            return program();
        }
    }

    public partial class MessageContractsLexer
    {
        public const int HIDDEN = Hidden;
    }
}