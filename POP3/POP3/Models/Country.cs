using System;

namespace POP3
{
	public class Country : Model<Country>, ICountry
	{
		private String name;

		public String Name {
			get { return name; }
			set { name = value; }
		}

		public Country (String name)
		{
			this.name = name;
		}

        public static Country GetOrCreate (String name)
        {
            // Check if the Country already exists.
            Country country = Country.GetBy ("Name", name);
            if (country != null) {
                // Return the existing Country.
                return country;
            }

            // Create a new instance of Country and return it.
            return new Country (name);
        }

		public override string ToString ()
		{
			return string.Format ("[Country: Name={0}]", Name);
		}
	}
}

