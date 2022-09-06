using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_de_de
{
    internal class DeOrdinaire : Controler
    {
        int valeurDuDe;
        Random Face = new Random();

        public DeOrdinaire(int nombreDeFaces, string type) : base(nombreDeFaces, type)
        {
            this.Type = "dé ordinaire";
        }

        public int ValeurDuDe { get => valeurDuDe; set => valeurDuDe = value; }

        public override int Brasser()
        {
           ValeurDuDe = Face.Next(1, NombreDeFaces+1);
            return ValeurDuDe;
        }

        public override int PointDuDe()
        {
            Point =  ValeurDuDe;
                return ValeurDuDe;
        }
    }
}
