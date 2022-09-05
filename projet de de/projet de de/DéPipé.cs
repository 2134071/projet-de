using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_de_de
{
    internal class Depipe : dé
    {
        public Depipe(int nombreDeFaces, Random face) : base(nombreDeFaces, face)
        {
            nombreDeFaces = 6;

        }
    }
}
