using System;
using System.Collections.Generic;
using System.Text;

namespace Kolokwium2poprawa
{
    class SMS
    {
        public string Tekst { get; set; }
        public int CzasOtrzymania { get; set; }

        public SMS(string tekst, int czasOtrzymania)
        {
            Tekst = tekst;
            CzasOtrzymania = czasOtrzymania;
        }
        public void StronaWynikow(int nrstrony)
        {

        }
    }
}
