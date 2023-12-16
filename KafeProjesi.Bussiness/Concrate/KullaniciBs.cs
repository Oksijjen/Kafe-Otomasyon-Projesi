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
    public class KullaniciBs : IKullaniciBs
    {
        IKullaniciRepository repo;

        public KullaniciBs(IKullaniciRepository _repo)
        {
            repo = repo;
        }

        public void Delete(Kullanici entity)
        {
            repo.Delete(entity);
        }

        public Kullanici Get(Expression<Func<Kullanici, bool>> filter, params string[] includelist)
        {
            return repo.Get(filter, includelist);
        }

        public List<Kullanici> GetAll(Expression<Func<Kullanici, bool>> filter = null, params string[] includelist)
        {
            return repo.GetAll(filter, includelist);
        }

        public void Insert(Kullanici entity)
        {
            repo.Insert(entity);
        }

        public void Update(Kullanici entity)
        {
            repo.Update(entity);
        }
    }
}
