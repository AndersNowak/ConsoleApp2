using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Erik
    {
        

        public string Navn { get; }
        public int Alder { get; }

        public Erik(string navn, int alder, bool talerHurtigt)
        {
            Navn = navn;
            Alder = alder;
            
        }
    }
}
