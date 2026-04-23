using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klinika
{
    public class TibbBacisi : Insan
    {
        private string _bolme;
        private string _növbet;

        public TibbBacisi(int id, string ad, string soyad, int yas, string bolme)
            : base(id, ad, soyad, yas)
        {
            Bolme = bolme;
        }

        public string Bolme
        {
            get => _bolme;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Xəta: Bölmə boş ola bilməz!");
                    return;
                }
                _bolme = value.Trim();
            }
        }

        public string Novbet
        {
            get => _növbet;
            set
            {
                if (value != "Gündüz" && value != "Gecə")
                {
                    Console.WriteLine("Xəta: Növbə yalnız 'Gündüz' və ya 'Gecə' ola bilər!");
                    return;
                }
                _növbet = value;
            }
        }

        public override void MelumatGoster()
        {
            Console.WriteLine("╔══ TİBB BACISI KARTI ════════════════╗");
            base.MelumatGoster();
            Console.WriteLine($"  Bölmə : {_bolme}");
            Console.WriteLine($"  Növbə : {_növbet ?? "Təyin edilməyib"}");
            Console.WriteLine("╚═════════════════════════════════════╝");
        }
    }
}