using System;

namespace POP3
{
	public interface IAddress
	{
		/// <summary>
		/// Gets or sets the neighborhood.
		/// </summary>
		/// <value>The neighborhood.</value>
		INeighborhood Neighborhood { get; set; }

		/// <summary>
		/// Gets or sets the address line1.
		/// </summary>
		/// <value>The address line1.</value>
		String AddressLine1 { get; set; }

		/// <summary>
		/// Gets or sets the address line2.
		/// </summary>
		/// <value>The address line2.</value>
		String AddressLine2 { get; set; }

		/// <summary>
		/// Gets or sets the number.
		/// </summary>
		/// <value>The number.</value>
		String Number { get; set; }
	}
}

