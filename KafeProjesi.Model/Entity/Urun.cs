using Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafeProjesi.Model.Entity
{
    public class Urun:BaseEntity,IBaseDomain
    {
        public int Id { get; set; }
        public string UrunAdi { get; set; }
        public decimal UrunFiyati { get; set; }
        public string UrunAciklamasi { get; set; }
        public string BoyutAdi { get; set; }



        public string KategoriAdi { get; set; }
    }
}
