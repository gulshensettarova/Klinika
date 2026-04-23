using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klinika
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Xeste x1 = new Xeste(1, "Anar", "Quliyev", 35);
            x1.Boy = 178; x1.Ceki = 82; x1.QanGrupu = "A+"; x1.Sigortali = true;

            Hekim h1 = new Hekim(101, "Nicat", "Həsənov", 45, "Kardioloq");
            h1.StajIl = 18; h1.Maas = 3500;

            TibbBacisi t1 = new TibbBacisi(201, "Leyla", "Əliyeva", 28, "Cərrahiyyə");
            t1.Novbet = "Gecə";

            x1.MelumatGoster();
            h1.MelumatGoster();
            t1.MelumatGoster();

        }
    }
}
