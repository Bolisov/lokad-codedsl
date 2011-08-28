using System;

namespace Lokad.CodeDsl
{
	static class Errors
	{
		public static Exception InvalidOperation(string format, params object[] args)
		{
			var msg = string.Format(format, args);
			return new InvalidOperationException(msg);
		}
	}
}