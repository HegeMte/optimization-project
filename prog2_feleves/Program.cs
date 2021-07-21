using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog2_feleves
{
    class Program
    {
        #region
        static void IR(string[] a, string[] opcio)
        {
            
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.Write("\t\tBurkoló program v0.1\n\n");
            Console.ForegroundColor = ConsoleColor.DarkGray;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == ">")
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine(a[i] + " " + opcio[i]);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine(a[i] + " " + opcio[i]);
                }


            }
        }
        #endregion
        static void Main(string[] args)
        {
            Parketta parketta = new Parketta("Világosbarna Parketta", 5, 5, 25, Hovarakhato.Padlo);
            Parketta sotetparketta = new Parketta("Sötétbarna Parketta", 6, 6, 40, Hovarakhato.Padlo);
            Parketta szalagparketta = new Parketta("Szalagparketta", 5, 6, 30, Hovarakhato.Padlo);
            Parketta feketeparketta = new Parketta("Fekete parketta", 7, 8, 28, Hovarakhato.Padlo);
            Parketta akacparketta = new Parketta("Akác parketta", 8, 8, 40, Hovarakhato.Padlo);
            Csempe csempe = new Csempe("Kék Csempe", 3, 5, 30, Hovarakhato.Fal);
            Csempe fehercsempe = new Csempe("Fehér csempe", 4, 6, 45, Hovarakhato.Fal);
            Csempe mozaikcsempe = new Csempe("Mozaik Csempe", 4, 3, 56, Hovarakhato.Fal);
            Csempe royalcsempe = new Csempe("Royal Csempe", 7, 2, 60, Hovarakhato.Fal);
            Csempe barnacsempe = new Csempe("Barna csempe", 4, 8, 55, Hovarakhato.Fal);
            Csempe recescsempe = new Csempe("Recés csempe", 7, 8, 30, Hovarakhato.Fal);
            Csempe kockascsempe = new Csempe("Kockás mintájú csempe", 8, 8, 38, Hovarakhato.Fal);




            // első lakás

            Konyha konyhafal = new Konyha(9, 13, FeluletTipus.Fal);
            Konyha konyhapadlo = new Konyha(15, 20, FeluletTipus.Padlo);
            Nappali nappalifal = new Nappali(10, 14, FeluletTipus.Fal);
            Nappali nappalipadlo = new Nappali(20, 20, FeluletTipus.Padlo);
            Haloszoba haloszobafal = new Haloszoba(10, 10, FeluletTipus.Fal);
            Haloszoba haloszobapadlo = new Haloszoba(10, 14, FeluletTipus.Padlo);
            Furdo furdoszobapadlo = new Furdo(10, 11, FeluletTipus.Padlo);
            Furdo furdoszobafal = new Furdo(11, 12, FeluletTipus.Fal);


            Lakas lakas = new Lakas("Rózsa utcai Lakás ", konyhafal, konyhapadlo, nappalifal, nappalipadlo, haloszobafal, haloszobapadlo, furdoszobafal, furdoszobapadlo);

            
            //Második lakás
            Konyha konyhafal2 = new Konyha(10, 13, FeluletTipus.Fal);
            Konyha konyhapadlo2 = new Konyha(11, 18, FeluletTipus.Padlo);
            Nappali nappalifal2 = new Nappali(11, 21, FeluletTipus.Fal);
            Nappali nappalipadlo2 = new Nappali(15, 15, FeluletTipus.Padlo);
            Haloszoba haloszobafal2 = new Haloszoba(9, 10, FeluletTipus.Fal);
            Haloszoba haloszobapadlo2 = new Haloszoba(14, 11, FeluletTipus.Padlo);
            Furdo furdoszobapadlo2= new Furdo(12, 10, FeluletTipus.Padlo);
            Furdo furdoszobafal2 = new Furdo(8, 13, FeluletTipus.Fal);
            Lakas lakas2 = new Lakas("Hársfa úti Lakás ", konyhafal2, konyhapadlo2, nappalifal2, nappalipadlo2, haloszobafal2, haloszobapadlo2, furdoszobafal2, furdoszobapadlo2);

            //HARMADIK lakás
            Konyha konyhafal3 = new Konyha(10, 10, FeluletTipus.Fal);
            Konyha konyhapadlo3 = new Konyha(10, 16, FeluletTipus.Padlo);
            Nappali nappalifal3 = new Nappali(11, 18, FeluletTipus.Fal);
            Nappali nappalipadlo3 = new Nappali(20, 15, FeluletTipus.Padlo);
            Haloszoba haloszobafal3 = new Haloszoba(11, 10, FeluletTipus.Fal);
            Haloszoba haloszobapadlo3 = new Haloszoba(20, 20, FeluletTipus.Padlo);
            Furdo furdoszobapadlo3 = new Furdo(12, 10, FeluletTipus.Padlo);
            Furdo furdoszobafal3 = new Furdo(9, 12, FeluletTipus.Fal);
            Lakas lakas3 = new Lakas("Liget úti Lakás ", konyhafal3, konyhapadlo3, nappalifal3, nappalipadlo3, haloszobafal3, haloszobapadlo3, furdoszobafal3, furdoszobapadlo3);

            //Negyedik Lakás
            Konyha konyhafal4 = new Konyha(11, 10, FeluletTipus.Fal);
            Konyha konyhapadlo4 = new Konyha(19, 15, FeluletTipus.Padlo);
            Nappali nappalifal4 = new Nappali(11, 14, FeluletTipus.Fal);
            Nappali nappalipadlo4 = new Nappali(14, 15, FeluletTipus.Padlo);
            Haloszoba haloszobafal4 = new Haloszoba(11, 10, FeluletTipus.Fal);
            Haloszoba haloszobapadlo4 = new Haloszoba(10, 20, FeluletTipus.Padlo);
            Furdo furdoszobapadlo4 = new Furdo(18, 10, FeluletTipus.Padlo);
            Furdo furdoszobafal4 = new Furdo(9, 12, FeluletTipus.Fal);
            Lakas lakas4 = new Lakas("Petőfi úti Lakás ", konyhafal4, konyhapadlo4, nappalifal4, nappalipadlo4, haloszobafal4, haloszobapadlo4, furdoszobafal4, furdoszobapadlo4);


            //Ötödik Lakás
            Konyha konyhafal5 = new Konyha(9, 8, FeluletTipus.Fal);
            Konyha konyhapadlo5 = new Konyha(9, 8, FeluletTipus.Padlo);
            Nappali nappalifal5 = new Nappali(9, 8, FeluletTipus.Fal);
            Nappali nappalipadlo5 = new Nappali(9, 8, FeluletTipus.Padlo);
            Haloszoba haloszobafal5 = new Haloszoba(9, 8, FeluletTipus.Fal);
            Haloszoba haloszobapadlo5 = new Haloszoba(9, 8, FeluletTipus.Padlo);
            Furdo furdoszobapadlo5 = new Furdo(8, 9, FeluletTipus.Padlo);
            Furdo furdoszobafal5 = new Furdo(8, 9, FeluletTipus.Fal);
            Lakas lakas5 = new Lakas("Mini Lakás     ", konyhafal5, konyhapadlo5, nappalifal5, nappalipadlo5, haloszobafal5, haloszobapadlo5, furdoszobafal5, furdoszobapadlo5);

            Lakas[] lakasok = { lakas, lakas2,lakas3,lakas4 , lakas5 };
            Lakas[] keszlakasok = new Lakas[lakasok.Length];
            LancoltLista burkoloelemlista = new LancoltLista();
            LancoltLista feluletlista = new LancoltLista();
            

            //1
            feluletlista.Beszur2(konyhafal);
            feluletlista.Beszur2(nappalifal);
            feluletlista.Beszur2(konyhapadlo);
            feluletlista.Beszur2(nappalipadlo);
            feluletlista.Beszur2(haloszobafal);
            feluletlista.Beszur2(haloszobapadlo);
            feluletlista.Beszur2(furdoszobafal);
            feluletlista.Beszur2(furdoszobapadlo);





            //2
            feluletlista.Beszur2(konyhafal2);
            feluletlista.Beszur2(nappalifal2);
            feluletlista.Beszur2(konyhapadlo2);
            feluletlista.Beszur2(nappalipadlo2);
            feluletlista.Beszur2(haloszobafal2);
            feluletlista.Beszur2(haloszobapadlo2);
            feluletlista.Beszur2(furdoszobafal2);
            feluletlista.Beszur2(furdoszobapadlo2);

            bool hibavolte = false;
            try
            {
                burkoloelemlista.Beszur(parketta, feluletlista);
                burkoloelemlista.Beszur(csempe, feluletlista);
                burkoloelemlista.Beszur(fehercsempe, feluletlista);
                burkoloelemlista.Beszur(sotetparketta, feluletlista);
                burkoloelemlista.Beszur(mozaikcsempe, feluletlista);
                burkoloelemlista.Beszur(szalagparketta, feluletlista);
                burkoloelemlista.Beszur(royalcsempe, feluletlista);
                burkoloelemlista.Beszur(barnacsempe, feluletlista);
                burkoloelemlista.Beszur(recescsempe, feluletlista);
                burkoloelemlista.Beszur(feketeparketta, feluletlista);
                burkoloelemlista.Beszur(akacparketta, feluletlista);
                burkoloelemlista.Beszur(kockascsempe, feluletlista);


            }
            catch (HibaException hiba)
            {
                Console.WriteLine(hiba.Message);
                hibavolte = true;
            }

            

           
            
            //lakas2.FalBurkolas(feluletlista, burkoloelemlista, lakas2);



            //burkoloelemlista.ListaBejaras();


            if (hibavolte == false)
            {
                string[] a = { ">", "", "", "" };
                string[] opcio = { "Optimális megoldás megtekintése", "Lakások állapotának megtekintése ", "Burkolólapok megtekintése", "Kilépés" };
                bool vissza = true;
                ConsoleKeyInfo cki;
                do
                {
                    Console.Clear();
                    IR(a, opcio);
                    do
                    {
                        #region Billentyűzet kezelés
                        cki = Console.ReadKey(true);
                        if (cki.Key == ConsoleKey.DownArrow)
                        {
                            Console.Write("\b");
                            try
                            {
                                for (int i = 0; i < a.Length; i++)
                                {
                                    if (a[i] == ">" && (i <= a.Length && i >= 0))
                                    {

                                        if (i == 3)
                                        {
                                            throw new TulindexelesException();
                                        }
                                        a[i + 1] = ">";
                                        a[i] = " ";
                                        i++;
                                    }
                                }
                            }
                            catch (TulindexelesException hiba)
                            {
                                Console.WriteLine(hiba.Message);
                            }
                        }
                        if (cki.Key == ConsoleKey.UpArrow)
                        {
                            Console.Write("\b");

                            try
                            {
                                for (int i = 0; i < a.Length; i++)
                                {
                                    if (a[i] == ">")
                                    {
                                        if (i == 0)
                                        {
                                            throw new TulindexelesException();
                                        }

                                        a[i - 1] = ">";
                                        a[i] = " ";
                                        i++;
                                    }
                                }
                            }
                            catch (TulindexelesException hiba)
                            {
                                Console.WriteLine(hiba.Message);
                            }
                        }
                        if (cki.Key == ConsoleKey.Enter)
                        {
                            Console.Write("\b");
                            for (int i = 0; i < a.Length; i++)
                            {
                                if (a[i] == ">")
                                {
                                    if (i == 3)
                                    {
                                        Environment.Exit(0);
                                    }
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.DarkGray;

                                    if (i == 0)
                                    {
                                        Optimalismegoldasmegtekinto();
                                        LakasBurkolasbts(lakasok, 0, ref keszlakasok, burkoloelemlista, -1);
                                        
                                        Lakas[] fixkeszlakasok = vizsgalo(keszlakasok);
                                        
                                        
                                        for (int z = 0; z < fixkeszlakasok.Length; z++)
                                        {



                                            fixkeszlakasok[z].LakasBurkolas(burkoloelemlista, fixkeszlakasok[z]);
                                                
                                            
                                            
                                        }
                                        

                                    }
                                    if (i == 1)
                                    {
                                        Lakasmegtekinto();
                                        Lakas[] fixkeszlakasok = vizsgalo(keszlakasok);
                                        for (int u = 0; u < fixkeszlakasok.Length; u++)
                                        {
                                            if (fixkeszlakasok[u].Keszvane == false && fixkeszlakasok[u].konyhafal.legjobbburkolo != null && fixkeszlakasok[u].konyhapadlo.legjobbburkolo != null && fixkeszlakasok[u].nappalifal.legjobbburkolo != null && fixkeszlakasok[u].nappalipadlo.legjobbburkolo != null)
                                            {

                                                Console.Write("Lakás neve: " + fixkeszlakasok[u].Lakasnev);
                                                fixkeszlakasok[u].Keszvane = true;
                                                


                                            }
                                        }



                                    }
                                    if (i == 2)
                                    {
                                        Burkololaphozzaadas(burkoloelemlista);
                                    }
                                    goto kiter;
                                    //vissza = false;
                                }

                            }
                        }
                        #endregion
                        IR(a, opcio);


                    } while (vissza);
                kiter:

                    cki = Console.ReadKey(true);
                } while (cki.Key == ConsoleKey.Backspace); // Menürendszer


                
            }
            
            Console.ReadKey();
        }


        #region

        static void Optimalismegoldasmegtekinto()
        {

            Console.WriteLine("Optimális megoldás megtekintése");
            


        }

        static void Lakasmegtekinto()
        {
            Console.WriteLine("Lakások megtekintése ");
        }

        static void Burkololaphozzaadas(LancoltLista burkolaplista)
        {

            burkolaplista.ListaBejaras();

        }
       
        static void LakasBurkolasbts(Lakas[] lakasok, int szint, ref Lakas[] keszlakasok, LancoltLista burkololaplista,int i) // hanyadik szintről indítjuk
        {


            //Lakas[] keszlakasok = new Lakas[lakasok.Length];

           

            bool van = false;
            while (!van && i < lakasok.Length - 1)
            {

                i++;

                //burkolo metodus

                //if (lakasok[szint].keszvane == true)
                if (Burkolometodus(lakasok, szint, burkololaplista))//ha sikerült leburkolni a lakást , belép
                {
                    keszlakasok[i] = lakasok[szint];
                    if (szint == lakasok.Length - 1)
                    {
                        van = true;
                    }
                    else
                    {
                        LakasBurkolasbts(lakasok, szint + 1, ref keszlakasok, burkololaplista,i);
                    }

                }
                if (szint +1 > lakasok.Length -1 )// ha az utolsó lakást nem sikerült volna leburkolni
                {
                    break;
                }
                else
                {
                    szint++;//ha az első lakást nem sikerült volna leburkolni,akkor is lépni kell a lakások tömbbön
                }


            }



        }

        static bool Burkolometodus(Lakas[] lakasok, int szint, LancoltLista burkololaplista)
        {

            bool ok = false;

            lakasok[szint].NappaliFalBurkolas(burkololaplista, lakasok[szint]);
            lakasok[szint].NappaliPadloBurkolas(burkololaplista, lakasok[szint]);
            lakasok[szint].KonyhaFalBurkolas(burkololaplista, lakasok[szint]);
            lakasok[szint].KonyhaPadloBurkolas(burkololaplista, lakasok[szint]);
            lakasok[szint].HaloszobaFalBurkolas(burkololaplista, lakasok[szint]);
            lakasok[szint].HaloszobaPadloBurkolas(burkololaplista, lakasok[szint]);
            lakasok[szint].FurdoszobaFalBurkolas(burkololaplista, lakasok[szint]);
            lakasok[szint].FurdoszobaPadloBurkolas(burkololaplista, lakasok[szint]);


            if (lakasok[szint].nappalifal.legjobbburkolo != null && lakasok[szint].nappalipadlo.legjobbburkolo != null && lakasok[szint].konyhafal.legjobbburkolo != null && lakasok[szint].konyhapadlo.legjobbburkolo != null && lakasok[szint].haloszobafal.legjobbburkolo != null && lakasok[szint].haloszobapadlo.legjobbburkolo != null && lakasok[szint].furdoszobafal.legjobbburkolo != null && lakasok[szint].furdoszobapadlo.legjobbburkolo != null)
            {
                ok = true;
            }
            else
            {
                if (lakasok[szint].nappalifal.legjobbburkolo != null)
                {
                    lakasok[szint].nappalifal.legjobbburkolo.darabszam += lakasok[szint].nappalifal.felhasznaltdb;
                    lakasok[szint].nappalifal.legjobbburkolo = null;
                    lakasok[szint].nappalifal.felhasznaltdb = 0;
                }
                if (lakasok[szint].nappalipadlo.legjobbburkolo != null)
                {
                    lakasok[szint].nappalipadlo.legjobbburkolo.darabszam += lakasok[szint].nappalipadlo.felhasznaltdb;
                    lakasok[szint].nappalipadlo.legjobbburkolo = null;
                    lakasok[szint].nappalipadlo.felhasznaltdb = 0;
                }
                if (lakasok[szint].konyhafal.legjobbburkolo != null)
                {
                    lakasok[szint].konyhafal.legjobbburkolo.darabszam += lakasok[szint].konyhafal.felhasznaltdb;
                    lakasok[szint].konyhafal.legjobbburkolo = null;
                    lakasok[szint].konyhafal.felhasznaltdb = 0;
                }
                if (lakasok[szint].konyhapadlo.legjobbburkolo != null)
                {
                    lakasok[szint].konyhapadlo.legjobbburkolo.darabszam += lakasok[szint].konyhapadlo.felhasznaltdb;
                    lakasok[szint].konyhapadlo.legjobbburkolo = null;
                    lakasok[szint].konyhapadlo.felhasznaltdb = 0;
                }
                if (lakasok[szint].haloszobafal.legjobbburkolo != null)
                {
                    lakasok[szint].haloszobafal.legjobbburkolo.darabszam += lakasok[szint].haloszobafal.felhasznaltdb;
                    lakasok[szint].haloszobafal.legjobbburkolo = null;
                    lakasok[szint].haloszobafal.felhasznaltdb = 0;
                }
                if (lakasok[szint].haloszobapadlo.legjobbburkolo != null)
                {
                    lakasok[szint].haloszobapadlo.legjobbburkolo.darabszam += lakasok[szint].haloszobapadlo.felhasznaltdb;
                    lakasok[szint].haloszobapadlo.legjobbburkolo = null;
                    lakasok[szint].haloszobapadlo.felhasznaltdb = 0;
                }
                if (lakasok[szint].furdoszobafal.legjobbburkolo != null)
                {
                    lakasok[szint].furdoszobafal.legjobbburkolo.darabszam += lakasok[szint].furdoszobafal.felhasznaltdb;
                    lakasok[szint].furdoszobafal.legjobbburkolo = null;
                    lakasok[szint].furdoszobafal.felhasznaltdb = 0;
                }
                if (lakasok[szint].furdoszobapadlo.legjobbburkolo != null)
                {
                    lakasok[szint].furdoszobapadlo.legjobbburkolo.darabszam += lakasok[szint].furdoszobapadlo.felhasznaltdb;
                    lakasok[szint].furdoszobapadlo.legjobbburkolo = null;
                    lakasok[szint].furdoszobapadlo.felhasznaltdb = 0;
                }


            }

            return ok;

        }


        static Lakas [] vizsgalo(Lakas[] keszlakasok)
        {
            Lakas[] fixkeszlakasok;
            int db = 0;
            for (int i = 0; i < keszlakasok.Length; i++)
            {
                if (keszlakasok[i] !=null)
                {
                    db++;
                }
            }
            fixkeszlakasok =new Lakas [db];
            db = 0;

            for (int j = 0; j < keszlakasok.Length; j++)
            {
                if(keszlakasok[j] != null)
                {
                    fixkeszlakasok[db] = keszlakasok[j];
                    db++;
                }
            }

            return fixkeszlakasok;
        }
    }
    #endregion
    class TulindexelesException : Exception
    {
        public TulindexelesException():base("Túlléptél a megadott lehetőségeken!")
        {

        }

    }
}
