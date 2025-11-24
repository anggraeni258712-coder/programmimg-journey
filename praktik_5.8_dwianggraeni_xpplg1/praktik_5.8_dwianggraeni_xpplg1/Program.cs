using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktik_5._8_dwianggraeni_xpplg1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ulangiPilihan;

            do
            {
                // Blok Proses yang Akan Diulang:
                Console.WriteLine("================================");
                Console.Write("Masukkan nama Anda: ");
                string nama = Console.ReadLine();
                Console.WriteLine($"Halo, {nama}! Proses telah selesai.");

                // Pertanyaan untuk mengulang
                Console.Write("Apakah Anda Ingin mengulang lagi? (ya/tidak): ");
                // Mengambil input dan mengubah ke huruf kecil
                ulangiPilihan = Console.ReadLine().ToLower();

                Console.WriteLine(); // Baris kosong untuk kerapatan

                // Kondisi diperiksa di akhir. Ulangi selama pengguna mengetik "ya"
            } while (ulangiPilihan == "ya");

            Console.WriteLine("Terima kasih. Program selesai.");
            
        }
    }
}
