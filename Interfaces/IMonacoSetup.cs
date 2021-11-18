using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaOne.Interfaces
{
    public interface IMonacoSetup : IGrandPrixSetup
    {
        string YachtsDocking();
        string TrackBeingPaved();
    }
}
