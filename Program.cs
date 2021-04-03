using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // type safety
            // DO NOR REPEAT YOURSELF!!!
            // AlİAS -- DEGER TUTUCU

            string kategoriEtiketi = "Kategori";
            int ogrencisayısı = 5000;
            bool sistemegirişvarmı = true;

            double dolardün = 7.45;
            double dolarbugün = 7.45;
            if (dolardün>dolarbugün)
            {
                Console.WriteLine("Azaldı");
            }
            else if (dolardün<dolarbugün)
            {
                Console.WriteLine("artış");
            }
            else
            {
                Console.WriteLine("sabitledi.");
            }

            if (sistemegirişvarmı==true)
            {
                Console.WriteLine("kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("giriş yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);
        }
    }
}
