using System;
using System.Collections.Generic;
using System.Text;

namespace Tugas_minggu_ke_11.Induk
{
    public abstract class Karyawan
    {
        public string Nama { get; set; }
        public string NIK { get; set; }
        public string JK { get; set; }
        public abstract double Gaji();
    }
}
