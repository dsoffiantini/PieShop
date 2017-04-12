using PieShop.Models;
using System.Collections.Generic;

namespace PieShop.Interfaces
{
    interface IPieInterface
    {
        IEnumerable<Pie> Pies { get; }
        IEnumerable<Pie> PiesOfTheWeek { get; }
        Pie GetPieById(int pieId);
    }
}
