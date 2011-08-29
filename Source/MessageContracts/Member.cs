namespace Lokad.CodeDsl
{
	public sealed class Member
	{
		public readonly string Name;
		public readonly string Type;

		public Member(string type, string name)
		{
			Name = name;
			Type = type;
		}
	}

    
}

