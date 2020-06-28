using System;
using System.Collections.Generic;
using System.Text;
using Tugas_minggu_ke_11.Induk;

namespace Tugas_minggu_ke_11.Anak
{
    public class KTetap :Karyawan
    {
        public double GajiBulanan { get; set; }
        public override double Gaji()
        {
            return GajiBulanan;
        }
    }
}
