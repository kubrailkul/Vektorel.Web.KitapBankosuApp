using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vektorel.Windows.KitapBankosuApp.Models
{
    public class YazarViewModel
    {
        public IEnumerable<Yazar> Yazarlar { get; set; }
        public Yazar yazar { get; set; }
    }
}