using System;

using Newtonsoft.Json;

namespace POP3
{
	public class Property : Model<Property>, IProperty
	{
		private int bedrooms;
		private int bathrooms;
		private int year;
		private int builtMeters;
		private IAddress address;

		public int Bedrooms {
			get { return bedrooms; }
			set { bedrooms = value; }
		}

		public int Bathrooms {
			get { return bathrooms; }
			set { bathrooms = value; }
		}

		public int Year {
			get { return year; }
			set { year = value; }
		}

		public int BuiltMeters {
			get { return builtMeters; }
			set { builtMeters = value; }
		}

		public Guid AddressId {
			get { return address.Id; }
			set {
				address = Model<Address>.GetBy ("Id", value);
			}
		}

		[JsonIgnore]
		public IAddress Address {
			get { return address; }
			set { address = value; }
		}

		public string FullAddress ()
		{
			String fullAddress = address.AddressLine1;
			if (!address.AddressLine2.Equals ("")) {
				fullAddress += "\n" + address.AddressLine2;
			}
			if (!address.Number.Equals ("")) {
				fullAddress += "\n" + address.Number;
			}
			fullAddress = "\n" + address.Neighborhood;
			fullAddress = "\n" + address.Neighborhood.City;
			fullAddress = "\n" + address.Neighborhood.City.State;
			fullAddress = "\n" + address.Neighborhood.City.State.Country;

			return fullAddress;
		}

		public Property ()
		{
		}
	}
}

