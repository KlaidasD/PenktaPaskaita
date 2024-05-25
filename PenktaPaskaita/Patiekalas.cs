using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetvirtosPaskaitosPaskutineUzduotis

{
  

    /*Sukurkite klasę Patiekalas su šiais laukais:
Id(int)
Pavadinimas(string)
Kaina(double)
Busena(string) – gali būti "Laukiama", "Ruošiama", "Paruošta"*/

    public class Patiekalas
{
        List<Patiekalas> PatiekaluSarasas = new List<Patiekalas>();

        public Patiekalas(List<Patiekalas> patiekaluSarasas)
        {
            PatiekaluSarasas = patiekaluSarasas;
        }

        public int Id;
        public string Pavadinimas;
        public double Kaina;
        public string Busena;

        public Patiekalas(int aId, string aPavadinimas, double aKaina, string aBusena)
        {
            Id = aId;
            Pavadinimas = aPavadinimas;
            Kaina = aKaina;
            Busena = aBusena;
        }

        public Patiekalas()
        {

        }

        public override string ToString()

        {
            return $"{Id}. Pavadinimas: {Pavadinimas}, Kaina: {Kaina}, Busena: {Busena}";
        }


    }


}
