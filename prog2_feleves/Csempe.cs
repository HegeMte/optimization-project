using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog2_feleves
{
    class Csempe :IBurkolatElem,IComparable
    {
        public string Termeknev { get; set; }
        public int Szelesseg { get; set; }
        public int Magassag { get; set; }
        public int Terulet { get; set; }
        public int darabszam { get; set; }
        public Hovarakhato hovarakhato { get; set ; }
       public  IBurkolatElem legjobbburkolo { get; set; }

        public Csempe(string Termeknev, int Szelesseg, int Magassag,int darabszam,Hovarakhato hovarakhato)
        {

            this.Termeknev = Termeknev;
            this.Szelesseg = Szelesseg;
            this.Magassag = Magassag;
            this.darabszam = darabszam;
            this.hovarakhato = hovarakhato;
            this.Terulet = Magassag * Szelesseg;


        }
        public int CompareTo(object obj)
        {
            return this.Terulet.CompareTo((obj as IBurkolatElem).Terulet);
        }

        public override string ToString()
        {
            return this.Termeknev +" Szélessége:  "+this.Szelesseg+ " Magassága: "  + this.Magassag+" Területe: " +" Területe: " +this.Terulet;
        }
    }
}
