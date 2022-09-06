using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_de_de
{
    internal class Depipe : Controler
    {
        private int valeurDuDe;
        Random Face = new Random();

        public Depipe(int nombreDeFaces, string type) : base(nombreDeFaces, type)
        {
           this.Type = "dée pipé";
        }

        public int ValeurDuDe { get => valeurDuDe; set => valeurDuDe = value; }

        public override int Brasser()
        {
            
            valeurDuDe = Face.Next(1,(NombreDeFaces+1)+3);// si valeurDuDe=4 ou 7 de = 4. si de = 5 valeurDuDe=5 ou 8 .si de = 6 valeurDuDe=6 ou 9
            if (valeurDuDe > NombreDeFaces)
            {
                valeurDuDe = valeurDuDe - 3;
            }
            return valeurDuDe;
        }
        public override int PointDuDe()
        {
            
            Point = valeurDuDe;
            return valeurDuDe;
        }
    }
}
