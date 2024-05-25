using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PenktaPaskaitaKortos
{
    

    public class Zaidejas
    {
        public List<Korta> kortos = new List<Korta>();

        public Zaidejas() 
        {
        
        }

        public void PridetiKorta(Korta korta)
        {
            kortos.Add(korta);
        }

        public int KortuVerte()
        {
            int verte = 0;

            foreach(Korta korta in kortos)
            {
                switch(korta.Nr)
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
