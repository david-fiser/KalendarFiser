using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalendarFiser
{
    public class DataModel
    {
        public List<Udalost> Udalosti { get; set; } = new List<Udalost>();
        public List<Poznamka> Poznamky { get; set; } = new List<Poznamka>();
    }
}
