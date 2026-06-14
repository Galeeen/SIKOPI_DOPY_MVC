using System;
using System.Collections.Generic;
using System.Text;

namespace SIKOPI_DOPY_MVC.Models
{
    public class RingkasanPenjualan
    {
        public int TotalTransaksiHariIni { get; set; }
        public decimal OmzetHariIni { get; set; }
        public decimal ProdukTerjualGramHariIni { get; set; }
        public int TotalTransaksiSemua { get; set; }
    }
}
