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

        public double cetvrtaMetodaTeniser(Turnir.VrstaTurnira vrst)
        {
            double prosek = 0;
            double zbir = 0;
            int count = 0;

            
            foreach (RezultatnaTurniru r in RezultatiNaTurnirima)
            {
                if (r.Turnir.Vrsta.Equals(vrst))
                {
                    zbir += r.BrojOsvojenihBodova;
                    count++;
                }

            }
           return prosek = zbir / count;
        }

        public double petaMetodaTeniser()
        {
            int countAll = 0;
            int znacajni = 0;

            foreach (RezultatnaTurniru r in RezultatiNaTurnirima)
            {
                countAll++;
                if (r.Turnir.MaxBrojPoena == r.BrojOsvojenihBodova)
                {
                    znacajni++;
                }

            }
            return znacajni / countAll * 100;
        }

        public int sestaMetodaTeniser()
        {
            int zbir = 0;
            foreach (RezultatnaTurniru r in RezultatiNaTurnirima)
            {

                zbir += r.Turnir.MaxBrojPoena;
            }
            return zbir;

        }

        public string sedmaMetodaTeniser()
        {
            List<string> lista = new List<string>();
            string izlaz = "";

            foreach (RezultatnaTurniru r in RezultatiNaTurnirima)
            {
                if (lista.Contains(r.Turnir.Naziv))
                {
                    lista.Add(r.Turnir.Naziv);
                }
            }

            foreach (string s in lista)
            {
                izlaz += s + " ";
            }
            return izlaz;
        }

        public string osmaMetodateniser()
        {
            int brojZnacajnih = 0;

            foreach (RezultatnaTurniru r in RezultatiNaTurnirima)
            {
                if (r.BrojOsvojenihBodova.Equals(r.Turnir.MaxBrojPoena))
                {
                    brojZnacajnih++;

                }
            }

            if (brojZnacajnih >=2)
            {
                return "jeste";
            }
            else
            {
                return "nije";
            }
        }

        public 
    }

    
}
