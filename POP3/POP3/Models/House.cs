﻿using System;

using POP3;

namespace POP3
{
    public class House : Property<House>
    {
        private bool garage;
        private bool garden;

        public bool Garage
        {
            get { return garage; }
            set { this.garage = value; }
        }

        public bool Garden
        {
            get { return garden; }
            set { this.garden = value; }
        }

        public House(int bedrooms, int bathrooms, int years, int builtMeters, String adress1, String adress2,
            String number, bool forRent, bool forSale, int rentPrice, int sellPrice, INeighborhood neighborhood, bool garage, bool garden=false)
		    : base(bedrooms, bathrooms, years, builtMeters, adress1, adress2, number, forRent, forSale, rentPrice,sellPrice, neighborhood)
        {
            this.garage = garage;
            this.garden = garden;
        }
    }
}
