using POP3;
using System;
using System.Drawing;
using System.Collections.Generic;

namespace POP3
{
    public class Client : Person<Client>, IClient
    {
        protected bool sellsHisProperty;
        protected bool rentsHisProperty;
        protected bool wantToRentProperty;
        protected bool wantToBuyProperty;

        /// <summary>
        /// Gets/Sets whether a Client 
        /// sells or not a Property.
        /// </summary>
        public bool SellsProperty
        {
            get { return this.sellsHisProperty; }
            set { this.sellsHisProperty = value; }
        }

        /// <summary>
        /// Gets/Sets whether a Client 
        /// rents or not a Property.
        /// </summary>
        public bool RentsProperty
        {
            get { return this.rentsHisProperty; }
            set { this.rentsHisProperty = value;}
        }

        /// <summary>
        /// Gets/Sets whether a Client 
        /// want or not to rent a Property.
        /// </summary>
        public bool WantsToRentProperty
        {
            get { return this.wantToRentProperty; }
            set { this.wantToRentProperty = value; }
        }

        /// <summary>
        /// Gets/Sets whether a Client 
        /// sells or not to buy a Property.
        /// </summary>
        public bool WantsToBuyProperty
        {
            get { return this.wantToBuyProperty; }
            set { this.wantToBuyProperty = value; }
        }

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="email"></param>
        /// <param name="phone"></param>
        /// <param name="dni"></param>
        /// <param name="sellProperty"></param>
        /// <param name="rentsProperty"></param>
        /// <param name="wantToRentProperty"></param>
        /// <param name="wantToSellProperty"></param>
        public Client(String name, String email, String phone, String dni, bool sellsHisProperty, bool rentsHisProperty, bool wantToRentProperty, bool wantToBuyProperty, String path)
            :base(name,dni,email,phone, path)
        {
            this.SellsProperty = sellsHisProperty;
            this.RentsProperty = rentsHisProperty;
            this.wantToRentProperty = wantToRentProperty;
            this.WantsToBuyProperty = wantToBuyProperty;
        }

        public override string ToString()
        {
            return this.Name;
        }
        
    }
}
