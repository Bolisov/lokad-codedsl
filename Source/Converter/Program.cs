using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lokad.CodeDsl;

namespace Converter
{
	class Program
	{
		static void Main(string[] args)
		{

			const string source = @"

let id = Guid Id;

Security			  (id, string path)

let security = Security Security;

let name = string Name;
let rank = int Rank;
let parent = Guid ParentId;


DeleteContext	?(id)
ContextDeleted	!(id)

CreateContext	?(id, name, rank) 
ContextCreated	!(id, name, rank)";

			var generator = new TemplatedGenerator()
				{
					
				};
			Console.WriteLine(GeneratorUtil.Build(source, generator));

			Console.ReadLine();
		}
	}
}
//command BuildBinaryReport 
//{
//  string StorageReference
//}

//contract Security
//{
//  int Test
//}

//event ReportDeleted
//{
//  guid ReportId
//  long SolutionId
//  long AccountId
//  Security Security
//}