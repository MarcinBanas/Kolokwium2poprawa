using System;
using System.Collections.Generic;
using System.Text;


namespace Kolokwium2poprawa
{
    class Wyprzedaz<Oferta>
    {
        public double WysokoscPromocji { get; set; }

        public Wyprzedaz(int wysokoscPromocji)
        {
            WysokoscPromocji = wysokoscPromocji;
        }

        public void WypszCene(Gips obj)
        {
            Console.WriteLine("Nazwa produktu: "+ obj.Nazwa+" Cena po promocji: "+obj.Cena*(WysokoscPromocji/100));
        }
    }
}
