using POP3;
using System;
using System.Drawing;

namespace POP3
{
    public abstract class Person<T> : Model<T>, IPerson where T:Person<T>
    {
        protected String name;
        protected String dni;
        protected String email;
        protected String phone;
        protected Image profilePicture;

        /// <summary>
        /// Gets/Sets the Person Name.
        /// </summary>
        public String Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        /// <summary>
        /// Gets/Sets the Person dni.
        /// </summary>
        public String DNI
        {
            get { return this.dni; }
            set { this.dni = value; }
        }

        /// <summary>
        /// Gets/Sets the Person email.
        /// </summary>
        public String Email
        {
            get { return this.email; }
            set { this.email = value; }
        }

        /// <summary>
        /// Gets/Sets the Person phone.
        /// </summary>
        public String Phone
        {
            get { return this.phone; }
            set { this.phone = value; }
        }

        public Image ProfilePicture
        {
            get { return this.profilePicture; }
            set { this.profilePicture = value; }
        }

        /// <summary>
        /// Person constructor.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="dni"></param>
        /// <param name="email"></param>
        /// <param name="phone"></param>
        public Person(string name, string dni, string email, string phone, Image profilePicture)
        {
            this.Name = name;
            this.dni = dni;
            this.email = email;
            this.phone = phone;
            this.id = Guid.NewGuid();
            this.profilePicture = profilePicture;
        }
    }
}
