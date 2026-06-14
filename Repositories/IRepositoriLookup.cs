using System;
using System.Collections.Generic;
using System.Text;
using SIKOPI_DOPY_MVC.Models;

namespace SIKOPI_DOPY_MVC.Repositories
{
    public interface IRepositoriLookup
    {
        List<LookupItem> AmbilJenisBiji();
        List<LookupItem> AmbilMetodeProses();
        List<LookupItem> AmbilGreenBeanAktif();

        List<GreenBeanLookupItem> AmbilGreenBeanAktifDetail();
    }
}
