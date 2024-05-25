/*Aprašymas
Sukurkite restorano užsakymų valdymo sistemą, kuri leis sekti klientų užsakymus ir užsakytų patiekalų būseną.

Sukurkite konsolės programą, kuri leis vartotojui pasirinkti veiksmus (pvz., pridėti patiekalą į meniu, rodyti visus patiekalus,
pridėti užsakymą, keisti patiekalo būseną, rodyti visus užsakymus, rodyti konkretaus užsakymo informaciją).*/

using System;
using System.Collections.Generic;

namespace KetvirtosPaskaitosPaskutineUzduotis
{
    public class Program
    {

        public static void Main(string[] args)
        {

            Restoranas restoranas = new Restoranas();

            Uzsakymas uzsakymas = new Uzsakymas();

            Patiekalas patiekalas = new Patiekalas();




            while (true)
            {

                Console.WriteLine("Sveiki, pasirinkite jusu norima funkcija.");
                Console.WriteLine("1.Prideti patiekala i sarasa.");
                Console.WriteLine("2.Rodyti visus patiekalus.");
                Console.WriteLine("3.Prideti uzsakyma.");
                Console.WriteLine("4.Keisti patiekalo busena.");
                Console.WriteLine("5.Rodyti visus uzsakymus.");
                Console.WriteLine("6.Rodyti uzsakymo informacija.");
                Console.WriteLine("7.Uzdaryti programa.");



                int pasirinkimas = int.Parse(Console.ReadLine());

                if (pasirinkimas == 1)
                {

                    SukurtiPatiekala(restoranas);

                }

                else if (pasirinkimas == 2)
                {
                    restoranas.RodytiVisusPatiekalus();

                }

                else if (pasirinkimas == 3)
                {
                    SukurtiUzsakyma(restoranas);
                    
                }

                else if (pasirinkimas == 4)
                {

                    restoranas.RodytiVisusUzsakymus();

                    Console.WriteLine("Iveskite uzsakymo ID is kurio norite pasirinkti patiekala ir pakeisti jo statusa.");

                    int uzsakymoId;

                    int patiekaloId;


                    if (!int.TryParse(Console.ReadLine(), out uzsakymoId))
                    {
                        Console.WriteLine("Pasirinktas netinkamas uzsakymo Id.");
                        return;
                    }

                    restoranas.GautiUzsakymaPagalId(uzsakymoId);

                    restoranas.RodytiUzsakyma(uzsakymoId);

                    Console.WriteLine("Kurio patiekalo busena is uzsakymo norite keisti?");

                    if (!int.TryParse(Console.ReadLine(), out patiekaloId))
                    {
                        Console.WriteLine("Pasirinktas netinkamas uzsakymo Id.");
                        return;
                    }

                    restoranas.GautiPatiekalaPagalId(patiekaloId);



                    Console.WriteLine("I kokia busena norite pakeisti? Vesti skaiciu (0 - Laukiama, 1 - Ruosiama, 2 - Paruosta)?");
                    int naujaBusena;
                    if (!int.TryParse(Console.ReadLine(), out naujaBusena))
                    {
                        Console.WriteLine("Ivestis neteisinga.");
                    }

                    string snaujaBusena;

                    switch(naujaBusena)
                    {
                        case 0:
                            snaujaBusena = "Laukiama";
                            break;
                        case 1:
                            snaujaBusena = "Ruosiama";
                            break;
                        case 2:
                            snaujaBusena = "Paruosta";
                            break;
                        default:
                            Console.WriteLine("Ivestis neteisinga");
                            return;
                    }

                    restoranas.KeistiPatiekaloBusena(uzsakymoId, patiekaloId, snaujaBusena);
                   
                        
                    
                }
                else if (pasirinkimas == 5)

                {
                    restoranas.RodytiVisusUzsakymus();
                }

                else if (pasirinkimas == 6)
                {
                    restoranas.RodytiVisusUzsakymus();

                    Console.WriteLine("Kurio uzsakymo informacija norite suzinoti?");

                    int uzsakymoId;

                    if (!int.TryParse(Console.ReadLine(), out uzsakymoId))
                    {
                        Console.WriteLine("Pasirinktas netinkamas uzsakymo Id.");
                        return;
                    }

                    restoranas.RodytiUzsakyma(uzsakymoId);


                }

                else if (pasirinkimas == 7)
                {
                    Console.WriteLine("Uzdaroma programa..");
                    Environment.Exit(0); //Kodel neuzdaro programos??
                    
                }
                else
                {
                    Console.WriteLine("Pasirinkimas negalimas.");
                    return;
                }

            }


            }
        public static void SukurtiPatiekala(Restoranas restoranas)

        {

            int patiekaloId = restoranas.GautiPatiekaluKieki() + 1;

            Console.WriteLine("Iveskite patiekalo pavadinima.");

            string pavadinimas = Console.ReadLine();

            Console.WriteLine("Iveskite patiekalo kaina.");

            double kaina;

            if (!double.TryParse(Console.ReadLine(), out kaina))
            {
                Console.WriteLine("Kaina ivesta netinkamai.");
            }

            string busena = " ";

            Patiekalas patiekalas = new Patiekalas(patiekaloId, pavadinimas, kaina, busena);

            restoranas.PridetiPatiekalaIPatiekaluSarasa(patiekalas);




        }

        public static void SukurtiUzsakyma(Restoranas restoranas)

        {
            int aId = restoranas.GautiUzsakymuKieki() + 1;

            Console.WriteLine("Iveskite klienta.");

            string pavadinimas = Console.ReadLine();

            Console.WriteLine("Kiek patiekalu bus uzsakyme?");

            int ivestis;

            if (!int.TryParse(Console.ReadLine(), out ivestis))
            {
                Console.WriteLine("Netinkamai ivestas patiekalu kiekis.");
            }

            List<Patiekalas> patiekalai = new List<Patiekalas>();

            for (int i = 0; i < ivestis; i++)
            {
                restoranas.RodytiVisusPatiekalus();
                Console.WriteLine("Pasirinkit patiekala kuri prideti i uzsakyma");
                Patiekalas nPatiekalas = restoranas.GautiPatiekalaPagalId(int.Parse(Console.ReadLine()));
                patiekalai.Add(nPatiekalas);
            }

            Uzsakymas uzsakymas = new Uzsakymas(aId, pavadinimas, patiekalai);
            restoranas.PridetiUzsakyma(uzsakymas);

        }

    }
        
    }





