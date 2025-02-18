using System.IO.Pipes;

namespace   ConsoleApp1
{
    class Program   // Class
    {
        static void Main(string[] args)  // Method
        {
            Console.WriteLine("------- Sayı Belirlemek -------");

            int a = 5 ;

            if (a > 0)
            {
                Console.WriteLine("Sayı Pozitif");
            }
            else if (a < 0)
            {
                Console.WriteLine("Sayı Negatif");
            }
            else
            {
                Console.WriteLine("Sayı Sıfır");
            }

            Console.WriteLine("-------Gün İsmi Belirleme--------");

            int gun = 3;

            if (gun == 1)
            {
                Console.WriteLine("Pazartesi");
            }
            else if (gun == 2)
            {
                Console.WriteLine("Salı");
            }
            else if (gun == 3)
            {
                Console.WriteLine("Çarşamba");
            }
            else if (gun == 4)
            {
                Console.WriteLine("Perşembe");
            }
            else if (gun == 5)
            {
                Console.WriteLine("Cuma");
            }
            else if (gun == 6)
            {
                Console.WriteLine("Cumartesi");
            }
            else if (gun == 7)
            {
                Console.WriteLine("Pazar");
            }
            else
            {
                Console.WriteLine("Geçersiz Gün");
            }


            Console.WriteLine("-------Basit Hesap Makinesi--------");

            Console.WriteLine("1. Sayıyı Giriniz: ");
            int sayi1 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("2. Sayıyı Giriniz: ");
            int sayi2 = int.Parse(Console.ReadLine());

            Console.WriteLine("İşlemi Seçiniz: ");
            Console.WriteLine("1-Toplama");
            Console.WriteLine("2-Çıkarma");
            Console.WriteLine("3-Çarpma");
            Console.WriteLine("4-Bölme");

            int secim = int.Parse(Console.ReadLine());

            if (secim == 1)
            {
                Console.WriteLine("Sonuç: " + (sayi1 + sayi2));
            }
            else if (secim == 2)
            {
                Console.WriteLine("Sonuç: " + (sayi1 - sayi2));
            }
            else if (secim == 3)
            {
                Console.WriteLine("Sonuç: " + (sayi1 * sayi2));
            }
            else if (secim == 4)
            {
                if (sayi2 != 0)
                {
                    Console.WriteLine("Sonuç: " + (sayi1 / sayi2));
                }
                else
                {
                    Console.WriteLine("Bir sayı sıfıra bölünemez.");
                }
            }
            else
            {
                Console.WriteLine("Geçersiz İşlem");
            }

            Console.WriteLine("-------Üç Sayının En büyüğünü Bulma--------");

            int ebsayi1 = 5;
            int ebsayi2 = 7;
            int ebsayi3 = 3;

            if (ebsayi1 > ebsayi2 && ebsayi1 > ebsayi3)
            {
                Console.WriteLine("En Büyük Sayı: " + ebsayi1);
            }
            else if (ebsayi2 > ebsayi1 && ebsayi2 > ebsayi3)
            {
                Console.WriteLine("En Büyük Sayı: " + ebsayi2);
            }
            else if (ebsayi3 > ebsayi1 && ebsayi3 > ebsayi2)
            {
                Console.WriteLine("En Büyük Sayı: " + ebsayi3);
            }
            else
            {
                Console.WriteLine("Sayılar Eşit");
            }

            Console.WriteLine("-------Şifre güçlülüğünü Kontrol Etme--------");

            Console.WriteLine("Şifreyi Giriniz: ");
            string sifre = Console.ReadLine();

            bool sifreIsStrong ;
            char[] ozelKarakterler = { '@', '#', '$', '%', };

            if (sifre.Length >= 8)
            {
                if (sifre.Any(ozelKarakterler.Contains))
                {
                    if (sifre.Any(char.IsUpper))
                    {
                        sifreIsStrong = true;
                    }
                    else
                    {
                        sifreIsStrong = false;
                    }
                }
                else
                {
                    sifreIsStrong = false;
                }
                
            }
            else
            {
                sifreIsStrong = false;
            }

            Console.WriteLine("Şifre Güçlü Mü: " + sifreIsStrong);
        }

    }
}