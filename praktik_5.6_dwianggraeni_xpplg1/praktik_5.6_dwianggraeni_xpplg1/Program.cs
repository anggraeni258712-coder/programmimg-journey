using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktik_5._6_dwianggraeni_xpplg1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int angka;

            // Blok 'do' akan dieksekusi minimal satu kali
            do
            {
                Console.Write("Masukkan angka genap: ");

                // Mencoba membaca input dari pengguna
                if (!int.TryParse(Console.ReadLine(), out angka))
                {
                    Console.WriteLine("Input tidak valid. Silakan masukkan angka.");
                    // Jika input tidak valid, set angka = 1 (ganjil) agar loop berlanjut
                    angka = 1;
                    continue; // Lanjutkan ke iterasi berikutnya
                }

                // Memeriksa apakah angka tersebut ganjil (sisa bagi % 2 adalah 1)
                if (angka % 2 != 0)
                {
                    Console.WriteLine($"Angka {angka} adalah ganjil. Coba lagi!");
                }

                // Kondisi diperiksa di akhir. Loop berlanjut selama angka Ganjil
            } while (angka % 2 != 0);

            Console.WriteLine($"\nSelamat! Anda memasukkan angka genap: {angka}");
            
        }
    }
}
