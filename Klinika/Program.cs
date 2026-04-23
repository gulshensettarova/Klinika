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
            //Property usulu 
            Xeste x1 = new Xeste(1, "Anar", "Quliyev", 35);
            x1.Boy = 178;
            x1.Ceki = 82;
            x1.QanGrupu = "A+";
            x1.Sigortali = true;

            x1.MelumatGoster();

            // Encapsulation işdə:
            // x1._yas = -5;     ← XƏTA! private-dir
            // x1.Yas  = -5;     ← Exception: "Yaş 0-150 arasında olmalıdır!"
            // x1.QanGrupu = "X+"; ← Exception: "Yanlış qan qrupu!"

            //Kohne usul (get/set metodlari ile)
            Xeste_ x = new Xeste_(1, "Anar", 35);

            // Oxumaq üçün → Get metodunu çağırırıq
            Console.WriteLine(x.GetAd());    // Anar
            Console.WriteLine(x.GetYas());   // 35

            // Yazmaq üçün → Set metodunu çağırırıq
            x.SetAd("Nicat");
            x.SetYas(28);
            x.SetQanGrupu("A+");
            x.SetQanGrupu("X+");   // Xəta: Yanlış qan qrupu!
            x.SetYas(999);         // Xəta: Yaş 0-150 arasında olmalıdır!

            x.MelumatGoster();

        }
    }
}
