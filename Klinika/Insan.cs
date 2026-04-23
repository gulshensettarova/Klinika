using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klinika
{
    public class Insan
    {
        private int _id;
        private string _ad;
        private string _soyad;
        private int _yas;

        public Insan(int id, string ad, string soyad, int yas)
        {
            _id = id;
            Ad = ad;      // property üzərindən
            Soyad = soyad;
            Yas = yas;
        }
        public int Id => _id;

        public string Ad
        {
            get => _ad;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Ad boş ola bilməz!");
                _ad = value.Trim();
            }
        }

        public string Soyad
        {
            get => _soyad;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Soyad boş ola bilməz!");
                _soyad = value.Trim();
            }
        }

        public int Yas
        {
            get => _yas;
            set
            {
                if (value < 0 || value > 150)
                    throw new Exception("Yaş 0-150 arasında olmalıdır!");
                _yas = value;
            }
        }
        public string TamAd => $"{_ad} {_soyad}";

        public virtual void MelumatGoster()
        {
            Console.WriteLine($"  ID   : {_id}");
            Console.WriteLine($"  Ad   : {TamAd}");
            Console.WriteLine($"  Yaş  : {_yas}");
        }
    }
}
