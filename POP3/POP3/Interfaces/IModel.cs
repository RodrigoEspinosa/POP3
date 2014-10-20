using System;

namespace POP3
{
	public interface IModel
	{
		/// <summary>
		/// Gets or sets the identifier.
		/// </summary>
		/// <value>The identifier.</value>
		Guid Id { get; set; }

		/// <summary>
		/// Serialize this instance.
		/// </summary>
		String Serialize ();

		/// <summary>
		/// Deserialize the specified data.
		/// </summary>
		/// <param name="data">String data.</param>
		// Object Deserialize (String data);

		// IModel GetBy (String filter, Object value);
	}
}

