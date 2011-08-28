using System;
using ProtoBuf;

namespace Sample 
{
		
	[ProtoContract]
	public sealed class SecurityDetails
	{
		[ProtoMember(1)] public readonly Guid UserId;
		[ProtoMember(2)] public readonly string UserName;
		[ProtoMember(3)] public readonly string Rule;
		private SecurityDetails () {}
		public SecurityDetails (Guid userId, string userName, string rule)
		{
			UserId = userId;
			UserName = userName;
			Rule = rule;
		}
	}
	
	[ProtoContract]
	public sealed class SecurityRequest
	{
		[ProtoMember(1)] public readonly Guid UserId;
		private SecurityRequest () {}
		public SecurityRequest (Guid userId)
		{
			UserId = userId;
		}
	}
	
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
	
	[ProtoContract]
	public sealed class ProjectCreated : IEvent
	{
		[ProtoMember(1)] public readonly Guid ProjectId;
		[ProtoMember(2)] public readonly string Name;
		[ProtoMember(3)] public readonly int Rank;
		[ProtoMember(4)] public readonly SecurityDetails Security;
		private ProjectCreated () {}
		public ProjectCreated (Guid projectId, string name, int rank, SecurityDetails security)
		{
			ProjectId = projectId;
			Name = name;
			Rank = rank;
			Security = security;
		}
	}
	
	[ProtoContract]
	public sealed class RenameProject :  ICommand
	{
		[ProtoMember(1)] public readonly Guid ProjectId;
		[ProtoMember(2)] public readonly string Name;
		[ProtoMember(3)] public readonly SecurityRequest Request;
		private RenameProject () {}
		public RenameProject (Guid projectId, string name, SecurityRequest request)
		{
			ProjectId = projectId;
			Name = name;
			Request = request;
		}
	}
	
	[ProtoContract]
	public sealed class ProjectRenamed : IEvent
	{
		[ProtoMember(1)] public readonly Guid ProjectId;
		[ProtoMember(2)] public readonly string Name;
		[ProtoMember(3)] public readonly SecurityDetails Security;
		private ProjectRenamed () {}
		public ProjectRenamed (Guid projectId, string name, SecurityDetails security)
		{
			ProjectId = projectId;
			Name = name;
			Security = security;
		}
	}
	
	[ProtoContract]
	public sealed class DeleteProject :  ICommand
	{
		[ProtoMember(1)] public readonly Guid ProjectId;
		[ProtoMember(2)] public readonly SecurityRequest Request;
		private DeleteProject () {}
		public DeleteProject (Guid projectId, SecurityRequest request)
		{
			ProjectId = projectId;
			Request = request;
		}
	}
	
	[ProtoContract]
	public sealed class ProjectDeleted : IEvent
	{
		[ProtoMember(1)] public readonly Guid ProjectId;
		[ProtoMember(2)] public readonly SecurityDetails Security;
		private ProjectDeleted () {}
		public ProjectDeleted (Guid projectId, SecurityDetails security)
		{
			ProjectId = projectId;
			Security = security;
		}
	}

}