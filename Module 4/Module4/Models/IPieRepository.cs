using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Module4.Models
{
    // till now repositories are interfaces
    public interface IPieRepository
    {
        IEnumerable<Pie> AllPies { get; }
        IEnumerable<Pie> PiesOfTheWeek { get; }
        Pie GetPieById(int pieId);
    }
}
