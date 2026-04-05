using System;

namespace KalendarFiser
{
    public class Poznamka
    {
        public DateTime Datum { get; set; }
        public string Text { get; set; }
        public Poznamka(DateTime datum, string text)
        {
            Datum = datum.Date;
            Text = text;
        }
    }
}
