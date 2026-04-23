using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klinika
{
    public class Xeste
    {
        private int _id;
        private string _ad;
        private string _soyad;
        private int _yas;
        private double _boy;
        private double _ceki;
        private string _qangrupu;
        private bool _sigortali;

        public Xeste(int id, string ad, string soyad, int yas)
        {
            _id = id;
            _ad = ad;
            _soyad = soyad;
            Yas = yas;
        }

        public int Id => _id;

        public string Ad
        {
            get => _ad;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Xəta: Ad boş ola bilməz!");
                    return;
                }
                _ad = value.Trim();
            }
        }

        public string Soyad
        {
            get => _soyad;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Xəta: Soyad boş ola bilməz!");
                    return;
                }
                _soyad = value.Trim();
            }
        }

        public int Yas
        {
            get => _yas;
            set
            {
                if (value < 0 || value > 150)
                {
                    Console.WriteLine("Xəta: Yaş 0-150 arasında olmalıdır!");
                    return;
                }
                _yas = value;
            }
        }

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

        public string TamAd => $"{_ad} {_soyad}";

        public double BKI => (_boy > 0 && _ceki > 0)
            ? Math.Round(_ceki / Math.Pow(_boy / 100.0, 2), 1)
            : 0;

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

        public void MelumatGoster()
        {
            Console.WriteLine($"╔══ XƏSTƏ KARTI ══════════════════════╗");
            Console.WriteLine($"  ID     : {_id}");
            Console.WriteLine($"  Ad     : {TamAd}");
            Console.WriteLine($"  Yaş    : {_yas}");
            Console.WriteLine($"  Qan    : {_qangrupu ?? "Məlum deyil"}");
            Console.WriteLine($"  BKİ    : {BKI} ({BKISeviyyesi})");
            Console.WriteLine($"  Sığorta: {(_sigortali ? "Var " : "Yox ")}");
            Console.WriteLine($"╚═════════════════════════════════════╝");
        }
    }
}