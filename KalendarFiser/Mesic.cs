using System.Globalization;

namespace KalendarFiser
{
    public class Mesic
    {
        public int CisloMesice { get; set; }

        public Mesic(int cislo)
        {
            CisloMesice = cislo;
        }

        public override string ToString()
        {
            return DateTimeFormatInfo.CurrentInfo.GetMonthName(CisloMesice);
        }

        // Přetížení operátoru ++
        public static Mesic operator ++(Mesic m)
        {
            if (m.CisloMesice == 12)
            {
                m.CisloMesice = 1; // Přechod na leden
            }
            else
            {
                m.CisloMesice++;
            }
            return m;
        }

        // Přetížení operátoru --
        public static Mesic operator --(Mesic m)
        {
            if (m.CisloMesice == 1)
            {
                m.CisloMesice = 12; // Přechod na prosinec
            }
            else
            {
                m.CisloMesice--;
            }
            return m;
        }

        // Situace kdy je potřeba převést int na Mesic
        public static implicit operator Mesic(int cislo)
        {
            return new Mesic(cislo);
        }

        // Situace kdy je potřeba převést Mesic na int
        public static implicit operator int(Mesic m)
        {
            // Pokud by náhodou byl objekt null, vrátí se -1 jako chyba
            if (m == null) return -1;

            return m.CisloMesice;
        }
    }
}
