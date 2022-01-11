using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    public class Osoba : ICloneable
    {
        public string imie, nazwisko;
        public int wiek;
        public Osoba()
        { }
        public Osoba(string imie, string nazwisko, int wiek)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.wiek = wiek;
        }
        public void Kopiuj(Osoba o1, Osoba o2)
        {
            try
            {
                o2.imie = o1.imie;
                o2.nazwisko = o1.nazwisko;
                o2.wiek = o1.wiek;
            }
            catch (Exception e)
            {
                Console.WriteLine("Metoda nie może przyjmować parametru null");
            }
        }
        public object Clone()
        {
            throw new NotImplementedException();
        }
        public Osoba Kopiuj2()
        {
            try
            {
                return (Osoba)MemberwiseClone();
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
