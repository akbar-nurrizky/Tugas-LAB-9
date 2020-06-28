using System;
using System.Collections.Generic;
using System.Text;
using Tugas_minggu_ke_11.Induk;

namespace Tugas_minggu_ke_11.Anak
{
    public class Sales : Karyawan
    {
        public int JumlahPenjualan { get; set; }
        public int Komisi { get; set; }
        public override double Gaji()
        {
            return JumlahPenjualan * Komisi;
        }
    }
}
