using System;
using System.Collections.Generic;
using System.Text;
using Tugas_minggu_ke_11.Induk;

namespace Tugas_minggu_ke_11.Anak
{
    public class KHarian : Karyawan
    {
        public int JumlahJamKerja { get; set; }
        public int UpahPerJam { get; set; }
        public override double Gaji()
        {
            return JumlahJamKerja * UpahPerJam;
        }
    }
}
