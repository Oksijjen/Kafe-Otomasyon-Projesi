using Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafeProjesi.Model.Entity
{
    public class Masalar:BaseEntity,IBaseDomain
    {
        public int Id { get; set; }
        public int MasaNo { get; set; }
        public int MasaSayisi { get; set; }
        

    }
}
