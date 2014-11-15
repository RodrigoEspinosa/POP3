using POP3;
using POP3.Models;
using POP3;
using System;
using System.Collections.Generic;
using System.Linq;

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

    }
}
