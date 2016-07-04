using System;
using System.Collections.Generic;
using System.Linq;
using Kaca_i_Zoka;

namespace ATP_lista
{
    class ATP_lista
    {
        int godina;
        List<Teniser> spisaktenisera = new List<Teniser>();

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

        public List<Teniser> Spisaktenisera
        {
            get
            {
                return spisaktenisera;
            }

            set
            {
                spisaktenisera = value;
            }
        }

        //konstruktor
        public ATP_lista(int godina, List<Teniser> spisaktenisera)
        {
            this.Godina = godina;
            this.Spisaktenisera = spisaktenisera;


        }


        public string prvaMetoda()
        {
            List<Teniser> sortirano = spisaktenisera.OrderBy(o => o.Rang).ToList();//nasao sam na netu da se ovako sortira lista..
            string pom = "";
            int brojac= 0;
            foreach (Teniser t in sortirano)
            {
                pom += t.Ime + " " + t.RezultatiNaTurnirima.Count() + Environment.NewLine;
                brojac++;
                if (brojac==5)
                {
                    return pom;
                }
            }
            return pom;
        }

        public int drugaMetoda(string zemlja)
        {
            int pom = 0;
            string zem = string.Format("(0)", zemlja);
            foreach (Teniser t in spisaktenisera)
            {
                if (t.Ime.EndsWith(zem))
                {
                    pom++;
                }
            }
            return pom;
        }

        public string trecaMetoda()
        {
            List<Teniser> sortirana = spisaktenisera.OrderByDescending(o => o.Rang).ToList();

            return sortirana[0].Ime;
        }

        public string cetvrtaMetoda()
        {
            string pom = "";
            List<Teniser> lista =new List<Teniser>();

            foreach (Teniser t in spisaktenisera)
            {
                if (t.Ime.EndsWith("(SRB)"))
                {
                    foreach (RezultatnaTurniru rNat in t.RezultatiNaTurnirima)
                    {
                        if (rNat.Turnir.Vrsta.ToString().Equals("Grandslam"))
                        {
                            if (!lista.Contains(t))
                            {
                                lista.Add(t);
                            }

                        }

                    }

                }
                
            }

            foreach (Teniser t in lista)
            {
                pom += t.Ime + Environment.NewLine;
            }     
            
            return pom;

        }

        public string petaMetoda(Teniser t1, Teniser t2)
        {
            string pom = "";
            List<string> lista1 = new List<string>();
            List<string> lista2 = new List<string>();
       

            foreach (RezultatnaTurniru rNAt in t1.RezultatiNaTurnirima)
            {
                if (!lista1.Contains(rNAt.Turnir.Naziv))
                {
                    lista1.Add(rNAt.Turnir.Naziv);
                }
            }

            foreach (RezultatnaTurniru rNAt in t2.RezultatiNaTurnirima)
            {
                if (!lista2.Contains(rNAt.Turnir.Naziv))
                {
                    lista2.Add(rNAt.Turnir.Naziv);
                }
            }

            foreach (string  s in lista1)
            {
                if (!lista2.Contains(s))
                {
                    pom += s+" ";
                }
            }
            return pom;
        }

        public string sestaMetoda(Turnir.VrstaTurnira vrsta)
        {
            string pom = "";

            foreach (Teniser t in spisaktenisera)
            {
                foreach (RezultatnaTurniru r in t.RezultatiNaTurnirima)
                {
                    if (r.BrojOsvojenihBodova.Equals(r.Turnir.MaxBrojPoena))
                    {
                        pom += t.Ime+ Environment.NewLine;
                    }

                }

            }

            return pom;


        }

        public string sedmaMetoda(int god)
        {
            string pom = "";
            foreach (Teniser t in spisaktenisera)
            {
                if((DateTime.Now.Year - t.DatumRodjenja.Year) < god && t.RezultatiNaTurnirima.Count()>=10)
                {
                    pom += t.Ime;

                }
            }
            return pom;
        }

        //za osmu nemam tekst
        
        public string devetaMetoda()
        {
            string pom = "";

            foreach (Teniser t in spisaktenisera)
            {
                List<string> lista = new List<string>();

                foreach (RezultatnaTurniru r in t.RezultatiNaTurnirima)
                {
                    lista.Add(r.Turnir.Vrsta.ToString());

                }
                if (lista.Count() == 1)
                {
                    pom += t.Ime + Environment.NewLine; 
                }
            }

            return pom;

        } 

        public string desetaMetoda()
        {
            string teniser = "";

            int razlika = 0;
            
            foreach (Teniser t in spisaktenisera)
            {
                foreach (RezultatnaTurniru r in t.RezultatiNaTurnirima)
                {
                    if((DateTime.Now.Year - r.Turnir.Godina)> razlika && r.Turnir.Vrsta.ToString().Equals("Grandslam"))
                    {
                        razlika = DateTime.Now.Year - r.Turnir.Godina;
                        teniser = t.Ime;
                    }
                }
            }

            return teniser; 
        }




        static void Main(string[] args)
        {
          
            Turnir t = new Turnir(2016, "MojTurnir", 1000, Turnir.VrstaTurnira.Grandslam);
            Turnir t1 = new Turnir(2015, "TvojTurnir", 1000, Turnir.VrstaTurnira.Masters);
            Turnir t2 = new Turnir(2016, "NjenTurnir", 1000, Turnir.VrstaTurnira.Drugi);
            Turnir t3 = new Turnir(2016, "MojTurnir", 1000, Turnir.VrstaTurnira.Grandslam);
            List<RezultatnaTurniru> rt = new List<RezultatnaTurniru>();
            RezultatnaTurniru tt = new RezultatnaTurniru(t, 1000);
            RezultatnaTurniru t11 = new RezultatnaTurniru(t2, 750);
            RezultatnaTurniru t231= new RezultatnaTurniru(t3, 800);
            rt.Add(tt);
            rt.Add(t11);
            List<RezultatnaTurniru> rt2 = new List<RezultatnaTurniru>();
            rt2.Add(t231);
            Teniser teniser = new Teniser("Novak Djokovic (SRB)", DateTime.Parse("14.09..1994"), 1, rt);
            Teniser teniser1 = new Teniser("Janko Tipsarevic (SRB)", DateTime.Parse("14.09..1994"), 2, rt2);
            //Teniser teniser2 = new Teniser("Nenad Zimonjic (SRB)", DateTime.Parse("14.09..1994"), 3, rt);

            List<Teniser> spisak = new List<Teniser>();
            spisak.Add(teniser);
            spisak.Add(teniser1);
            //spisak.Add(teniser2);

            ATP_lista atp = new ATP_lista(2016, spisak);
            //String izlaz = teniser.prvaMetodaTeniser(t);
            //Console.WriteLine(izlaz);
            //Console.Read();
            Console.WriteLine(atp.sestaMetoda(Turnir.VrstaTurnira.Grandslam));
            Console.Read();
        }
    }
}
