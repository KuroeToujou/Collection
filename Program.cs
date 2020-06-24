using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tugas_Pertemuan_11.ClassAnak;
using Tugas_Pertemuan_11.ClassInduk;

namespace Tugas_Pertemuan_11
{
    class Program
    {
        static void Main(string[] args)
        {
            KaryawanTetap karyawantetap = new KaryawanTetap();
            karyawantetap.Nik = "10-2-1888";
            karyawantetap.Nama = "Eko Sutomo";
            karyawantetap.GajiBulanan = 9000000;

            KaryawanHarian karyawanharian = new KaryawanHarian();
            karyawanharian.Nik = "19-12-3122";
            karyawanharian.Nama = "Asghaf Putra Baskoro";
            karyawanharian.JumlahJamKerja = 14;
            karyawanharian.UpahPerJam = 200000;

            Sales seles = new Sales();
            seles.Nik = "22-18-4987";
            seles.Nama = "Boyan Sasmoro Aji";
            seles.JumlahPenjualan = 14;
            seles.Komisi = 700000;

            List<Karyawan> listkaryawan = new List<Karyawan>();

            listkaryawan.Add(karyawantetap);
            listkaryawan.Add(karyawanharian);
            listkaryawan.Add(seles);

            int no = 1;
            foreach (Karyawan karyawan in listkaryawan)
            {
                Console.WriteLine("{0}. Nik: {1}, Nama: {2}, Gaji: {3}",
                no, karyawan.Nik, karyawan.Nama, karyawan.gaji());
                no++;
            }
            Console.ReadKey();
        }
    }
}