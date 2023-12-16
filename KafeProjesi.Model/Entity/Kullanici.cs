using Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafeProjesi.Model.Entity
{
    public class Kullanici: BaseEntity, IBaseDomain
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Sifre { get; set; }
        public string KullaniciAdi { get; set; }
        public int KullaniciId { get; set; }
    }
}
