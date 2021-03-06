using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog2_feleves
{
    class Haloszoba : Felulet, IComparable
    {
        public Haloszoba(int Szelesseg, int Magassag, FeluletTipus Felulettipusa) : base(Szelesseg, Magassag, Felulettipusa)
        {

        }


        public int CompareTo(object obj)
        {
            return this.Terulet.CompareTo((obj as Felulet).Terulet);
        }

        public override string ToString()
        {
            return "Hálószoba    ";
        }
    }
}
