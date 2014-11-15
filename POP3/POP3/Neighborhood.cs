using System;

using Newtonsoft.Json;

namespace POP3
{
	public class Neighborhood : Model<Neighborhood>, INeighborhood
	{
		private ICity city;
		private String name;

		public Guid CityId {
			get { return city.Id; }
			set { 
				this.city = Model<City>.GetBy ("Id", value);
			}
		}

		[JsonIgnore]
		public ICity City {
			get { return city; }
			set { city = value; }
		}

		public String Name {
			get { return name; }
			set { name = value; }
		}

		public Neighborhood (String name)
		{
			this.name = name;
		}
	}
}
