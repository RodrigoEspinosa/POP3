using System;

namespace POP3
{
	public interface ICity : IModel
	{
		/// <summary>
		/// Gets or sets the state.
		/// </summary>
		/// <value>The state.</value>
		IState State { get; set; }

		/// <summary>
		/// Gets or sets the city name.
		/// </summary>
		/// <value>The city name.</value>
		String Name { get; set; }
	}
}

