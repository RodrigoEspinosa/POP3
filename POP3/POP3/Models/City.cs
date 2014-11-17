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

		public City (String name, IState state)
		{
			this.name = name;
            this.State = state;
		}

        public static City GetOrCreate(String name, IState state)
        {
            // Filter all the cities by his name.
            foreach (City city in City.FilterBy("Name", name))
            {
                // Check if the state has the same country.
                if (city.state.Equals(state))
                {
                    // Return the current city.
                    return city;
                }
            }

            // Return a new instance of state with the given arguments.
            return new City(name, state);
        }
	}
}

