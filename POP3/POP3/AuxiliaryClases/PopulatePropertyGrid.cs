using System;
using System.Collections.Generic;
using MetroFramework.Controls;
using POP3.Models;

namespace POP3.AuxiliaryClases
{
    public abstract class PopulatePropertyGrid
    {
        public virtual void PopulateGrid(MetroGrid grid, IList<Apartament> list)
        {
            int numberOfAttributes = 6;
            foreach (Apartament apt in list)
            {
                for (int i = 0; i < numberOfAttributes + 1; i++)
                {
                    grid[0, i].Value = apt.Address.Neighborhood.Name;
                    grid[1, i].Value = apt.Bedrooms.ToString();
                    grid[2, i].Value = apt.Bathrooms.ToString();
                    grid[3, i].Value = apt.BuiltMeters.ToString();
                    grid[4, i].Value = apt.ForRent.ToString();
                    grid[5, i].Value = apt.ForSale.ToString();
                    grid[6, i].Value = apt.Year.ToString();
                }
            }

        }
    }
}
