using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Kolokwium2poprawa
{
    class Pracownik
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Stanowisko { get; set; }

        public Pracownik(string imie, string nazwisko, string stanowisko)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Stanowisko = stanowisko;
        }

        public void KontaktMailowy(string adres,string tytul,string tresc)
        {
            FileStream FSPlik = new FileStream($"C:\\Projekt\\Email_[{adres}].txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter SWPlik = new StreamWriter(FSPlik);
            SWPlik.WriteLine("dziękuję za kontakt");
            SWPlik.WriteLine(tresc);
            SWPlik.WriteLine(this.Imie+this.Nazwisko+this.Stanowisko);
            SWPlik.Close();
        }
    }
}
