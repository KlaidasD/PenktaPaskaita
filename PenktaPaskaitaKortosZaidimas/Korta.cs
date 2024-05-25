using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PenktaPaskaitaKortosZaidimas
{
    /*
     * Sukurti klasę korta
- Kuri gali turėti 4 skirtingas reiksmes (string) clubs (:clubs:), diamonds (:diamonds:), hearts (:hearts:) and spades (:spades:)
Ir eilesNumeris (string)

(funkcijas kuriame pagrindineje programos klasėje, ne klasėje Korta)

Sukurti funkciją kuri sugeneruoja kortą.
Sukurti funkcija kuri sugeneruoja visa kortų kaladę (be džokerio) (kortos neturi kartotis)

Išspausdinti visą kortų sąrašą.
Sukurti funkcija išmaišyti kortas kuri sumaišo kortas random būdu.
Išspausdinti visą kortų sąrašą. (edited) */

    public class Korta
    {
        public string Spalva;
        public string EilesNumeris;

        public Korta(string spalva, string eilesNumeris)
        {
            Spalva = spalva;
            EilesNumeris = eilesNumeris;
        }

        public override string ToString()
        {
            return $"{EilesNumeris} of {Spalva}";
        }
    }
}
