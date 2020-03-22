using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Personel_Yonetim_Sistemi.Models.EntityFramework;

namespace Personel_Yonetim_Sistemi.ViewModel
{
    public class PersonelForm
    {
        public IEnumerable<Departman> Departmalar { get; set; }
        public IEnumerable<Personel> Personeller { get; set; }
    }
}