using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaca_i_Zoka
{
    public class RezultatnaTurniru
    {
        Turnir turnir;
        int brojOsvojenihBodova;

        //konstruktor
        public RezultatnaTurniru(Turnir turnir,int brojOsvojenihBodova)
        {
            this.turnir = turnir;
            this.brojOsvojenihBodova = brojOsvojenihBodova;
        }

        public Turnir Turnir
        {
            get
            {
                return turnir;
            }

            set
            {
                turnir = value;
            }
        }

        public int BrojOsvojenihBodova
        {
            get
            {
                return brojOsvojenihBodova;
            }

            set
            {
                brojOsvojenihBodova = value;
            }
        }
    }
}
