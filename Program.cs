using System;
using System.Collections.Generic;
using Tugas_minggu_ke_11.Anak;
using Tugas_minggu_ke_11.Induk;

namespace Tugas_minggu_ke_11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Karyawan> listkaryawan = new List<Karyawan>();

            void TampilanKaryawan()
            {
                int Urutan = 1;

                foreach (Karyawan karyawan in listkaryawan)
                {
                    Console.WriteLine("{0}. Nama: {1}, NIK: {2}, Gaji: {3}, {4}", Urutan, karyawan.NIK, karyawan.Nama, karyawan.Gaji(), karyawan.JK);

                    Urutan++;
                }
            }

            void tambahKaryawanTetap(string nama, string nik, string jk, double gajibulanan)
            {
                listkaryawan.Add(new KTetap { Nama = nama, NIK = nik, GajiBulanan = gajibulanan, JK = jk });
            }

            void tambahKaryawanHarian(string nama, string nik, string jk, int jumlahjamkerja, int upah)
            {
                listkaryawan.Add(new KHarian { Nama = nama, NIK = nik, JK = jk, JumlahJamKerja = jumlahjamkerja, UpahPerJam = upah });
            }

            void tambahSales(string nama, string nik, string jk, int jumlahpenjualan, int komisi)
            {
                listkaryawan.Add(new Sales { Nama = nama, NIK = nik, JK = jk, JumlahPenjualan = jumlahpenjualan, Komisi = komisi });
            }

            void hapusKaryawan()
            {
                int no = 1;
                int jumlah_karyawan = 0;

                foreach (Karyawan karyawan in listkaryawan)
                {
                    Console.WriteLine("{0}. Nik: {1}", no, karyawan.NIK);

                    no++;
                    jumlah_karyawan += 1;
                }
                Console.WriteLine();
                Console.Write("Pilih Data Yang Ingin Dihapus [1-");
                Console.Write(jumlah_karyawan);
                Console.Write("] : ");
                int index_nik = int.Parse(Console.ReadLine());
                index_nik = index_nik - 1;

                listkaryawan.RemoveAt(index_nik);
                Console.WriteLine();
                Console.WriteLine("Data Karyawan Berhasil Dihapus ");
                Console.WriteLine();
                Console.WriteLine("\nTekan Enter Untuk Kembali ke Menu");
            }

            bool keluar = false;
            while (keluar == false)
            {
                Console.Title = "Tugas Lab 9 (Pertemuan 12)- Polymorphsim, Inheritance, Abstraction & Collection Part #2";
                Console.WriteLine("Pilih Menu Aplikasi :");
                Console.WriteLine();
                Console.WriteLine("1. Tambah Data Karyawan");
                Console.WriteLine("2. Hapus Data Karyawan");
                Console.WriteLine("3. Tampilkan Data Karyawan");
                Console.WriteLine("4. Keluar");
                Console.WriteLine();
                Console.Write("Nomer Menu [1..4] = ");
                int menu = int.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine();
                if (menu < 1)
                {
                    Console.WriteLine("Maaf, Menu Yang Anda Pilih Tidak Tersedia");
                }
                else if (menu > 4)
                {
                    Console.WriteLine("Maaf, Menu Yang Anda Pilih Tidak Tersedia");
                }
                else if (menu == 1)
                {
                    Console.WriteLine("Tambah Data Karyawan");
                    Console.WriteLine();
                    Console.Write("Jenis Karyawan [1. Karyawan Tetap, 2. Karyawan Harian, 3. Sales] : ");
                    int jk = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    if (jk == 1)
                    {
                        Console.Write("Nik = ");
                        string nik = Console.ReadLine();
                        Console.Write("Nama = ");
                        string nama = Console.ReadLine();
                        Console.Write("Gaji Bulanan = ");
                        int gb = int.Parse(Console.ReadLine());
                        string jenis = "Karyawan Tetap";

                        tambahKaryawanTetap(jenis, nik, nama, gb);
                    }
                    else if (jk == 2)
                    {
                        Console.Write("Nik = ");
                        string nik = Console.ReadLine();
                        Console.Write("Nama = ");
                        string nama = Console.ReadLine();
                        Console.Write("Jumlah Jam Kerja = ");
                        int jamkerja = int.Parse(Console.ReadLine());
                        Console.Write("Upah Per Jam = ");
                        int upah = int.Parse(Console.ReadLine());
                        string jenis = "Karyawan Harian";

                        tambahKaryawanHarian(jenis, nik, nama, jamkerja, upah);
                    }
                    else if (jk == 3)
                    {

                        Console.Write("Nik = ");
                        string nik = Console.ReadLine();
                        Console.Write("Nama = ");
                        string nama = Console.ReadLine();
                        Console.Write("Jumlah Jual = ");
                        int jumlahjual = int.Parse(Console.ReadLine());
                        Console.Write("Komisi = ");
                        int komisi = int.Parse(Console.ReadLine());
                        string jenis = "Sales";

                        tambahSales(jenis, nik, nama, jumlahjual, komisi);
                    }
                    else
                    {
                        Console.WriteLine("Menu salah");
                    }
                    Console.WriteLine();
                    Console.WriteLine("\nTekan Enter Untuk Kembali ke Menu");


                }
                else if (menu == 2)
                {
                    hapusKaryawan();
                }
                else if (menu == 3)
                {
                    Console.WriteLine("Data Karyawan");
                    Console.WriteLine();
                    TampilanKaryawan();

                    Console.WriteLine("\nTekan Enter Untuk Kembali ke Menu");
                }
                else if (menu == 4)
                {
                    keluar = true;
                }

                Console.ReadLine();
            }
        }
    }
}
