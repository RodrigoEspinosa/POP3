using System;
using System.Collections.Generic;
using MetroFramework.Controls;
using System.Windows.Forms;

namespace POP3.AuxiliaryClases
{
    public abstract class PopulateHouseGrid
    {
        public static void PopulateGrid(MetroGrid grid, IList<House> list)
        {
            //Clear data Grid;
            grid.DataSource = null;
            grid.Rows.Clear();
            
            foreach (House house in list)
            {
                DataGridViewRow row = (DataGridViewRow)grid.Rows[0].Clone();
                row.Cells[0].Value = house.SellPrice.ToString();
                row.Cells[1].Value = house.RentPrice.ToString();
                row.Cells[2].Value = house.Bedrooms.ToString();
                row.Cells[3].Value = house.Bathrooms.ToString();
                row.Cells[4].Value = house.Year.ToString();
                row.Cells[5].Value = house.BuiltMeters.ToString();
                row.Cells[6].Value = house.Address.Neighborhood.Name;
                row.Cells[7].Value = house.Garage.ToString();
                row.Cells[8].Value = house.Garden.ToString();
                row.Cells[9].Value = "-";
                row.Cells[10].Value = "-";
                grid.Rows.Add(row);
            }
        }
    }
}
