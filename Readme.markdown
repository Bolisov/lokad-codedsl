Lokad CodeDSL
=============

Lokad Code DSL Sample (aka Mercenary) is a reference implementation that shows how to streamline .NET contract generation with Visual Studio.

This is useful for reducing development friction on projects that use CQRS, DDD, Event sourcing or rely on any other repetitive code that changes frequently

*This project includes*:

  * *Sample project* that shows how easy it is to use pre-compiled template;
  * *Source code for the template*, should you want to add some other serialization format (only ProtoBuf is currently included);
  * *Source code for the grammar*, should you want to customize or extend the original syntax.

How it does it work?
--------------------

In short everything works like this:

  * Create T4 Template and include DLL  
  * Write DSL
  * Save (hit Ctrl+S) to tell Visual Studio to generate code.

Let's cover these topics!

Create Template
---------------

*First* we copy `MessageContracts.dll` library into "Library" folder within the solution directory (you could change that). Note that you do not have to reference this library anywhere in the project!

*Then*, we add Text Template (Visual C# items -> Text Template) into your Visual Studio solution (make sure that the "!CustomTool" file property is set to "!TextTemplatingFileGenerator").

*Afterwards* we put some boilerplate code into the tt file:

    <#@ template language="C#" #>
    <#@ assembly name="$(SolutionDir)\Library\MessageContracts.dll" #>
    <#@ import namespace="MessageContracts" #>
    using System;
    using ProtoBuf;
    
    namespace Sample 
    {
    <# var generator = new WriteForProtoBufNet();	
    var dsl = @"
    // DSL will go here!!!!
    ";	#>
    <#= GeneratorUtil.Build(dsl, generator) #>
    }

Write DSL
--------

*Finally* we start adding our code, replacing the "// DSL will go here!!!!" part:

    // generic contracts
    SecurityDetails(Guid UserId, string UserName, string Rule)
    SecurityRequest(Guid UserId)
    
    // common fragments
    let projectId = Guid ProjectId;
    let name = string Name;
    let security = SecurityDetails Security;
    let auth = SecurityRequest Request;
    
    // projects
    CreateProject? (projectId, name, int Rank, auth)
    ProjectCreated! (projectId, name, int Rank, security)
    
    RenameProject? (projectId, name, auth)
    ProjectRenamed! (projectId, name, security)
    
    DeleteProject? (projectId, auth)
    ProjectDeleted! (projectId, security)

Ctrl-S to generate code!
------------------------

Whenever you save the template file, corresponding C# file will be refreshed with the contract file definitions.

For example, these are equivalents for [ProtoBuf-net serialization](http://code.google.com/p/protobuf-net/) (which is really efficient and fast serialization format for .NET that [outperforms even Binary Serialization](http://abdullin.com/journal/2010/7/24/lokad-cqrs-using-protocol-buffers-serialization-for-azure-me.html). 


DSL:

    CreateProject? (projectId, name, int Rank, auth)

C#:

    [ProtoContract]
    public sealed class CreateProject :  ICommand
    {
      [ProtoMember(1)] public readonly Guid ProjectId;
      [ProtoMember(2)] public readonly string Name;
      [ProtoMember(3)] public readonly int Rank;
      [ProtoMember(4)] public readonly SecurityRequest Request;
      private CreateProject () {}
      public CreateProject (Guid projectId, string name, int rank, SecurityRequest request)
      {
        ProjectId = projectId;
        Name = name;
        Rank = rank;
        Request = request;
      }
    }

I want more!
------------

Great! If you like this project, then you might be interested in my blog, where [I write about efficient development](http://abdullin.com/) (mostly focusing on .NET with a bit of cloud and other platforms, where it makes sense). 

There actually is an article that goes into the deeper detail about this approach ([http://abdullin.com/journal/2010/10/12/teach-visual-studio-your-own-language-easy.html](Teach Visual Studio Your Own Language - Easy)). Also, this sample project is a part of series about [xLim 4: CQRS in the Cloud](http://abdullin.com/xlim/ ) (where CQRS stands for Command-Query Responsibility Segregation which allows to build really flexible and scalable applications). There might be some more materials on the subject by now.

==Feedback==

Please, feel free to drop feedback in the [Lokad Community](https://groups.google.com/forum/#!forum/lokad).
