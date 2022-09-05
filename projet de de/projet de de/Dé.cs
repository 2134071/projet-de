using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_de_de
{
    abstract class dé
    {
       private int NombreDeFaces;
       private Random Face;

        protected dé(int nombreDeFaces, Random face)
        {
            NombreDeFaces = nombreDeFaces;
            Face = face;
        }
    }
}
