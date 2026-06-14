using System;
using System.Collections.Generic;
using System.Text;

namespace SIKOPI_DOPY_MVC.Models
{
    public class LookupItem : BaseEntity
    {
        public string Nama { get; set; } = "";
        public override string ToString()
        {
            return Nama;
        }
    }
}
