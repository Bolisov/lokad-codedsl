using System;
using System.Linq;
using System.Reflection;

namespace Sample
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(
				@"
Mercenary Sample
----------------

This is sample of streamlined contract generator in action. Stop the console and try editing 'contracts.tt' to force Visual Studio to regenerate C# contracts files.

Best works with the latest ReSharper (and solution-wide analysis), Autotest.NET or any equivalent. They will pick up changes without recomipling code in Visual Studio!

See http://abdullin.com/on/mercenary for additional details.

PS: New BSD license (c) 2010 Lokad, Rinat Abdullin (basically, do what you want license)

Press any key to continue...
");

			Console.ReadKey(true);


			var types = Assembly
				.GetExecutingAssembly()
				.GetExportedTypes()
				.Where(t => typeof (IMessage).IsAssignableFrom(t))
				.Where(t => !t.IsAbstract);

			foreach (var type in types)
			{
				Console.WriteLine(type.Name);

				foreach (var member in type.GetFields())
				{
					Console.WriteLine("  {0}: {1}", member.FieldType.Name, member.Name);
				}
				foreach (var member in type.GetProperties())
				{
					Console.WriteLine("  {0}: {1}", member.PropertyType.Name, member.Name);
				}
				Console.WriteLine();
			}


			Console.WriteLine("Press any key to close");
			Console.ReadKey(true);
		}
	}

	public interface IMessage
	{
	}

	public interface ICommand : IMessage
	{
	}

	public interface IEvent : IMessage
	{
	}
}