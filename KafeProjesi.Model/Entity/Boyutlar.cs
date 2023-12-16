using Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafeProjesi.Model.Entity
{
    public class Boyutlar:BaseEntity,IBaseDomain
    {
        public int Id { get; set; }
        public int BoyutId { get; set; }
        public string BoyutAdi { get; set; }

    }


}
