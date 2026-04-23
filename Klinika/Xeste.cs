using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klinika
{
    public class Xeste : Insan
    {
        private double _boy;
        private double _ceki;
        private string _qangrupu;
        private bool _sigortali;

        public Xeste(int id, string ad, string soyad, int yas)
            : base(id, ad, soyad, yas)
        { }

        public double Boy
        {
            get => _boy;
            set
            {
                if (value < 30 || value > 250)
                {
                    Console.WriteLine("Xəta: Boy 30-250 sm arasında olmalıdır!");
                    return;
                }
                _boy = value;
            }
        }

        public double Ceki
        {
            get => _ceki;
            set
            {
                if (value < 1 || value > 300)
                {
                    Console.WriteLine("Xəta: Çəki düzgün deyil!");
                    return;
                }
                _ceki = value;
            }
        }

        public string QanGrupu
        {
            get => _qangrupu;
            set
            {
                var duzgunler = new[] { "A+", "A-", "B+", "B-", "AB+", "AB-", "0+", "0-" };
                if (!duzgunler.Contains(value))
                {
                    Console.WriteLine("Xəta: Yanlış qan qrupu!");
                    return;
                }
                _qangrupu = value;
            }
        }

        public bool Sigortali
        {
            get => _sigortali;
            set => _sigortali = value;
        }

        public double BKI => (_boy > 0 && _ceki > 0)
            ? Math.Round(_ceki / Math.Pow(_boy / 100.0, 2), 1) : 0;

        public string BKISeviyyesi
        {
            get
            {
                if (BKI == 0) return "Məlumat yoxdur";
                if (BKI < 18.5) return "Az çəkili";
                if (BKI < 25.0) return "Normal";
                if (BKI < 30.0) return "Artıq çəkili";
                return "Obez";
            }
        }

        public override void MelumatGoster()
        {
            Console.WriteLine("╔══ XƏSTƏ KARTI ══════════════════════╗");
            base.MelumatGoster();
            Console.WriteLine($"  Qan  : {_qangrupu ?? "Məlum deyil"}");
            Console.WriteLine($"  BKİ  : {BKI} ({BKISeviyyesi})");
            Console.WriteLine($"  Sığ  : {(_sigortali ? "Var ✔" : "Yox ✗")}");
            Console.WriteLine("╚═════════════════════════════════════╝");
        }
    }
}