using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lokad.CodeDsl;
using NUnit.Framework;

namespace MessageContracts.Tests
{
    [TestFixture]
    public sealed class ClassTests
    {
        // ReSharper disable InconsistentNaming


        [Test]
        public void Test()
        {
             var generator = new TemplatedGenerator()
                                 {
                                     Namespace = "Mine"
                                 };
   
var dsl = @"

let name = string Name;
let security = SecurityDetails Security;
let auth = SecurityRequest Request;


entity ProjectAggregate (Guid ProjectId);
using ? = CommandTo<ProjectId>;
using ! = EventFrom<ProjectId>;




// projects
CreateProject? (name, int Rank, auth)
ProjectCreated! (name, int Rank, security)

RenameProject? (name, auth)
ProjectRenamed! (name, security)

DeleteProject? (auth)
ProjectDeleted! (ref DeleteProject)

entity null ();

DoSomething (name)

";
            var ctx = GeneratorUtil.GenerateContext(dsl);
            Console.WriteLine(GeneratorUtil.Build(ctx, generator));
        }
    }
}
