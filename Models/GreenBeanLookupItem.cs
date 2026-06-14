using System;
using System.Collections.Generic;
using System.Text;

namespace SIKOPI_DOPY_MVC.Models
{
    public class GreenBeanLookupItem : LookupItem
    {
        public decimal StokKg { get; set; }
        public string AsalDaerah { get; set; } = "";
        public string MetodeProses { get; set; } = "";
    }
}
