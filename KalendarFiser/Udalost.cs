using System;

namespace KalendarFiser
{
    public class Udalost
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime DatumACas { get; set; }
        public string Nazev { get; set; }
        public string Popis { get; set; }
        public bool UpominkaNastavena { get; set; }
        public DateTime UpominkaCas { get; set; }
        public bool UpominkaZobrazena { get; set; }

        public override string ToString()
        {
            return $"{DatumACas:HH:mm} - {Nazev}";
        }
    }
}
