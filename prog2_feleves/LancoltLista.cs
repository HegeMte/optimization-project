using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog2_feleves
{
    class HibaException : Exception
    {
        public HibaException() :base("Nem szúrhatod be ezt az elemet")
        {

        }
    }
    class LancoltLista
    {
        private ListaElem fej;

        class ListaElem
        {
            public Alapanyag Tartalom;
            public ListaElem Kovetkezo;
        }

        public int Minimumkereses()
        {
            ListaElem p = this.fej;
            int minimum = 100000;
            while (p != null)
            {
                if (p.Tartalom.Terulet < minimum)
                {
                    minimum = p.Tartalom.Terulet;
                }
                p = p.Kovetkezo;

            }
            return minimum;
        }


        public void Beszur(Alapanyag burkolatelem, LancoltLista lista) //BURKOLATELEM LISTÁJA
        {
            int min = lista.Minimumkereses();
            if (burkolatelem.Terulet > min)
            {
                throw new HibaException();
            }
            else
            {
                ListaElem uj = new ListaElem();
                uj.Tartalom = burkolatelem;
                uj.Kovetkezo = null;
                if (fej == null)   // üres lista
                {
                    uj.Kovetkezo = null;
                    fej = uj;

                }
                else
                {
                    int i = Helyvisszaado(burkolatelem.Terulet);
                    if (i == 0) // elso elem ele
                    {
                        uj.Kovetkezo = fej;
                        fej = uj;
                    }
                    else
                    {
                        int x = 0;
                        ListaElem p = fej;
                        ListaElem e = fej;
                        while (x != i - 1)
                        {
                            x += 1;
                            p = p.Kovetkezo;
                            e = e.Kovetkezo;

                        }
                        p = p.Kovetkezo;
                        if (p == null)
                        {
                            e.Kovetkezo = uj;
                            uj.Kovetkezo = null;
                        }
                        else
                        {
                            e.Kovetkezo = uj;
                            uj.Kovetkezo = p;
                        }





                        /*p = fej;
                    e = null;
                    while (p != null && p.Kulcs.CompareTo(terulet) == 1)
                    {
                        e = p;
                        p = p.Kovetkezo;
                    }
                    if (p == null)
                    {
                        uj.Kovetkezo = null;
                        e.Kovetkezo = uj;
                    }
                    else
                    {
                        uj.Kovetkezo = p;
                        e.Kovetkezo = uj;
                    }*/

                    }
                }

            }

        }


        public void Beszur2(Alapanyag felulet)//FELÜLET LISTÁJA
        {
            ListaElem uj = new ListaElem();
            uj.Tartalom = felulet;
            uj.Kovetkezo = null;
            if (fej == null)   // üres lista
            {
                uj.Kovetkezo = null;
                fej = uj;

            }
            else
            {
                int i = Helyvisszaado(felulet.Terulet);
                if (i == 0) // elso elem ele
                {
                    uj.Kovetkezo = fej;
                    fej = uj;
                }
                else
                {
                    int x = 0;
                    ListaElem p = fej;
                    ListaElem e = fej;
                    while (x != i - 1)
                    {
                        x += 1;
                        p = p.Kovetkezo;
                        e = e.Kovetkezo;

                    }
                    p = p.Kovetkezo;
                    if (p == null)
                    {
                        e.Kovetkezo = uj;
                        uj.Kovetkezo = null;
                    }
                    else
                    {
                        e.Kovetkezo = uj;
                        uj.Kovetkezo = p;
                    }

                    /*Listaelem2<T, K> uj2 = new Listaelem2<T, K>();
                    uj2.Tartalom1 = Felulet;
                    uj2.Kulcs1 = terulet;

                    if (fej1 == null)   // üres lista
                    {
                        uj2.Kovetkezo1 = null;
                        fej1 = uj2;

                    }
                    else
                    {
                        if (fej1.Kulcs1.CompareTo(terulet) == -1) // elso elem ele
                        {
                            uj2.Kovetkezo1 = fej1;
                            fej1 = uj2;
                        }
                        else
                        {

                            p1 = fej1;
                            e1 = null;
                            while (p1 != null && p1.Kulcs1.CompareTo(terulet) == 1)
                            {
                                e1 = p1;
                                p1 = p1.Kovetkezo1;
                            }
                            if (p1 == null)
                            {

                                uj2.Kovetkezo1 = null;
                                e1.Kovetkezo1 = uj2;

                            }
                            else
                            {
                                uj2.Kovetkezo1 = p1;
                                e1.Kovetkezo1 = uj2;
                            }

                        }
                    }*/






                }
            }
        }

        public int Helyvisszaado(int terulet)
        {
            ListaElem p = this.fej;
            int i = 0;

            while (p != null)
            {
                if (p.Tartalom.Terulet < terulet)
                {
                    return ++i;
                }

                i++;
                p = p.Kovetkezo;
            }
            return i;
        }

        public int Lancoltlistadb(LancoltLista lista)
        {
            ListaElem p = this.fej;
            int db = 0;

            while (p != null)
            {


                db++;
                p = p.Kovetkezo;
            }
            return db;
        }
        public IBurkolatElem[] TombkentATartalmak(LancoltLista lista)
        {
            ListaElem p = fej;
            int db = Lancoltlistadb(lista);
            IBurkolatElem[] tomb = new IBurkolatElem[db];
            p = fej;
            for (int i = 0; i < tomb.Length; i++)
            {

                tomb[i] = p.Tartalom as IBurkolatElem;
                p = p.Kovetkezo;



            }

            return tomb;
        }

        public Felulet[] TombkentAFeluletek(LancoltLista lista)
        {
            ListaElem p = fej;
            int db = Lancoltlistadb(lista);
            Felulet[] tomb = new Felulet[db];
            p = fej;
            for (int i = 0; i < tomb.Length; i++)
            {

                tomb[i] = p.Tartalom as Felulet;
                p = p.Kovetkezo;



            }

            return tomb;
        }


        public void ListaBejaras()
        {
            ListaElem p = fej;
            while (p!= null)
            {
                Console.WriteLine(p.Tartalom);
                p = p.Kovetkezo;
            }
        }


    }
}
