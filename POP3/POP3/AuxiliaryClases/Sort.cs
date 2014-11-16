using POP3;
using System;
using System.Collections.Generic;
using System.Linq;
using MetroFramework.Controls;

namespace POP3
{
    public abstract class Sort
    {
        /// <summary>
        /// Sort houses by Neighborhood.
        /// </summary>
        /// <param name="lista"></param>
        /// <returns>List<House></House></returns>
        public static IOrderedEnumerable<House> SortbyNeighborhood(IList<House> lista)
        {
            var sortedByNeighborhood =
            from nei in lista
            orderby nei.Address.Neighborhood ascending
            select nei;
            return sortedByNeighborhood;
        }

        /// <summary>
        /// Returs the Neighborhood instance
        /// corresponding to the given name.
        /// </summary>
        /// <param name="comboBox"></param>
        /// <param name="list"></param>
        /// <returns></returns>
        public static Neighborhood GetNeighborhoodByName(CustomComboBox comboBox, IList<Neighborhood> list)
        {
            Neighborhood nei = null;
            foreach (Neighborhood nei1 in list)
            {
                if (nei1.Name == comboBox.SelectedItem.ToString())
                {
                    nei = nei1;
                }
            }
            return nei;
        }
    }
}
