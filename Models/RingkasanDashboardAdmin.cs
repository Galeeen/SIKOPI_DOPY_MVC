using System;
using System.Collections.Generic;
using System.Text;

namespace SIKOPI_DOPY_MVC.Models
{
    public class RingkasanDashboardAdmin
    {
        public decimal TotalGreenBeanKg { get; set; }
        public decimal TotalRoastBeanGram { get; set; }
        public int TotalBatch { get; set; }
        public int BatchHariIni { get; set; }

        public int ProdukSiapJual { get; set; }
        public int ProdukMenungguHarga { get; set; }
        public int TransaksiHariIni { get; set; }
        public decimal OmzetHariIni { get; set; }
    }
}