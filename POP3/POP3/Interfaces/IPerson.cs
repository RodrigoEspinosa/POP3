using System;
using System.Drawing;

namespace POP3
{
	public interface IPerson : IModel
	{
        /// <summary>
        /// Gets/Sets the name.
        /// </summary>
		String Name { get; set; }
        
        /// <summary>
        /// Gets/Sets the DNI.
        /// </summary>
		String DNI { get; set; }
		
        // IAddress Address { get; set; }

        /// <summary>
        /// Gets/Sets the email.
        /// </summary>
		String Email { get; set; }
        
        /// <summary>
        /// Gets/Sets the phone number.  
        /// </summary>
		String Phone { get; set; }

        Image ProfilePicture { get; set; }
	}
}

