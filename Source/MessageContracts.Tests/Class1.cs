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
using ? = CommandTo<ProjectId>;
using ! = EventFrom<ProjectId>;

let projectId=Guid ProjectId;
let name = string Name;
let security = SecurityDetails Security;
let auth = SecurityRequest Request;



// projects
CreateProject? (projectId, name, int Rank, auth)
ProjectCreated! (projectId, name, int Rank, security)

RenameProject? (projectId, name, auth)
ProjectRenamed! (projectId, name, security)

DeleteProject? (projectId, auth)
ProjectDeleted! (ref DeleteProject)

";
            Console.WriteLine(GeneratorUtil.Build(dsl, generator));
        }
    }
}
