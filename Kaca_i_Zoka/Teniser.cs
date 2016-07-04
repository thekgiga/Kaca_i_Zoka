using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaca_i_Zoka
{
     public class Teniser:Osoba
    {
        int rang;
        List<RezultatnaTurniru> rezultatiNaTurnirima = new List<RezultatnaTurniru>();

        //konstruktor
        public Teniser(string ime, DateTime datumrodj, int rang, List<RezultatnaTurniru> rezultatiNaTurnirima) :base(ime,datumrodj)
        {
            this.rang = rang;
            this.rezultatiNaTurnirima = rezultatiNaTurnirima;

        }

        public int Rang
        {
            get
            {
                return rang;
            }

            set
            {
                rang = value;
            }
        }

        internal List<RezultatnaTurniru> RezultatiNaTurnirima
        {
            get
            {
                return rezultatiNaTurnirima;
            }

            set
            {
                rezultatiNaTurnirima = value;
            }
        }

        public string prvaMetodaTeniser( Turnir turn)
        {
            string povratnaVrednost = "";

            foreach (RezultatnaTurniru ReznaTur in RezultatiNaTurnirima)
            {
                if (ReznaTur.BrojOsvojenihBodova == turn.MaxBrojPoena)
                {
                    povratnaVrednost += "pobedio je, ";
                }
                else
                {
                    povratnaVrednost += "nije pobedio, ";
                }

            }
            string vrstaturnira = turn.Vrsta.ToString();
            povratnaVrednost += "vrsta turnira je " + vrstaturnira;

            return povratnaVrednost;

        }

        public int drugaMetodaTeniser()
        {
            int broj = 0;
            foreach (RezultatnaTurniru RezNaTurn in RezultatiNaTurnirima)
            {
                if(RezNaTurn.BrojOsvojenihBodova > RezNaTurn.Turnir.MaxBrojPoena / 2)
                {
                    broj += 1;
                }

            }
            return  broj;
        }

        public string trecaMetodaTeniser()
        {
            string pov = "";
            foreach (RezultatnaTurniru r in RezultatiNaTurnirima)
            {
                if (r.Turnir.Godina == 2016)
                {
                    pov += r.Turnir.Naziv+", ";

                }

            }

            return pov;

        }


    }

    
}
