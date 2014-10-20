using System;

namespace POP3
{
	public interface IPerson : IModel
	{
		string Name { get; set; }
		string DNI { get; set; }
		// IAddress Address { get; set; }
		string Email { get; set; }
		string Phone { get; set; }
	}
}

