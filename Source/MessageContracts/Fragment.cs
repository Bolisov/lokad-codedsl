namespace Lokad.CodeDsl
{
	public sealed class Fragment
	{
		public readonly string Type;
		public readonly string Name;

		public Fragment(string type, string name)
		{
			Type = type;
			Name = name;
		}
	}
}