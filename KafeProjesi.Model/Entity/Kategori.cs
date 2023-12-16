using Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafeProjesi.Model.Entity
{
    public class Kategori:BaseEntity,IBaseDomain
    {
        public int Id { get; set; }
        public string KategoriAdi { get; set; }
        public int UstKategoriId { get; set; }
    }
}
