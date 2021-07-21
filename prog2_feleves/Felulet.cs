using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog2_feleves
{
    public enum FeluletTipus {Padlo,Fal}
    
    
    abstract class Felulet :Alapanyag
    {
        public int Szelesseg { get; set; }
        public int Magassag { get; set; }
        public FeluletTipus Felulettipusa { get; set; }

        public int Terulet { get; set; }
        public IBurkolatElem legjobbburkolo { get; set; }
        public int felhasznaltdb { get; set; }
        public Felulet(int Szelesseg, int Magassag,FeluletTipus Felulettipusa)
        {
            this.Szelesseg = Szelesseg;
            this.Magassag = Magassag;
            this.Felulettipusa = Felulettipusa;
            this.Terulet = Magassag * Szelesseg;
            
        }
    }
}
