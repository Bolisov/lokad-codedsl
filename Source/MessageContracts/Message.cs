using System.Collections.Generic;

namespace Lokad.CodeDsl
{
	public sealed class Message
	{
		public readonly string Name;
		public readonly IList<Modifier> Modifiers;

		public Message(string name, IList<Modifier> modifiers)
		{
			Name = name;
			Modifiers = modifiers;
		}

		public List<Member> Members = new List<Member>();
	}

    public sealed class Modifier
    {
        public readonly string Identifier;
        public readonly string Interface;

        public Modifier(string identifier, string @interface)
        {
            Identifier = identifier;
            Interface = @interface;
        }
    }
}