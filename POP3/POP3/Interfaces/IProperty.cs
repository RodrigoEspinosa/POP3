using System;

namespace POP3
{
	public interface IProperty : IModel
	{
		/// <summary>
		/// Gets or sets the property address.
		/// </summary>
		/// <value>Property address.</value>
		IAddress Address { get; set; }

		/// <summary>
		/// Gets or sets the number of bedrooms.
		/// </summary>
		/// <value>Number of bedrooms.</value>
		int Bedrooms { get; set; }

		/// <summary>
		/// Gets or sets the number of bathrooms.
		/// </summary>
		/// <value>Number of bathrooms.</value>
		int Bathrooms { get; set; }

		/// <summary>
		/// Gets or sets the year of build.
		/// </summary>
		/// <value>Year of build.</value>
		int Year { get; set; }

		/// <summary>
		/// Gets or sets the built meters.
		/// </summary>
		/// <value>The built meters.</value>
		int BuiltMeters { get; set; }

		/// <summary>
		/// Property full address.
		/// </summary>
		/// <returns>The property address.</returns>
		String FullAddress ();
        
	}
}

