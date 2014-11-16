using POP3;
using System;
using System.Drawing;

namespace POP3
{
    public abstract class Person<T>: Model<T>, IPerson where T:Person<T>
    {
        protected String name;
        protected String dni;
        protected String email;
        protected String phone;
        protected String picturePath;

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

        public String PicturePath
        {
            get { return this.picturePath; }
            set { this.picturePath = value; }
        }

        /// <summary>
        /// Person constructor.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="dni"></param>
        /// <param name="email"></param>
        /// <param name="phone"></param>
        public Person(string name, string dni, string email, string phone, String picturePath)
        {
            this.Name = name;
            this.DNI = dni;
            this.Email = email;
            this.Phone = phone;
            this.Id = Guid.NewGuid();
            this.PicturePath = picturePath;
        }
    }
}
