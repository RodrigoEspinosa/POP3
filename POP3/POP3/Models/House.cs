using POP3;
using System;
using System.Collections.Generic;

namespace POP3.Models
{
    public class House: Property
    {
        protected bool garage;
        public House(int bedrooms, int bathrooms, int years, int builtMeters, String adress1, String adress2, String number, bool forRent, bool forSale, INeighborhood neighborhood, bool garage)
		    : base( bedrooms, bathrooms, years, builtMeters, adress1, adress2, number, forRent, forSale, neighborhood)
        {
            this.garage = garage;
        }
    }
}
