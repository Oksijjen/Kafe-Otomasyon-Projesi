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
    public class UrunBs : IUrunBs
    {
        IUrunRepository repo;

        public UrunBs(IUrunRepository _repo)
        {
            repo = _repo;
        }

        public void Delete(Urun entity)
        {
            repo.Delete(entity);
        }

        public Urun Get(Expression<Func<Urun, bool>> filter, params string[] includelist)
        {
            return repo.Get(filter, includelist);
        }

        public List<Urun> GetAll(Expression<Func<Urun, bool>> filter = null, params string[] includelist)
        {
            return repo.GetAll(filter, includelist);
        }

        public void Insert(Urun entity)
        {
            repo.Insert(entity);
        }

        public void Update(Urun entity)
        {
            repo.Update(entity);
        }
    }
}
