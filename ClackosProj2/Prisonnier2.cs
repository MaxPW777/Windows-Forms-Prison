using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClackosProj2
{
    public class Prisonnier2 : Prisonnier
    {
        public string Infraction { get; set; }
        public string Detail { get; set; }
        public string Peine { get; set; }
        public int Cellule { get; set; }
    }
}
