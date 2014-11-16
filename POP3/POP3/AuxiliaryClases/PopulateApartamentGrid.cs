using System;
using System.Collections.Generic;
using System.Reflection;


namespace POP3.AuxiliaryClases
{
    public abstract class PopulateApartamentGrid
    {
        public void PopulateGrid(MetroFramework.Controls.MetroGrid grid, IList<Apartament> list)
        {
            PopulatePropertyGrid.PopulateGrid(grid, (IList<IProperty>)list);
            foreach (Apartament apt in list)
            {
                for (int i = 0; i < 8; i++)
                {
                    grid[8, i].Value = apt.Floors.ToString();
                }
            }
        }
    }
}
