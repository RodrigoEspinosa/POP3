using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POP3.AuxiliaryClases
{
    public abstract class PopulateApartamentGrid: PopulatePropertyGrid
    {
        public override void PopulateGrid(MetroFramework.Controls.MetroGrid grid, IList<Models.Apartament> list)
        {
            base.PopulateGrid(grid, list);
        }
    }
}
