using System;
using System.Collections.Generic;
using System.Linq;

namespace Kolokwium2poprawa
{
    class Program
    {
        static void Main(string[] args)
        {
            Pracownik Pracownik = new Pracownik("Marcin", "Banas", "Ksiegowy");
            Pracownik.KontaktMailowy("mb@gmail.com", "Oplata", "Oplata....");
            Pracownik.KontaktMailowy("mb@gmail.com", "Oplata", "Oplata za podatek");

            List<SMS> ListaSms = new List<SMS>();

            Random rnd = new Random();

            SMS sms1 = new SMS("a", rnd.Next(0,24));
            SMS sms2 = new SMS("b", rnd.Next(0, 24));
            SMS sms3 = new SMS("c", rnd.Next(0, 24));

            ListaSms.Add(sms1);
            ListaSms.Add(sms2);
            ListaSms.Add(sms3);

            Console.WriteLine("Jakiego slowa szukasz: ");
            string slowo = Console.ReadLine();

            var q1 = ListaSms.Select(n => n).Where(a => a.Tekst == slowo).ToArray();
            foreach (var item in q1)
            {
                Console.WriteLine(item.Tekst+" "+item.CzasOtrzymania);
            }

            Wyprzedaz<Oferta> wyprzedaz = new Wyprzedaz<Oferta>(10);
            Gips gips = new Gips("Budowlany",10);
            wyprzedaz.WypszCene(gips);
        }
    }
}
