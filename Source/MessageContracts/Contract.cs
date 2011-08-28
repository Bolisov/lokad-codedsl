using System.Collections.Generic;

namespace Lokad.CodeDsl
{
	public sealed class Contract
	{
		public readonly string Name;
		public readonly IList<string> Modifiers;

		public Contract(string name, IList<string> modifiers)
		{
			Name = name;
			Modifiers = modifiers;
		}

		public IList<Member> Members = new List<Member>();
	}
}