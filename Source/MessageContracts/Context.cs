using System.Collections.Generic;

namespace Lokad.CodeDsl
{
	public sealed class Context
	{
		public IDictionary<string,Fragment> Fragments = new Dictionary<string, Fragment>();
		public IList<Message> Contracts = new List<Message>();
        //public IDictionary<string,string> Modifiers = new Dictionary<string, string>();

        public Stack<Entity> Entities { get; set; }

        public Entity CurrentEntity { get { return Entities.Peek(); } }

	    public Context()
	    {
            Entities = new Stack<Entity>();
	        var entity = new Entity("default");
            entity.Modifiers.Add("?", "ICommand");
            entity.Modifiers.Add("!", "IEvent");



	        Entities.Push(entity);
	    }
	}

    public sealed class Entity
    {
        public string Name { get; set; }
        public List<Member> FixedMembers { get; set; }
        public List<Message> Messages { get; set; }
        public IDictionary<string, string> Modifiers { get; set; }

        public Entity(string name)
        {
            Name = name;
            FixedMembers = new List<Member>();
            Messages = new List<Message>();
            Modifiers = new Dictionary<string, string>();
        }
        
    }
}