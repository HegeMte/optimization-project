using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog2_feleves
{
    public enum Hovarakhato { Padlo, Fal }
    interface IBurkolatElem : Alapanyag
    {


        int Szelesseg { get; set; }

        int Magassag { get; set; }
        int Terulet { get; set; }
        string Termeknev { get; set; }

        int darabszam { get; set; }

        Hovarakhato hovarakhato{get;set;}
        IBurkolatElem legjobbburkolo { get; set; }


    }
}
