using System;

namespace KalendarFiser
{
    public class Udalost
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime DatumACas { get; set; }
        public string Nazev { get; set; }
        public string Popis { get; set; }
    }
}
