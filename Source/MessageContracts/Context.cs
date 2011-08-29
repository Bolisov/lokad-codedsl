using System.Collections.Generic;

namespace Lokad.CodeDsl
{
	public sealed class Context
	{
		public IDictionary<string,Fragment> Fragments = new Dictionary<string, Fragment>();
		public IList<Contract> Contracts = new List<Contract>();
        public IDictionary<string,string> Modifiers = new Dictionary<string, string>();

        public List<Member> Fixed { get; set; }

	    public Context()
	    {
            Modifiers.Add("?", "ICommand");
            Modifiers.Add("!", "IEvent");

            Fixed = new List<Member>();
	    }
	}
}