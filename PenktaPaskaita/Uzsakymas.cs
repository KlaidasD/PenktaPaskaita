using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace KetvirtosPaskaitosPaskutineUzduotis

{

    /*Sukurkite klasę Uzsakymas su šiais laukais:
Id(int)
Klientas(string)
Patiekalai(List<Patiekalas>)*/


    public class Uzsakymas
{
        List<Uzsakymas> UzsakymuSarasas = new List<Uzsakymas>();


        public Uzsakymas(List<Uzsakymas> uzsakymuSarasas)
        {
            UzsakymuSarasas = uzsakymuSarasas;
        }

        public int Id;
        public string Klientas;
        public List<Patiekalas> Patiekalai;

        public Uzsakymas(int aId, string aKlientas, List<Patiekalas> aPatiekalai)
        {
            Id = aId;
            Klientas = aKlientas;
            Patiekalai = aPatiekalai;
        }

        public Uzsakymas()
        { 

        }

        public override string ToString()

        {
            return $"{Id}. Klientas: {Klientas}, Patiekalu: {Patiekalai.Count}";
        }
    }


}
