﻿using System;
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
	    static IEnumerable<Member> WalkContractMember(ITree tree, Context context)
		{
			if (tree.Type == MessageContractsLexer.FragmentReference)
			{
				var fragmentId = tree.GetChild(0).Text;

				if (!context.Fragments.ContainsKey(fragmentId))
				{
					throw Errors.InvalidOperation("Unknown fragment '{0}'", fragmentId);
				}

				var fragment = context.Fragments[fragmentId];
				yield return new Member(fragment.Type, fragment.Name);
				yield break;
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
                            yield return  member;
                        }
                        yield break;
                    }
                    throw Errors.InvalidOperation("Unknown include '{0}'", name);
                }
			    yield return (new Member(type, name));
                yield break;
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
			        context.CurrentEntity.Modifiers[modifier] = type;
			        break;


				case MessageContractsLexer.TypeToken:
					var name = t.GetChild(0).Text;
					var block = t.GetChild(1);

			        var modifiers = new List<Modifier>();
					if (t.ChildCount>2)
					{
						var mod = t.GetChild(2).Text;
					    string typeName;
					    if (!context.CurrentEntity.Modifiers.TryGetValue(mod, out typeName))
					    {
					        var format = string.Format("Entity '{0}' does not have modifier reference: '{1}'", context.CurrentEntity.Name, mod);
					        throw new InvalidOperationException(format);
					    }
					    modifiers.Add(new Modifier(mod, typeName));
					}

					var message = new Message(name, modifiers);
                    if (modifiers.Any())
                    {
                        // only commands and events have modifiers
                        foreach (var member in context.Entities.Peek().FixedMembers)
                        {
                            message.Members.Add(member);
                        }
                    }
			        
					for (int i = 0; i < block.ChildCount; i++)
					{
                        message.Members.AddRange(WalkContractMember(block.GetChild(i), context));
					}

                    context.Contracts.Add(message);
                    context.CurrentEntity.Messages.Add(message);


					break;

                case MessageContractsLexer.EntityDefinition:
                    var entityName = t.GetChild(0).Text;
					var entityBlock = t.GetChild(1);

                    
                    var entity = new Entity(entityName);
					for (int i = 0; i < entityBlock.ChildCount; i++)
					{
                        entity.FixedMembers.AddRange(WalkContractMember(entityBlock.GetChild(i), context));
					}

                    context.Entities.Push(entity);

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