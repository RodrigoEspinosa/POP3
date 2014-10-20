using System;
using Newtonsoft.Json;

namespace POP3
{
	public class State : Model <State>, IState
	{
		private ICountry country;
		private String name;

		public Guid CountryId {
			get { return country.Id; }
			set {
				foreach (Country c in Model<Country>.getInstances()) {
					if (c.Id.Equals (value)) {
						this.country = c;
					}
				}
			}
		}

		[JsonIgnore]
		public ICountry Country {
			get { return country; }
			set { country = value; }
		}

		public String Name {
			get { return name; }
			set { name = value; }
		}

		public State (String name="", ICountry country=null)
		{
			this.name = name;
			this.Country = country;
		}

		public override string ToString ()
		{
			return string.Format ("[State: Country={0}, Name={1}]", Country, Name);
		}
	}
}

