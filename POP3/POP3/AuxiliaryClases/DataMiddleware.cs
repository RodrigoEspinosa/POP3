using System;

using POP3;

namespace POP3.AuxiliaryClases
{
    public static class DataMiddleware
    {

        public static void LoadData()
        {
            try {
                Country.Load();
                State.Load();
                City.Load();
                Neighborhood.Load();
                Client.Load();
                Apartament.Load();
                House.Load();
                
            } catch (FileDoesNotExist) {
            
            }
            
            // Ensure country initial data
            if (Country.getInstances().Count < 1)
            {
                DataMiddleware.CountriesInitialData();
            }
        }

        public static void SaveData()
        {

        }

        private static void CountriesInitialData()
        {
            // Createa a new instance of country for each country name on the array.
            foreach (String countryName in CountryArrays.Names) {
                new Country (countryName);
            }
            
            // Save all the countries instances.
            Country.Save ();
        }
    }
}
