using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace PenktaPaskaitaMatricosVectoriai
{

 /*
 * Užduotis: Sukurkite programą, kuri atliks šias operacijas su matrica ir vektoriais:

Sukurkite klasę Matrica, kuri turės dvimatį masyvą ir metodus:

IsvestiMatrica - išvesti matricą į konsolę.
Transponuoti - grąžina transponuotą matricą.
Sudeti - sudeda dvi matricas.
Dauginti - daugina matricą iš vektoriaus.
*/

    public class Matrica
    {
        int[,] dvimatis =

        {

            {5, 6, 7, 8 , 7 },
            { 8, 10, 155, 0 ,0},
            { 7, 0, 55, 0, 0}

        };

        public void IsvestiMatrica()
        {
            int x = dvimatis.GetLength(0);
            int y = dvimatis.GetLength(1);

            for(int i = 0; i < x;i++)
            {
                for(int j = 0; j < y;j++)
                {
                    Console.Write(dvimatis[i,j] + "\t");
                }
                Console.WriteLine("");
            }

        }

        public void Transponuoti()
        {
            int x = dvimatis.GetLength(0);
            int y = dvimatis.GetLength(1);

            int[,] transponuota = new int[y,x];

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    transponuota[j, i] = dvimatis[i, j];
                }
            }

            dvimatis = transponuota;

        }

        public void Sudeti()
        {
            int x = dvimatis.GetLength(0);
            int y = dvimatis.GetLength(1);
            int suma = 0;
          

            foreach(int number in dvimatis)
            {
                suma += number;
            }
            
            Console.WriteLine($"Matricos suma yra:{suma}");
        }

    }


    
}
