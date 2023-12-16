using KafeProjesi.Bussiness.Abstract;
using KafeProjesi.DataAccess.Abstract;
using KafeProjesi.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace KafeProjesi.Bussiness.Concrate
{
    public class UstKategoriBs : IUstKategoriBs
    {
        IUstKategoriRepository repo;
        public UstKategoriBs(IUstKategoriRepository _repo)
        {
            repo = _repo;
        }

        public void Delete(Ustkategori entity)
        {
            throw new NotImplementedException();
        }

        public Ustkategori Get(Expression<Func<Ustkategori, bool>> filter, params string[] includelist)
        {
            throw new NotImplementedException();
        }

        public List<Ustkategori> GetAll(Expression<Func<Ustkategori, bool>> filter = null, params string[] includelist)
        {
            throw new NotImplementedException();
        }

        public void Insert(Ustkategori entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Ustkategori entity)
        {
            throw new NotImplementedException();
        }
    }
}
