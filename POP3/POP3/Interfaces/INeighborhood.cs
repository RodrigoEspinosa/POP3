using System;

namespace POP3
{
	public interface INeighborhood : IModel
	{
		/// <summary>
		/// Gets or sets the city.
		/// </summary>
		/// <value>The city.</value>
		ICity City { get; set; }

		/// <summary>
		/// Gets or sets the neighborhood name.
		/// </summary>
		/// <value>The neighborhood name.</value>
		String name { get; set; }
	}
}

