using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kaca_i_Zoka;

namespace ATP_lista
{
    class ATP_lista
    {
        int godina;
        List<Teniser> spisaktenisera = new List<Teniser>();

        public ATP_lista()
        {

        }
        static void Main(string[] args)
        {
            Turnir t = new Turnir(2016, "MojTurnir", 1000, Turnir.VrstaTurnira.Grandslam);
            List<RezultatnaTurniru> rt = new List<RezultatnaTurniru>();
            RezultatnaTurniru tt = new RezultatnaTurniru(t,1000);
            rt.Add(tt);
            Teniser teniser = new Teniser("Novak Djokovic (SRB)",DateTime.Parse("14.09..1994"),1,rt);

            String izlaz = teniser.prvaMetodaTeniser(t);
            Console.WriteLine(izlaz);
            Console.Read();
        }
    }
}
