using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klinika
{
    public class Hekim : Insan
    {
        private string _ixtisas;
        private decimal _maas;
        private int _stajIl;

        public Hekim(int id, string ad, string soyad, int yas, string ixtisas)
            : base(id, ad, soyad, yas)
        {
            Ixtisas = ixtisas;
        }

        public string Ixtisas
        {
            get => _ixtisas;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Xəta: İxtisas boş ola bilməz!");
                    return;
                }
                _ixtisas = value.Trim();
            }
        }

        public decimal Maas
        {
            get => _maas;
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Xəta: Maaş mənfi ola bilməz!");
                    return;
                }
                _maas = value;
            }
        }

        public int StajIl
        {
            get => _stajIl;
            set
            {
                if (value < 0 || value > 60)
                {
                    Console.WriteLine("Xəta: Staj 0-60 arasında olmalıdır!");
                    return;
                }
                _stajIl = value;
            }
        }

        public string Unvan => _stajIl >= 15 ? "Professor" :
                               _stajIl >= 8 ? "Dosent" : "Dr.";

        public override void MelumatGoster()
        {
            Console.WriteLine("╔══ HƏKİM KARTI ══════════════════════╗");
            base.MelumatGoster();
            Console.WriteLine($"  İxtis: {_ixtisas}");
            Console.WriteLine($"  Ünvan: {Unvan}");
            Console.WriteLine($"  Staj : {_stajIl} il");
            Console.WriteLine($"  Maaş : {_maas} AZN");
            Console.WriteLine("╚═════════════════════════════════════╝");
        }
    }
}