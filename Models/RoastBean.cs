using System;
using System.Collections.Generic;
using System.Text;

namespace SIKOPI_DOPY_MVC.Models
{
    public class RoastBean : BaseEntity
    {
        public int IdBatch { get; set; }

        public string NamaProduk { get; set; } = "";
        public decimal StokGram { get; set; }
        public decimal HargaPerGram { get; set; }
        public string StatusHarga { get; set; } = "";

        public string KodeBatch { get; set; } = "";
        public string LevelRoasting { get; set; } = "";
        public string AsalDaerah { get; set; } = "";
        public string Catatan { get; set; } = "";
    }
}
