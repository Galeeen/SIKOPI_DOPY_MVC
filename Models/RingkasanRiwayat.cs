using System;
using System.Collections.Generic;
using System.Text;
namespace SIKOPI_DOPY_MVC.Models
{
    public class RingkasanRiwayat
    {
        public decimal GreenBeanMasukKg { get; set; }
        public decimal GreenBeanKeluarKg { get; set; }

        public decimal RoastBeanMasukGram { get; set; }
        public decimal RoastBeanKeluarGram { get; set; }

        public int JumlahTransaksi { get; set; }
        public decimal TotalPenjualan { get; set; }
    }
}