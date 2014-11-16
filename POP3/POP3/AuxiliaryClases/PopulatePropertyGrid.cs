using System;
using System.Collections.Generic;
using MetroFramework.Controls;

namespace POP3.AuxiliaryClases
{
    public abstract class PopulatePropertyGrid
    {
        protected int numberOfAttributes = 6;
        public static void PopulateGrid(MetroGrid grid, IList<IProperty> list)
        {
            foreach (IProperty prop in list)
            {
                for (int i = 0; i < 7; i++)
                {
                    grid[0, i].Value = prop.Address.Neighborhood.Name;
                    grid[1, i].Value = prop.Bedrooms.ToString();
                    grid[2, i].Value = prop.Bathrooms.ToString();
                    grid[3, i].Value = prop.BuiltMeters.ToString();
                    grid[4, i].Value = prop.ForRent.ToString();
                    grid[5, i].Value = prop.ForSale.ToString();
                    grid[6, i].Value = prop.Year.ToString();
                }
            }

        }
    }
}
