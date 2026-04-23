using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klinika
{
    public class Xeste_
    {
        // private dəyişənlər — xaricdən görünmür
        private int _id;
        private string _ad;
        private int _yas;
        private string _qanGrupu;

        // ── Konstruktor ──────────────────────────────────────
        public Xeste_(int id, string ad, int yas)
        {
            _id = id;
            SetAd(ad);    // set metodu üzərindən — yoxlama işləsin
            SetYas(yas);
        }

    
        //  ID  —  yalnız oxunan (setter yoxdur)
        public int GetId()
        {
            return _id;
        }
        // SetId() yoxdur — ID heç vaxt dəyişməməlidir

        public string GetAd()
        {
            return _ad;
        }

        public void SetAd(string yeniAd)
        {
            if (string.IsNullOrWhiteSpace(yeniAd))
            {
                Console.WriteLine("Xəta: Ad boş ola bilməz!");
                return;
            }
            _ad = yeniAd.Trim();
        }


        public int GetYas()
        {
            return _yas;
        }

        public void SetYas(int yeniYas)
        {
            if (yeniYas < 0 || yeniYas > 150)
            {
                Console.WriteLine("Xəta: Yaş 0-150 arasında olmalıdır!");
                return;
            }
            _yas = yeniYas;
        }


        public string GetQanGrupu()
        {
            return _qanGrupu ?? "Məlum deyil";
        }

        public void SetQanGrupu(string qanGrupu)
        {
            string[] duzgunler = { "A+", "A-", "B+", "B-", "AB+", "AB-", "0+", "0-" };

            bool tapildi = false;
            foreach (string q in duzgunler)
            {
                if (q == qanGrupu)
                {
                    tapildi = true;
                    break;
                }
            }

            if (!tapildi)
            {
                Console.WriteLine("Xəta: Yanlış qan qrupu!");
                return;
            }
            _qanGrupu = qanGrupu;
        }


        public void MelumatGoster()
        {
            Console.WriteLine("=== XƏSTƏ KARTI ===");
            Console.WriteLine("ID      : " + GetId());
            Console.WriteLine("Ad      : " + GetAd());
            Console.WriteLine("Yaş     : " + GetYas());
            Console.WriteLine("Qan qr. : " + GetQanGrupu());
        }
}

}
