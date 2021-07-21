using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog2_feleves
{
    /* class Listaelem<T, K>
     {
         public T Tartalom { get; set; }
         public K Kulcs { get; set; }

         public Listaelem<T, K> Kovetkezo { get; set; }
     }//BUE

     class Listaelem2<T, K>
     {
         public T Tartalom1 { get; set; }
         public K Kulcs1 { get; set; }

         public Listaelem2<T, K> Kovetkezo1 { get; set; }
     }//FE*/


    public delegate void Lakasfigyelo(bool keszvane);

    class Lakas
    {
         public string Lakasnev { get; set; }
        public Konyha konyhafal { get; set; }
        public Konyha konyhapadlo { get; set; }

        bool keszvane = false;
        public bool Keszvane
        {
            get
            {
                return keszvane;
            }
            set
            {
                keszvane = value;
                if (lakasfigyelo != null) lakasfigyelo(keszvane);
            }
        }


        public Nappali nappalifal { get; set; }
        public Nappali nappalipadlo { get; set; }

        public Haloszoba haloszobafal { get; set; }
       public Haloszoba haloszobapadlo { get; set; }

        public Furdo furdoszobapadlo { get; set; }
        public Furdo furdoszobafal { get; set; }



        public event Lakasfigyelo lakasfigyelo;


        //public LancoltLista burkolatelem;
        //public LancoltLista felulet;
        //public IBurkolatElem legjobbburkoloelem { get; set; }

        public Lakas(string Lakasnev, Konyha konyhafal, Konyha konyhapadlo, Nappali nappalifal, Nappali nappalipadlo, Haloszoba haloszobafal, Haloszoba haloszobapadlo, Furdo furdoszobafal , Furdo furdoszobapadlo)
        {
            this.Lakasnev = Lakasnev;
            this.konyhafal = konyhafal;
            this.konyhapadlo = konyhapadlo;
            this.nappalifal = nappalifal;
            this.nappalipadlo = nappalipadlo;
            this.haloszobafal = haloszobafal;
            this.haloszobapadlo = haloszobapadlo;
            this.furdoszobafal = furdoszobafal;
            this.furdoszobapadlo = furdoszobapadlo;


        }

        

        public void LakasBurkolas(LancoltLista burkololaplista, Lakas lakas)
        {
            Console.WriteLine("{0} \t{1}(fal)     \t{2} ", lakas.Lakasnev, lakas.konyhafal.ToString(), KonyhaFalBurkolas(burkololaplista, lakas));
            Console.WriteLine("{0} \t{1}(padlo) \t{2} ", lakas.Lakasnev, lakas.konyhapadlo.ToString(), KonyhaPadloBurkolas(burkololaplista, lakas));
            Console.WriteLine("{0} \t{1}(fal)     \t{2} ", lakas.Lakasnev, lakas.nappalifal.ToString(), NappaliFalBurkolas(burkololaplista, lakas));
            Console.WriteLine("{0} \t{1}(padlo) \t{2} ", lakas.Lakasnev, lakas.nappalipadlo.ToString(), NappaliPadloBurkolas(burkololaplista, lakas));
            Console.WriteLine("{0} \t{1}(fal)     \t{2} ", lakas.Lakasnev, lakas.haloszobafal.ToString(), HaloszobaFalBurkolas(burkololaplista, lakas));
            Console.WriteLine("{0} \t{1}(padlo)     \t{2} ", lakas.Lakasnev, lakas.haloszobapadlo.ToString(), HaloszobaPadloBurkolas(burkololaplista, lakas));
            Console.WriteLine("{0} \t{1}(fal)     \t{2} ", lakas.Lakasnev, lakas.furdoszobafal.ToString(), FurdoszobaFalBurkolas(burkololaplista, lakas));
            Console.WriteLine("{0} \t{1}(padlo)     \t{2} ", lakas.Lakasnev, lakas.furdoszobapadlo.ToString(), FurdoszobaPadloBurkolas(burkololaplista, lakas));
            Console.WriteLine();

            lakas.lakasfigyelo += Keszenvane;

        }

        public IBurkolatElem HaloszobaFalBurkolas(LancoltLista burkololaplista, Lakas lakas )
        {

            IBurkolatElem[] falrarakhato = Falraburkolatkivalaszto(burkololaplista);
            int szamlalo = 0, i = 0, s = 0;
            int db = 0;
            int felhasznaltdb = 0;
            while (s < falrarakhato.Length)
            {


                

                szamlalo = 0;
                db = falrarakhato[i].darabszam;
                felhasznaltdb = 0;
                while (szamlalo < (lakas.haloszobafal.Terulet * 4) && falrarakhato[i].darabszam >= 0)
                {
                    szamlalo += falrarakhato[i].Terulet;
                    falrarakhato[i].darabszam--;
                    felhasznaltdb++;

                }

                if (falrarakhato[i].darabszam >= 0)
                {
                    haloszobafal.legjobbburkolo = falrarakhato[i];
                    break;
                }
                else
                {
                    falrarakhato[i].darabszam = db;

                }
                i++;
                s++;


            }

            lakas.haloszobafal.felhasznaltdb = felhasznaltdb;
            return haloszobafal.legjobbburkolo;



        }
        public IBurkolatElem HaloszobaPadloBurkolas(LancoltLista burkololaplista, Lakas lakas)
        {

            IBurkolatElem[] padlorarakhato = Padloraburkolatlatkivalaszto(burkololaplista);

            int szamlalo = 0, i = 0, s = 0;
            int db = 0;
            int felhasznaltdb = 0;
            while (s < padlorarakhato.Length)
            {




                szamlalo = 0;
                felhasznaltdb = 0;
                db = padlorarakhato[i].darabszam;
                while (szamlalo < lakas.haloszobapadlo.Terulet  && padlorarakhato[i].darabszam >= 0)
                {
                    szamlalo += padlorarakhato[i].Terulet;
                    padlorarakhato[i].darabszam--;
                    felhasznaltdb++;

                }

                if (padlorarakhato[i].darabszam >= 0)
                {
                    haloszobapadlo.legjobbburkolo = padlorarakhato[i];
                    break;
                }
                else
                {
                    padlorarakhato[i].darabszam = db;

                }
                i++;
                s++;


            }
            lakas.haloszobapadlo.felhasznaltdb = felhasznaltdb;
            return haloszobapadlo.legjobbburkolo;



        }


        public IBurkolatElem FurdoszobaFalBurkolas(LancoltLista burkololaplista, Lakas lakas)
        {

            IBurkolatElem[] falrarakhato = Falraburkolatkivalaszto(burkololaplista);
            int szamlalo = 0, i = 0, s = 0;
            int db = 0;
            int felhasznaltdb = 0;
            while (s < falrarakhato.Length)
            {




                szamlalo = 0;
                db = falrarakhato[i].darabszam;
                felhasznaltdb = 0;
                while (szamlalo < (lakas.furdoszobafal.Terulet * 4) && falrarakhato[i].darabszam >= 0)
                {
                    szamlalo += falrarakhato[i].Terulet;
                    falrarakhato[i].darabszam--;
                    felhasznaltdb++;

                }

                if (falrarakhato[i].darabszam >= 0)
                {
                    furdoszobafal.legjobbburkolo = falrarakhato[i];
                    break;
                }
                else
                {
                    falrarakhato[i].darabszam = db;

                }
                i++;
                s++;


            }
            lakas.furdoszobafal.felhasznaltdb = felhasznaltdb;
            return furdoszobafal.legjobbburkolo;



        }

        public IBurkolatElem FurdoszobaPadloBurkolas(LancoltLista burkololaplista, Lakas  lakas)
        {

            IBurkolatElem[] padlorarakhato = Padloraburkolatlatkivalaszto(burkololaplista);

            int szamlalo = 0, i = 0, s = 0;
            int db = 0;
            int felhasznaltdb = 0;

            while (s < padlorarakhato.Length)
            {




                szamlalo = 0;
                db = padlorarakhato[i].darabszam;
                felhasznaltdb = 0;
                while (szamlalo < lakas.furdoszobapadlo.Terulet  && padlorarakhato[i].darabszam >= 0)
                {
                    szamlalo += padlorarakhato[i].Terulet;
                    padlorarakhato[i].darabszam--;
                    felhasznaltdb++;

                }

                if (padlorarakhato[i].darabszam >= 0)
                {
                    furdoszobapadlo.legjobbburkolo = padlorarakhato[i];
                    break;
                }
                else
                {
                    padlorarakhato[i].darabszam = db;

                }
                i++;
                s++;


            }
            lakas.furdoszobapadlo.felhasznaltdb = felhasznaltdb;
            return furdoszobapadlo.legjobbburkolo;



        }
        public IBurkolatElem NappaliFalBurkolas(LancoltLista burkololaplista, Lakas lakas)
        {

            IBurkolatElem[] falrarakhato = Falraburkolatkivalaszto(burkololaplista);
            int szamlalo = 0, i = 0,  s = 0;
            int db = 0;
            int felhasznaltdb = 0;
            while (s < falrarakhato.Length)
            {


                 
                   
                    szamlalo = 0;
                    db = falrarakhato[i].darabszam;
                    felhasznaltdb = 0;
                    while (szamlalo < (lakas.nappalifal.Terulet * 4) && falrarakhato[i].darabszam >= 0)
                    {
                        szamlalo += falrarakhato[i].Terulet;
                        falrarakhato[i].darabszam--;
                        felhasznaltdb++;

                    }

                    if(falrarakhato[i].darabszam >= 0)
                    {
                      nappalifal.legjobbburkolo=falrarakhato[i];
                      break;
                    }
                    else
                    {
                    falrarakhato[i].darabszam = db;

                    }
                    i++;
                    s++;
                    

            }
            lakas.nappalifal.felhasznaltdb = felhasznaltdb;
            return nappalifal.legjobbburkolo;
           


        }

        public IBurkolatElem NappaliPadloBurkolas(LancoltLista burkololaplista, Lakas  lakas)
        {

            IBurkolatElem[] padlorarakhato = Padloraburkolatlatkivalaszto(burkololaplista);
           
            int szamlalo = 0, i = 0, s = 0;
            int db = 0;
            int felhasznaltdb = 0;
            while (s < padlorarakhato.Length)
            {




                szamlalo = 0;
                db = padlorarakhato[i].darabszam;
                felhasznaltdb = 0;
                while (szamlalo < lakas.nappalipadlo.Terulet  && padlorarakhato[i].darabszam >= 0)
                {
                    szamlalo += padlorarakhato[i].Terulet;
                    padlorarakhato[i].darabszam--;
                    felhasznaltdb++;

                }

                if (padlorarakhato[i].darabszam >= 0)
                {
                    nappalipadlo.legjobbburkolo = padlorarakhato[i];
                    break;
                }
                else
                {
                    padlorarakhato[i].darabszam = db;

                }
                i++;
                s++;


            }
            lakas.nappalipadlo.felhasznaltdb = felhasznaltdb;
            return nappalipadlo.legjobbburkolo;



        }

        public IBurkolatElem KonyhaFalBurkolas(LancoltLista burkololaplista,Lakas lakas)
        {

            IBurkolatElem[] falrarakhato = Falraburkolatkivalaszto(burkololaplista);
            int szamlalo = 0, i = 0, s = 0;
            int db = 0;
            int felhasznaltdb = 0;
            while (s < falrarakhato.Length)
            {




                szamlalo = 0;
                db = falrarakhato[i].darabszam;
                felhasznaltdb = 0;
                while (szamlalo < (lakas.konyhafal.Terulet * 4) && falrarakhato[i].darabszam >= 0)
                {
                    szamlalo += falrarakhato[i].Terulet;
                    falrarakhato[i].darabszam--;
                    felhasznaltdb++;

                }

                if (falrarakhato[i].darabszam >= 0)
                {
                    konyhafal.legjobbburkolo = falrarakhato[i];
                    break;
                }
                else
                {
                    falrarakhato[i].darabszam = db;

                }
                i++;
                s++;


            }
            lakas.konyhafal.felhasznaltdb = felhasznaltdb;
            return konyhafal.legjobbburkolo;



        }

        public IBurkolatElem KonyhaPadloBurkolas(LancoltLista burkololaplista, Lakas lakas)
        {

            IBurkolatElem[] padlorarakhato = Padloraburkolatlatkivalaszto(burkololaplista);

            int szamlalo = 0, i = 0, s = 0;
            int db = 0;
            int felhasznaltdb = 0;
            while (s < padlorarakhato.Length)
            {




                szamlalo = 0;
                db = padlorarakhato[i].darabszam;
                felhasznaltdb = 0;
                while (szamlalo < lakas.konyhapadlo.Terulet  && padlorarakhato[i].darabszam >= 0)
                {
                    szamlalo += padlorarakhato[i].Terulet;
                    padlorarakhato[i].darabszam--;
                    felhasznaltdb++;

                }

                if (padlorarakhato[i].darabszam >= 0)
                {
                    konyhapadlo.legjobbburkolo = padlorarakhato[i];
                    break;
                }
                else
                {
                    padlorarakhato[i].darabszam = db;

                }
                i++;
                s++;


            }
            lakas.konyhapadlo.felhasznaltdb = felhasznaltdb;
            return konyhapadlo.legjobbburkolo;




        }

        public IBurkolatElem [] Falraburkolatkivalaszto(LancoltLista burkololaplista)
        {
            int burkolodb = burkololaplista.Lancoltlistadb(burkololaplista);
            IBurkolatElem[] burkoloelemek = burkololaplista.TombkentATartalmak(burkololaplista);
            int j = 0;
            int db = 0;
            for (int i = 0; i < burkolodb; i++)
            {
                if (burkoloelemek[i].hovarakhato == Hovarakhato.Fal)
                {
                    db++;
                }

            }
            IBurkolatElem[] falrarakhato = new IBurkolatElem[db];

            for (int i = 0; i < burkolodb; i++)
            {
                if (burkoloelemek[i].hovarakhato == Hovarakhato.Fal)
                {
                    falrarakhato[j] = burkoloelemek[i];
                    j++;
                }

            }

            return falrarakhato;

        }

        public IBurkolatElem[] Padloraburkolatlatkivalaszto(LancoltLista burkololaplista)
        {
            int burkolodb = burkololaplista.Lancoltlistadb(burkololaplista);
            IBurkolatElem[] burkoloelemek = burkololaplista.TombkentATartalmak(burkololaplista);
            int j = 0;
            int db = 0;
            for (int i = 0; i < burkolodb; i++)
            {
                if (burkoloelemek[i].hovarakhato == Hovarakhato.Padlo)
                {
                    db++;
                }

            }
            IBurkolatElem[] padlorarakhato = new IBurkolatElem[db];

            for (int i = 0; i < burkolodb; i++)
            {
                if (burkoloelemek[i].hovarakhato == Hovarakhato.Padlo)
                {
                    padlorarakhato[j] = burkoloelemek[i];
                    j++;
                }

            }

            return padlorarakhato;

        }


        public int LakasElemVisszarakas(Lakas lakas)
        {
            int db = 0;
            



            return db;
        }

        public override string ToString()
        {
            return this.Lakasnev;
        }
        static void Keszenvane(bool keszvane)
        {
            if (keszvane)
            {
                Console.WriteLine("Elkészült!");
            }
           


        }



        #region
        /*private Listaelem<T, K> fej;
        private Listaelem<T, K> p;
        private Listaelem<T, K> e;
        
        private Listaelem2<T, K> fej1;
        private Listaelem2<T, K> p1;
        private Listaelem2<T, K> e1;

        #endregion*/


        /* public void Beszur(T burkolatelem, K terulet) //BURKOLATELEM LISTÁJA
         {

             Legkisebbteruletu(uj2, terulet);



                 Listaelem<T, K> uj = new Listaelem<T, K>();
                 uj.Tartalom = burkolatelem;
                 uj.Kulcs = terulet;
                 if (fej == null)   // üres lista
                 {
                     uj.Kovetkezo = null;
                     fej = uj;

                 }
                 else
                 {
                     if (fej.Kulcs.CompareTo(terulet) == -1) // elso elem ele
                     {
                         uj.Kovetkezo = fej;
                         fej = uj;
                     }
                     else
                     {
                         p = fej;
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
                         }

                     }
                 }



         }


         public void Beszur2(T Felulet, K terulet)//FELÜLET LISTÁJA
         {

             Listaelem2<T, K> uj2 = new Listaelem2<T, K>();
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
             }
             //Legkisebbteruletu(uj2);





         }

         private void Legkisebbteruletu(Listaelem2<T, K> uj2 , K terulet)
         {
             Listaelem<T, K> p = fej;

             while (p != null )
             {
                 p = p.Kovetkezo;
                 if (p.Kulcs.CompareTo(terulet)  == 1 )
                 {
                     throw new ArgumentException("ezt az elemet nem szúrhatod be!");
                 }

             }


         }*/
        #endregion
    }
}
