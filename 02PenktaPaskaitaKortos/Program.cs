using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PenktaPaskaitaKortos
{
    class Program
    {
        static Random rnd = new Random();

        static Korta SugeneruotiKorta(string aSpalva, string aNr)
        {
            return new Korta(aSpalva, aNr);
        }

        static List<Korta> SugeneruotiKalade()
        {
            string[] spalvos = { "Clubs", "Diamonds", "Hearts", "Spades" };
            string[] eilesNumeriai = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

            List<Korta> kalade = new List<Korta>();

            foreach (string spalva in spalvos)
            {
                foreach (string eilesNumeris in eilesNumeriai)
                {
                    kalade.Add(SugeneruotiKorta(spalva, eilesNumeris));
                }
            }
            return kalade;
        }

        static void IsmaisytiKalade(List<Korta> kalade)
        {
            for (int i = 0; i < kalade.Count; i++)
            {
                int j = rnd.Next(kalade.Count);
                Korta temp = kalade[i];
                kalade[i] = kalade[j];
                kalade[j] = temp;
            }
        }

        static void SpausdintiKalade(List<Korta> kalade)
        {
            foreach (Korta korta in kalade)
            {
                Console.WriteLine(korta);
            }
        }

        static void PadalintiKortas(Zaidejas zaidejas, List<Korta> kalade)
        {
            zaidejas.PridetiKorta(kalade[0]);
            kalade.RemoveAt(0);
            zaidejas.PridetiKorta(kalade[0]);
            kalade.RemoveAt(0);
        }

        static Zaidejas IsrinkLaimetoja(Zaidejas zaidejas1, Zaidejas zaidejas2)
        {
            int verte1 = zaidejas1.KortuVerte();
            int verte2 = zaidejas2.KortuVerte();

            if (verte1 > verte2)
            {
                return zaidejas1;
            }
            else
            {
                return zaidejas2;
            }
        }

        static void Main(string[] args)
        {
            List<Korta> kalade = SugeneruotiKalade();
            Console.WriteLine("Originali kalade:");
            SpausdintiKalade(kalade);

            IsmaisytiKalade(kalade);
            Console.WriteLine("\nIsmaisyta kalade:");
            SpausdintiKalade(kalade);

            Zaidejas zaidejas1 = new Zaidejas();
            Zaidejas zaidejas2 = new Zaidejas();

            PadalintiKortas(zaidejas1, kalade);
            PadalintiKortas(zaidejas2, kalade);

            Console.WriteLine("\nZaidejo 1 kortos:");
            foreach (var korta in zaidejas1.kortos)
            {
                Console.WriteLine(korta);
            }

            Console.WriteLine("\nZaidejo 2 kortos:");
            foreach (var korta in zaidejas2.kortos)
            {
                Console.WriteLine(korta);
            }

            Zaidejas laimetojas = IsrinkLaimetoja(zaidejas1, zaidejas2);
            Console.WriteLine($"\nLaimetojas yra zaidejas su {laimetojas.KortuVerte()} tasku!");
        }
    }
}




