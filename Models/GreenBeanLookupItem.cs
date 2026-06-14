using System;
using System.Collections.Generic;
using System.Text;
namespace SIKOPI_DOPY_MVC.Models
{
    public class GreenBeanLookupItem
    {
        public int Id { get; set; }
        public string Nama { get; set; } = "";
        public string AsalDaerah { get; set; } = "";
        public string MetodeProses { get; set; } = "";
        public decimal StokKg { get; set; }
    }
}