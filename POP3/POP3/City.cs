using System;

using Newtonsoft.Json;

namespace POP3
{
	public class City : Model<City>, ICity
	{
		private IState state;
		private String name;

		public Guid StateId {
			get { return this.state.Id; }
			set { 
				this.state = Model<State>.GetBy ("Id", value);
			}
		}

		[JsonIgnore]
		public IState State {
			get { return state; }
			set { state = value; }
		}

		public string Name {
			get { return name; }
			set { name = value; }
		}

		public City (String name)
		{
			this.name = name;
		}
	}
}

