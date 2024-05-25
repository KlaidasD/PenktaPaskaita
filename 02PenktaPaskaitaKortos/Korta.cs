using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PenktaPaskaitaKortos
{
        public class Korta
        {

        public string Spalva;
        public string Nr;

        public Korta(string aSpalva, string aNr)
        {
            Spalva = aSpalva;
            Nr = aNr;
        }

        public override string ToString()
        {
            return $"{Nr} of {Spalva}";
        }
    }
}

