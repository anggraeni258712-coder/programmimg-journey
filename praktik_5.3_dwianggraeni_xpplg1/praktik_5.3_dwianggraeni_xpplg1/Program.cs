using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktik_5._3_dwianggraeni_xpplg1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Inisiallisasi variabel untuk menyimpan input
            String inputUser = "";

            Console.WriteLine("Program akan terus berjalan hinga anda mengetik 'keluar' .");

            // Perulangan selama isi variabel inputUser TIDAK SAMA DENGAN "keluar"
            while (inputUser.ToLower() != "keluar")
            {
                Console.Write("\nketik sesuatu (atau 'keluar' untuk berhenti): ");
                inputUser = Console.ReadLine(); // Baca input dari user

                Console.WriteLine("Anda mengetik: " + inputUser);
            }

            Console.WriteLine("/nProgram selesai. Terima Kasih!");
        } 
        }
}
