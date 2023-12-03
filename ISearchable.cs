using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_5
{
    public interface ISearchable
    {
        bool SearchByPrice(decimal maxPrice);
        bool SearchByCategory(string category);
        bool SearchByRating(int minRating);
    }

}
