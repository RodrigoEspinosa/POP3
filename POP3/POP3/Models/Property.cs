using System;

using Newtonsoft.Json;

namespace POP3
{
    public abstract class Property<T> : Model<T>, IProperty where T:Property<T>
    {
        protected int bedrooms;
        protected int bathrooms;
        protected int year;
        protected int builtMeters;
        protected bool forRent;
        protected bool forSale;
        protected int sellPrice;
        protected int rentPrice;
        protected IAddress address;

        public int Bedrooms
        {
            get { return bedrooms; }
            set { bedrooms = value; }
        }

        public int Bathrooms
        {
            get { return bathrooms; }
            set { bathrooms = value; }
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public int BuiltMeters
        {
            get { return builtMeters; }
            set { builtMeters = value; }
        }

        public bool ForRent
        {
            get { return this.forRent; }
            set { this.forRent = value; }
        }

        public bool ForSale
        {
            get { return this.forSale; }
            set { this.forSale = value; }
        }

        public Guid AddressId
        {
            get { return address.Id; }
            set
            {
                address = Model<Address>.GetBy("Id", value);
            }
        }

        [JsonIgnore]
        public IAddress Address
        {
            get { return address; }
            set { address = value; }
        }

        public int SellPrice
        {
            get { return this.sellPrice; }
            set { this.sellPrice = value; }
        }

        public int RentPrice
        {
            get { return this.rentPrice; }
            set { this.rentPrice = value;}
        }

        public string FullAddress()
        {
            String fullAddress = address.AddressLine1;
            if (!address.AddressLine2.Equals(""))
            {
                fullAddress += "\n" + address.AddressLine2;
            }
            if (!address.Number.Equals(""))
            {
                fullAddress += "\n" + address.Number;
            }
            fullAddress = "\n" + address.Neighborhood;
            fullAddress = "\n" + address.Neighborhood.City;
            fullAddress = "\n" + address.Neighborhood.City.State;
            fullAddress = "\n" + address.Neighborhood.City.State.Country;

            return fullAddress;
        }

        public Property(int bedrooms, int bathrooms, int years, int builtMeters, String adress1, String adress2, String number, bool forRent, bool forSale,int rentPrice, int SellPrice ,INeighborhood neighborhood)
        {
            this.bedrooms = bedrooms;
            this.bathrooms = bathrooms;
            this.year = years;
            this.builtMeters = builtMeters;
            this.ForRent = forRent;
            this.ForSale = forSale;
            this.SellPrice = sellPrice;
            this.RentPrice = rentPrice;
            this.Address = new Address(adress1, adress2, number);
            this.Address.Neighborhood = neighborhood;

        }
    }
}

