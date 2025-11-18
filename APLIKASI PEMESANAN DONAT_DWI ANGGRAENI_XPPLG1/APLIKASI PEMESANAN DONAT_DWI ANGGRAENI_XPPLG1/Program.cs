using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APLIKASI_PEMESANAN_DONAT_DWI_ANGGRAENI_XPPLG1
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.Title = "Aplikasi Toko Donat Manis Bahagia";

                // Harga tiap donat
                int hargaCoklat = 10000;
                int hargaKeju = 15000;
                int hargaTiramisu = 16000;

                // Variabel untuk menghitung total
                int totalBayar = 0;
                int jumlahCoklat = 0;
                int jumlahKeju = 0;
                int jumlahTiramisu = 0;

                bool lanjutBelanja = true;

                // Tampilan awal
                Console.WriteLine("==========================================");
                Console.WriteLine("   SELAMAT DATANG DI TOKO DONAT BAHAGIA");
                Console.WriteLine("==========================================");
                Console.WriteLine("Kami menyediakan berbagai donat lezat 🍩");
                Console.WriteLine("Tekan ENTER untuk mulai berbelanja...");
                Console.ReadLine();

                // Perulangan menu utama
                while (lanjutBelanja)
                {
                    Console.Clear();
                    Console.WriteLine("==========================================");
                    Console.WriteLine("              MENU TOKO DONAT");
                    Console.WriteLine("==========================================");
                    Console.WriteLine("1. Donat Coklat    - Rp10.000");
                    Console.WriteLine("2. Donat Keju      - Rp15.000");
                    Console.WriteLine("3. Donat Tiramisu  - Rp16.000");
                    Console.WriteLine("0. Selesai dan Bayar");
                    Console.WriteLine("==========================================");
                    Console.Write("Pilih nomor donat yang ingin dibeli: ");
                    string pilihan = Console.ReadLine();

                    switch (pilihan)
                    {
                        case "1":
                            Console.Write("\nMasukkan jumlah Donat Coklat yang ingin dibeli: ");
                            int jCoklat = int.Parse(Console.ReadLine());
                            jumlahCoklat += jCoklat;
                            totalBayar += jCoklat * hargaCoklat;
                            Console.WriteLine($"Anda membeli {jCoklat} Donat Coklat (Rp{jCoklat * hargaCoklat:N0})");
                            break;

                        case "2":
                            Console.Write("\nMasukkan jumlah Donat Keju yang ingin dibeli: ");
                            int jKeju = int.Parse(Console.ReadLine());
                            jumlahKeju += jKeju;
                            totalBayar += jKeju * hargaKeju;
                            Console.WriteLine($"Anda membeli {jKeju} Donat Keju (Rp{jKeju * hargaKeju:N0})");
                            break;

                        case "3":
                            Console.Write("\nMasukkan jumlah Donat Tiramisu yang ingin dibeli: ");
                            int jTiramisu = int.Parse(Console.ReadLine());
                            jumlahTiramisu += jTiramisu;
                            totalBayar += jTiramisu * hargaTiramisu;
                            Console.WriteLine($"Anda membeli {jTiramisu} Donat Tiramisu (Rp{jTiramisu * hargaTiramisu:N0})");
                            break;

                        case "0":
                            lanjutBelanja = false;
                            break;

                        default:
                            Console.WriteLine("Pilihan tidak ada! Silakan pilih lagi.");
                            break;
                    }

                    if (lanjutBelanja)
                    {
                        Console.WriteLine("\nApakah ingin membeli donat lain? (y/n)");
                        string lagi = Console.ReadLine().ToLower();
                        if (lagi != "y")
                        {
                            lanjutBelanja = false;
                        }
                    }
                }

                // Tampilkan struk pembayaran
                Console.Clear();
                Console.WriteLine("==========================================");
                Console.WriteLine("             STRUK PEMBAYARAN");
                Console.WriteLine("==========================================");

                if (jumlahCoklat > 0)
                    Console.WriteLine($"Donat Coklat   x{jumlahCoklat} = Rp{jumlahCoklat * hargaCoklat:N0}");
                if (jumlahKeju > 0)
                    Console.WriteLine($"Donat Keju     x{jumlahKeju} = Rp{jumlahKeju * hargaKeju:N0}");
                if (jumlahTiramisu > 0)
                    Console.WriteLine($"Donat Tiramisu x{jumlahTiramisu} = Rp{jumlahTiramisu * hargaTiramisu:N0}");

                Console.WriteLine("------------------------------------------");
                Console.WriteLine($"Total yang harus dibayar: Rp{totalBayar:N0}");
                Console.Write("Masukkan uang pembeli: Rp");
            int uang = int.Parse(Console.ReadLine());

                if (uang >= totalBayar)
                {
                    int kembalian = uang - totalBayar;
                    Console.WriteLine($"Uang kembalian: Rp{kembalian:N0}");
                    Console.WriteLine("\nTerima kasih sudah membeli di Toko Donat Bahagia!");
                }
                else
                {
                    Console.WriteLine("Maaf, uang tidak cukup untuk membayar!");
                }

                // Laporan kecil di akhir
                Console.WriteLine("\n==========================================");
                Console.WriteLine("         LAPORAN PENJUALAN HARI INI");
                Console.WriteLine("==========================================");
                Console.WriteLine($"Donat Coklat   terjual: {jumlahCoklat}");
                Console.WriteLine($"Donat Keju     terjual: {jumlahKeju}");
                Console.WriteLine($"Donat Tiramisu terjual: {jumlahTiramisu}");
                Console.WriteLine("------------------------------------------");
                Console.WriteLine($"Total uang masuk: Rp{totalBayar:N0}");
                Console.WriteLine("==========================================");
                Console.WriteLine("Terima kasih! Semoga harimu semanis donat 🍩");
                Console.ReadLine();
            }
        }
    }

    

