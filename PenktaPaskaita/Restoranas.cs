using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace KetvirtosPaskaitosPaskutineUzduotis

{
    /*Sukurkite klasę Restoranas, kuri turės metodus:
PridetiPatiekalaIPateikalauSarasa(Patiekalas patiekalas): Prideda patiekalą į restorano meniu.
RodytiVisusPatiekalus(): Išspausdina visų patiekalų sąrašą.
PridetiUzsakyma(Uzsakymas uzsakymas): Prideda naują užsakymą.
KeistiPatiekaloBusena(int uzsakymoId, int patiekaloId, string naujaBusena): Keičia patiekalo būseną užsakyme.
RodytiVisusUzsakymus(): Išspausdina visų užsakymų sąrašą.
RodytiUzsakyma(int uzsakymoId): Išspausdina konkretaus užsakymo informaciją.*/

    public class Restoranas
{
        List<Patiekalas> PatiekaluSarasas = new List<Patiekalas>();
        List<Uzsakymas> UzsakymuSarasas = new List<Uzsakymas>();

        public Restoranas(List<Uzsakymas> uzsakymuSarasas)
        {
            UzsakymuSarasas = uzsakymuSarasas;
        }

        public int GautiPatiekaluKieki()

        {
            return PatiekaluSarasas.Count;
        }

        public int GautiUzsakymuKieki()

        {
            return UzsakymuSarasas.Count;
        }

        public Patiekalas GautiPatiekalaPagalId(int id)
        {
            foreach(Patiekalas patiekalas in PatiekaluSarasas)
            {
                if(patiekalas.Id == id)
                {
                    return patiekalas;
                }
            }

            return null;

        }

        public Uzsakymas GautiUzsakymaPagalId(int id)

        {
            foreach (Uzsakymas uzsakymas in UzsakymuSarasas)
            {
                if (uzsakymas.Id == id)
                {
                    return uzsakymas;
                }
            }

            return null;

        }
            

        public Restoranas(List<Patiekalas> patiekaluSarasas)
        {
            PatiekaluSarasas = patiekaluSarasas;
        }

        public Restoranas()
        {

        }


        public void PridetiPatiekalaIPatiekaluSarasa(Patiekalas patiekalas)
        {

            PatiekaluSarasas.Add(patiekalas);

            Console.WriteLine("Sekmingai pridetas patiekalas.");

        }

        public void RodytiVisusPatiekalus()
        {
            Console.WriteLine("Atspausdinamas patiekalu sarasas.");
            for (int i = 0; i < PatiekaluSarasas.Count; i++)
            {
                Console.WriteLine(PatiekaluSarasas[i]);
            }

        }

        public void PridetiUzsakyma(Uzsakymas uzsakymas)
        {

            UzsakymuSarasas.Add(uzsakymas);

            Console.WriteLine("Sekmingai pridetas uzsakymas.");


        }
        
        public void KeistiPatiekaloBusena(int uzsakymoId, int patiekaloId, string naujaBusena)
        {
            if(uzsakymoId > UzsakymuSarasas.Count && patiekaloId > PatiekaluSarasas.Count)
            {
                Console.WriteLine("Pasirinkimas negalimas.");
                return;
            }

            foreach(Uzsakymas uzsakymas in UzsakymuSarasas)
            {
                if(uzsakymas.Id == uzsakymoId)
                {
                    foreach(Patiekalas patiekalas in PatiekaluSarasas)
                    {
                        if(patiekalas.Id == patiekaloId)
                        {
                            patiekalas.Busena = naujaBusena;
                        }
                        
                    }
                }

            }

            Console.WriteLine("Busena sekmingai pakeista");

        }

        public void RodytiVisusUzsakymus()
        {
            Console.WriteLine("Atspausdinamas uzsakymu sarasas.");
            for (int i = 0; i < UzsakymuSarasas.Count; i++)
            {
                Console.WriteLine(UzsakymuSarasas[i]);
            }
        }

        public void RodytiUzsakyma(int uzsakymoId)
        {

            foreach (Uzsakymas uzsakymas in UzsakymuSarasas)
            {
                if(uzsakymas.Id == uzsakymoId)
                {
                    RodytiVisusPatiekalus();
                }
            }

           
        }
        
}

}
