using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktik_5._1_dwianggraeni_xpplg1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("perulangan untuk menampilkan angka 1 sampai 10:");

            // Perulangan for di mulai di sini
            for (int i = 1; i <= 10; i++)
            {
                // Blok kode yang akan diulang
                Console.WriteLine("angka ke-" + i);
            }

            Console.WriteLine("\nPerulangan selesai.");
        }
    }
}
