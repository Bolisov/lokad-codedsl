using System.CodeDom.Compiler;

namespace Lokad.CodeDsl
{
	public interface IGenerateCode
	{
		void Generate(Context context, IndentedTextWriter writer);
	}
}