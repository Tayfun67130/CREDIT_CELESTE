using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ClscCalcul
{
    public class Calcul
    {
        private double taux;
        private double montant;
        private double duree;
        private double mensualite;

        public Calcul()
        { 

        }

        public Calcul(double tx, double mt, double dur)
        {
            taux = tx;
            montant = mt;
            duree = dur;
            
        }

        public double calcmensualite()
        {
       
            double mensualite = 0;
            taux = taux / 100;
            double fraction = taux / (1 - (Math.Pow(1 + taux, -duree)));

            mensualite = montant * fraction;

            return mensualite;
        }


        public double calcmensualiteSelonTaux()
        {

            double taux = 0;

            
            
            double mensualite = 0;
            taux = taux / 100;
            double fraction = taux / (1 - (Math.Pow(1 + taux, -duree)));

            mensualite = montant * fraction;

            if (e.KeyCode == Keys.F10)
            {
                Form2 f2 = new Form2();
                f2.Show();

            }


            return mensualite;


        }


        public double getmensualite()
        {
            return (mensualite);
        }
 
    }
}
