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

		public override string ToString ()
		{
			return string.Format ("[Country: Name={0}]", Name);
		}
	}
}

