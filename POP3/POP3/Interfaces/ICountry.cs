using System;

namespace POP3
{
	public interface ICountry : IModel
	{
		/// <summary>
		/// Gets or sets the country name.
		/// </summary>
		/// <value>The country name.</value>
		String Name { get; set; }
	}
}

