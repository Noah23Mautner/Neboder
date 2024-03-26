using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace neboder
{
    internal class neboder
    {
        int visina = 3, brojkatova; //definirali smo vrijednosti

        public int Visina { get => visina; set => visina = value; } //Get uzima vrijednost visine a set postavlja
        public int Brojkatova { get => brojkatova; set => brojkatova = value; }//Get uzima vrijednost broj katova a set postavlja

        public int IzracunajVisinu(int Broj)
        {
         visina = Brojkatova * Visina;//racuna visinu zgrade
        return visina;//vraca vrijednost visine
        }

    }
}
