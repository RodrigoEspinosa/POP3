using System;

namespace POP3
{
	public interface IState : IModel
	{
		/// <summary>
		/// Gets or sets the country.
		/// </summary>
		/// <value>The country.</value>
		ICountry Country { get; set; }

		/// <summary>
		/// Gets or sets the state name.
		/// </summary>
		/// <value>The state name.</value>
		String Name { get; set; }
	}
}

