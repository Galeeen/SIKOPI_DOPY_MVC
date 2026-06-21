using System;
using System.Collections.Generic;
using System.Text;

namespace SIKOPI_DOPY_MVC.Models
{
    public class PembelianProduk
    {
        public int IdRoasted { get; set; }
        public int IdPengguna { get; set; }

        public string NamaPembeli { get; set; } = "";
        public decimal JumlahGram { get; set; }
    }
}   