using System;
using System.Collections.Generic;
using System.Text;

namespace SIKOPI_DOPY_MVC.Models
{
    public class BatchRoasting : BaseEntity
    {
        public int IdBijiMentah { get; set; }
        public int IdPengguna { get; set; }

        public string KodeBatch { get; set; } = "";
        public decimal JumlahBijiDipakaiGram { get; set; }
        public decimal HasilRoastingGram { get; set; }
        public string LevelRoasting { get; set; } = "";
        public DateTime TanggalBatch { get; set; } = DateTime.Now;
        public string Catatan { get; set; } = "";
    }
}
