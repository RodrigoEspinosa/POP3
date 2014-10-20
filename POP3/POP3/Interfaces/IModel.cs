using System;

namespace POP3
{
	public interface IModel
	{
		/// <summary>
		/// Serialize this instance.
		/// </summary>
		String Serialize ();

		/// <summary>
		/// Deserialize the specified data.
		/// </summary>
		/// <param name="data">String data.</param>
		// Object Deserialize (String data);

		Guid Id { get; }

		// IModel GetBy (String filter, Object value);
	}
}

