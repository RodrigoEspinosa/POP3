using System;

using Newtonsoft.Json;

namespace POP3
{
	public class Address : Model<Address>, IAddress
	{
		private String addressLine1;
		private String addressLine2;
		private String number;
		private INeighborhood neighborhood;

		public String AddressLine1 {
			get { return addressLine1; }
			set { addressLine1 = value; }
		}

		public String AddressLine2 {
			get { return addressLine2; }
			set { addressLine2 = value; }
		}

		public String Number {
			get { return number; }
			set { number = value; }
		}

		public Guid NeighborhoodId {
			get { return neighborhood.Id; }
			set {
				this.neighborhood = Model<Neighborhood>.GetBy ("Id", value);
			}
		}

		[JsonIgnore]
		public INeighborhood Neighborhood {
			get { return neighborhood; }
			set { neighborhood = value; }
		}

		public Address (String addressLine1, String addressLine2="", String number="")
		{
			this.AddressLine1 = addressLine1;
			this.AddressLine2 = addressLine2;
			this.Number = number;
		}
	}
}

