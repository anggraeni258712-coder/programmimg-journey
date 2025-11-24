using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas6_dwianggraeni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            { //Membuat array untuk menyimpan nama, nilai, dan jenis kelamin 3 siswa
                string[] nama = new string[3];
                char[] jk = new char[3];
                string[] kelas = new string[3];

                //Input nama dan nilai siswa dari keyboard
                Console.Write("Masukkan nama siswa ke-1: ");
                nama[0] = Console.ReadLine();
                Console.Write("Masukkan jenis kelamin siswa ke-1 (L/P): ");
                jk[0] = Convert.ToChar(Console.ReadLine());
                Console.Write("Masukkan kelas siswa ke-1: ");
                kelas[0] = Console.ReadLine();

                Console.Write("Masukkan nama siswa ke-2: ");
                nama[1] = Console.ReadLine();
                Console.Write("Masukkan jenis kelamin siswa ke-2 (L/P): ");
                jk[1] = Convert.ToChar(Console.ReadLine());
                Console.Write("Masukkan kelas siswa ke-2: ");
                kelas[1] = Console.ReadLine();

                Console.Write("Masukkan nama siswa ke-3: ");
                nama[2] = Console.ReadLine();
                Console.Write("Masukkan jenis kelamin siswa ke-3 (L/P): ");
                jk[2] = Convert.ToChar(Console.ReadLine());
                Console.Write("Masukkan kelas siswa ke-3: ");
                kelas[2] = Console.ReadLine();



                //Menampilkan hasil input tanpa perulangan 
                Console.WriteLine("\n=== Data Siswa ===");
                Console.WriteLine("Nama: " + nama[0] + " | Jenis Kelamin: " + jk[0] + " | Kelas: " + kelas[0]);
                Console.WriteLine("Nama: " + nama[1] + " | Jenis Kelamin: " + jk[1] + " | Kelas: " + kelas[1]);
                Console.WriteLine("Nama: " + nama[2] + " | Jenis Kelamin: " + jk[2] + " | Kelas: " + kelas[2]);
            }
        }
    }
}
