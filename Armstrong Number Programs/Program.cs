using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armstrong_Sayı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Bir sayı girin (çıkmak için 'q' tuşlayın): ");
                string girdi = Console.ReadLine();

                if (girdi.ToLower() == "q")
                {
                    break;
                }

                if (int.TryParse(girdi, out int sayi))
                {
                    if (ArmstrongMi(sayi))
                    {
                        Console.WriteLine($"{sayi} bir Armstrong sayısıdır.");
                    }
                    else
                    {
                        Console.WriteLine($"{sayi} bir Armstrong sayısı değildir.");
                    }
                }
                else
                {
                    Console.WriteLine("Geçersiz bir sayı girdiniz. Lütfen bir sayı girin.");
                }
            }
        }

        static bool ArmstrongMi(int sayi)
        {
            int orijinalSayi = sayi;
            int basamakSayisi = sayi.ToString().Length;
            int toplam = 0;

            while (sayi > 0)
            {
                int basamak = sayi % 10;
                toplam += (int)Math.Pow(basamak, basamakSayisi);
                sayi /= 10;
            }

            return toplam == orijinalSayi;
        }
    }

}
