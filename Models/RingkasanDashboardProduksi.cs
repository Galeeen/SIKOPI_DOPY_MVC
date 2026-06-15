using System;
using System.Collections.Generic;
using System.Text;
namespace SIKOPI_DOPY_MVC.Models
{
    public class RingkasanDashboardProduksi
    {
        public int TotalBatch { get; set; }
        public int BatchHariIni { get; set; }
        public decimal GreenBeanDipakaiHariIniGram { get; set; }
        public decimal HasilRoastingHariIniGram { get; set; }
        public decimal TotalStokRoastBeanGram { get; set; }
        public int ProdukMenungguHarga { get; set; }
    }
}