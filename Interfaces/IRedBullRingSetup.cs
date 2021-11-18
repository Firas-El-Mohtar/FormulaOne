using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaOne.Interfaces
{
    public interface IRedBullRingSetup : IGrandPrixSetup
    {
        string ConfiguringFlightPath();
        string PlaceFloatingBarriers();
    }
}
