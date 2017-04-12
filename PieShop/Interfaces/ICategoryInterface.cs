using PieShop.Models;
using System.Collections.Generic;

namespace PieShop.Interfaces
{
    interface ICategoryInterface
    {
        IEnumerable<Category> Category { get; }
    }
}
