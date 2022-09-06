namespace projet_de_de
{
    public partial class Form1 : Form
    {   private int PointTotal = 0;
        DeOrdinaire deOrdinaire = new(6, "Ordinaire");
        Depipe depipe = new(6, "Pipe");
        //Depipe depipe = new(6, "Pipe");
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_brasser_Click(object sender, EventArgs e)
        {   
            int choixDuDe;
            Random ChoixDe = new Random();
            choixDuDe = ChoixDe.Next(1, 3);
            if (choixDuDe == 1)
            {
                deOrdinaire.Brasser();
                PointTotal += deOrdinaire.ValeurDuDe; 
                MessageBox.Show("Type de Dé : "+deOrdinaire.Type + "\n" + "nombre obtenu : "+ deOrdinaire.ValeurDuDe +"\n" + "point total : " + PointTotal);
            }
            else
            {
               depipe.Brasser();
                PointTotal += depipe.ValeurDuDe;
                MessageBox.Show("Type de Dé : " + depipe.Type + "\n" + "nombre obtenu : " + depipe.ValeurDuDe + "\n" + "point total : " + PointTotal);
            }
            
            
        }
    }
}