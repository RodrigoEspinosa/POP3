using System;
using System.Collections.Generic;

using POP3;
using POP3.Models;

namespace POP3.AuxiliaryClases
{
    public abstract class PopulateHouseGrid: PopulatePropertyGrid
    {
        public static void PopulateGrid(MetroFramework.Controls.MetroGrid grid, IList<House> list)
        {
            PopulatePropertyGrid.PopulateGrid(grid, (List<Property>)list);
            foreach (House house in list)
            {
                for (int i = 0; i < 8; i++)
                {
                    grid[8, i].Value = house;
                }
            }
        }
    }
}
