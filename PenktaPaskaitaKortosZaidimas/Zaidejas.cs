using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PenktaPaskaitaKortosZaidimas
{
    /*Sukurti klasę - Žaidėjas kuris turi kortų masyvą arba sąrašą (asmeninis pasirinkimas) (jame 2 kortos)
Sukurti funkcija kuri iš sugeneruotos kortų kaladės duoda dvi atsitiktines kortas Žaidėjui


Sukurti du Žaidėjus pagal klasę Žaidėjas
Žaidėjams padalinti po dvi kortas

Sukurti funkcija kuri IšrinkLaimėtoją(Žaidėjas žaidėjas1, Žaidėjas žaidėjas2) ir grąžina žaidėją kuris laimėjo.

Išvesti laimėjusį žaidėją į ekraną
:*/


    public class Zaidejas
    {
        public List<Korta> Kortos = new List<Korta>();

        public Zaidejas()
        {
            
        }

        public void PridetiKorta(Korta korta)
        {
            Kortos.Add(korta);
        }

        public int KortuVerte()
        {
            int verte = 0;
            foreach (var korta in Kortos)
            {
                switch (korta.EilesNumeris)
                {
                    case "2":
                        verte += 2;
                        break;
                    case "3":
                        verte += 3;
                        break;
                    case "4":
                        verte += 4;
                        break;
                    case "5":
                        verte += 5;
                        break;
                    case "6":
                        verte += 6;
                        break;
                    case "7":
                        verte += 7;
                        break;
                    case "8":
                        verte += 8;
                        break;
                    case "9":
                        verte += 9;
                        break;
                    case "10":
                        verte += 10;
                        break;
                    case "J":
                        verte += 10;
                        break;
                    case "Q":
                        verte += 10;
                        break;
                    case "K":
                        verte += 10;
                        break;
                    case "A":
                        verte += 11;
                        break;
                }
            }
            return verte;
        }
    }
}

        



