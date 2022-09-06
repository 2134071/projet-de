using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_de_de
{
    abstract class Controler
    {
        
        public abstract int Brasser();
        public abstract int PointDuDe();

        private int nombreDeFaces;
        private int point;
        private string type;

        protected int NombreDeFaces { get => nombreDeFaces; set => nombreDeFaces = value; }
        public int Point { get => point; set => point = value; }
        public string Type { get => type; set => type = value; }

        protected Controler(int nombreDeFaces, string type)
        {
            NombreDeFaces = nombreDeFaces;
            this.Type = type;
        }
    }
}
