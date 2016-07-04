using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaca_i_Zoka
{
    public class Osoba
    {
        protected string ime; //“Ime Prezime (skracenica zemlje)”
        protected DateTime datumRodjenja; 

        //konstruktor
        public Osoba(string ime, DateTime datumRodjenja)
        {
            this.ime = ime;
            this.datumRodjenja = datumRodjenja;
        }

        public string Ime
        {
            get
            {
                return ime;
            }

            set
            {
                ime = value;
            }
        }

        public DateTime DatumRodjenja
        {
            get
            {
                return datumRodjenja;
            }

            set
            {
                datumRodjenja = value;
            }
        }
    }
}
