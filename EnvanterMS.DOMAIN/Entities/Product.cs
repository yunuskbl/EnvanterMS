using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvanterMS.DOMAIN.Entities
{
    public class Product : IEntity
    {
        public int ProductID { get; set; }
        public int TedarikciID { get; set; }
        public int KategoriID { get; set; }
        public string UrunAdi { get; set; }
        public int BirimdekiMiktar { get; set; }
        public decimal BirimFiyat { get; set; }
        public int HedefStokDuzeyi { get; set; }
        public int YeniSatis { get; set; }
        public int EnAzYenidenSatisMiktari { get; set; }
        public string Sonlandi { get; set; }
    }
}
