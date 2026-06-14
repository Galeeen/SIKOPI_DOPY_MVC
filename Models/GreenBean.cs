using System;
using System.Collections.Generic;
using System.Text;

namespace SIKOPI_DOPY_MVC.Models
{
    public class GreenBean : BaseEntity
    {
        public int IdJenisBijiKopiMentah { get; set; }
        public int IdMetodeProses { get; set; }

        public string NamaBiji { get; set; } = "";
        public string AsalDaerah { get; set; } = "";
        public int KetinggianMdpl { get; set; }
        public string TingkatKualitas { get; set; } = "";

        public decimal StokKg { get; set; }
        public decimal HargaPerKg { get; set; }

        public DateTime? TanggalPanen { get; set; }
    }
}
