using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_Pertemuan_11.ClassInduk
{
    public abstract class Karyawan
    {
                    public abstract string Nama { get; set; }
               public abstract string Nik { get; set; }
           public abstract double gaji();
    }
}