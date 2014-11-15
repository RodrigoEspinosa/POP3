using POP3;
using POP3.Models;
using POP3;
using System;
using System.Collections.Generic;
using System.Linq;

namespace POP3
{
    class Sort
    {
        public static IOrderedEnumerable<House> SortbyNeighborhood(List<House> lista)
        {
            var sortedByNeighborhood =
            from nei in lista
            orderby nei.Address.Neighborhood ascending
            select nei;
            return sortedByNeighborhood;
        }

    }
}
