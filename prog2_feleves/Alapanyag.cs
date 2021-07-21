using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog2_feleves
{
    interface Alapanyag
    {
        int Szelesseg { get; set; }
         int Magassag { get; set; }
        int Terulet { get; set; }
        IBurkolatElem legjobbburkolo { get; set; }
    }
}
