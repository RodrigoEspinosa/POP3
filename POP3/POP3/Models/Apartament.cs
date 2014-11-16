using System;

using POP3;

namespace POP3
{
    public class Apartament: Property<Apartament>
    {
        protected int apartamentNumber;
        protected int floors;

        public int ApartamentNumber
        {
            get { return this.apartamentNumber; }
            set { this.apartamentNumber = value; }
        }
        public int Floors
        {
            get { return this.floors; }
            set { this.floors = value; }
        }
        public Apartament(int bedrooms, int bathrooms, int years, int builtMeters, String adress1, String adress2, String number, bool forRent, bool forSale, int rentPrice, int sellPrice, INeighborhood neighborhood, int floors, int aptNumber)
		    :base(bedrooms, bathrooms, years, builtMeters, adress1, adress2, number, forRent, forSale, rentPrice, sellPrice, neighborhood)
        {
            this.Floors = floors;
            this.ApartamentNumber = aptNumber; 
        }
    }
}
