using POP3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POP3.Models
{
    public class Apartament: Property
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
        public Apartament (int bedrooms, int bathrooms, int years, int builtMeters, String adress1, String adress2, String number, INeighborhood neighborhood, int floors, int aptNumber)
		    :base(bedrooms,bathrooms,years,builtMeters,adress1,adress2,number,neighborhood)
        {
            this.Floors = floors;
            this.ApartamentNumber = aptNumber; 
        }
    }
}
