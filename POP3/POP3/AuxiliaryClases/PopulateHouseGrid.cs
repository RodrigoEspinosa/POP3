using System;
using System.Collections.Generic;
using MetroFramework.Controls;
using System.Windows.Forms;

namespace POP3.AuxiliaryClases
{
    public abstract class PopulateHouseGrid
    {
        public static void PopulateGrid(MetroGrid grid, IList<Apartament> listApt, IList<House> listHouse)
        {
            //Clear data Grid;
            grid.DataSource = null;
            grid.Rows.Clear();
            
            foreach (House house in listHouse)
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
                row.Cells[11].Value = house.Id.ToString();
                grid.Rows.Add(row);
            }

            foreach (Apartament apt in listApt)
            {
                DataGridViewRow row = (DataGridViewRow)grid.Rows[0].Clone();
                row.Cells[0].Value = apt.SellPrice.ToString();
                row.Cells[1].Value = apt.RentPrice.ToString();
                row.Cells[2].Value = apt.Bedrooms.ToString();
                row.Cells[3].Value = apt.Bathrooms.ToString();
                row.Cells[4].Value = apt.Year.ToString().ToString();
                row.Cells[5].Value = apt.BuiltMeters.ToString();
                row.Cells[6].Value = apt.Address.Neighborhood.Name.ToString();
                row.Cells[7].Value = "-";
                row.Cells[8].Value = "-";
                row.Cells[9].Value = apt.ApartamentNumber.ToString();
                row.Cells[10].Value = apt.Floors.ToString();
                row.Cells[11].Value = apt.Id.ToString();
                grid.Rows.Add(row);
            }
        }
    }
}
