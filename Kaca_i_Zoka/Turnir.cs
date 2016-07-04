using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaca_i_Zoka
    
{
  

    public class Turnir 
    {
        public enum VrstaTurnira { Grandslam, Masters, Drugi }
        int godina;
        String naziv;
        int maxBrojPoena;
        VrstaTurnira vrsta;

        //konstruktor
        public Turnir(int godina, string naziv, int maxBrojPoena, VrstaTurnira vrsta)
        {
            this.godina = godina;
            this.naziv = naziv;
            this.maxBrojPoena = maxBrojPoena;
            this.vrsta = vrsta;
        }

        public int Godina
        {
            get
            {
                return godina;
            }

            set
            {
                godina = value;
            }
        }

        public string Naziv
        {
            get
            {
                return naziv;
            }

            set
            {
                naziv = value;
            }
        }

        public int MaxBrojPoena
        {
            get
            {
                return maxBrojPoena;
            }

            set
            {
                maxBrojPoena = value;
            }
        }

        public VrstaTurnira Vrsta
        {
            get
            {
                return vrsta;
            }

            set
            {
                vrsta = value;
            }
        }
       
    }
}
