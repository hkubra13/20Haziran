using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20Haziran
{
    public class Kitap
    {
        public int kitapId { get; set; }
        public string kitapAd { get; set; }
        public string yazarAd { get; set; }
        public int sayfaNo { get; set; }
        public string yayınevi { get; set; }
        public DateTime basimTarihi { get; set; }
        
        public int yazarId { get; set; }
        public int yayıneviId { get; set; }

    }
}
