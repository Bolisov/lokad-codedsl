using System.CodeDom.Compiler;
using System.IO;
using System.Text;

namespace Lokad.CodeDsl
{
    public static class GeneratorUtil
    {
        public static string Build(string source, IGenerateCode generator)
        {
            var context = new MessageContractAssembler().From(source);

            var builder = new StringBuilder();
            using (var stream = new StringWriter(builder))
            using (var writer = new IndentedTextWriter(stream, "    "))
            {
                generator.Generate(context, writer);
            }
            return builder.ToString();
        }

        public static string ParameterCase(string s)
        {
            return char.ToLowerInvariant(s[0]) + s.Substring(1);
        }

        public static string MemberCase(string s)
        {
            return char.ToUpperInvariant(s[0]) + s.Substring(1);
        }

        //public static string Extend(this GeneratedTextTransformation )
    }
}