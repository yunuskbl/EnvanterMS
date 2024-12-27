using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvanterMS.DOMAIN.Entities
{
    public class Order : IEntity
    {
        public int OrderID{ get; set; }
        public int MüsteriID { get; set; }
        public int PersonelID { get; set; }
        public DateTime SatisTarihi { get; set; }
        public DateTime OdemeTarihi { get; set; }
        public DateTime SevkTarihi { get; set; }
        public int ShipVia { get; set; }
        public decimal NakliyeUcreti { get; set; }
        public string SevkAdi { get; set; }
        public string SevkAdresi { get; set; }
        public string SevkSehri { get; set; }
        public string SevkBolgesi { get; set; }
        public string SevkPostaKodu { get; set; }
        public string SevkUlkesi { get; set; }
        public Customer Customer { get; set; }  
        public List<Product> Products { get; set; } = new List<Product> { };
    }
}
