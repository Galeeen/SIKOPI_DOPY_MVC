using System;
using System.Collections.Generic;
using System.Text;

namespace SIKOPI_DOPY_MVC.Models
{
   public class Pengguna : BaseEntity
    {
        public string NamaPengguna { get; set; } = "";
        public string KataSandi { get; set; } = "";
        public string NamaLengkap { get; set; } = "";
        public string Peran { get; set; } = "";
    }
}
