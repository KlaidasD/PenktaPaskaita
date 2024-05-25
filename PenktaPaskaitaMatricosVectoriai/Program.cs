/*
 * Užduotis: Sukurkite programą, kuri atliks šias operacijas su matrica ir vektoriais:

Sukurkite klasę Matrica, kuri turės dvimatį masyvą ir metodus:

IsvestiMatrica - išvesti matricą į konsolę.
Transponuoti - grąžina transponuotą matricą.
Sudeti - sudeda dvi matricas.
Dauginti - daugina matricą iš vektoriaus.
Sukurkite klasę Vektorius, kuri turės vienmatį masyvą ir metodą:
IsvestiVektorius - išvesti vektorių į konsolę.
*/

using System;

namespace PenktaPaskaitaMatricosVectoriai
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Matrica matrica = new Matrica(); 
            
            matrica.IsvestiMatrica();
            matrica.Transponuoti();
            matrica.IsvestiMatrica();
            matrica.Sudeti();

        }
    }
}

