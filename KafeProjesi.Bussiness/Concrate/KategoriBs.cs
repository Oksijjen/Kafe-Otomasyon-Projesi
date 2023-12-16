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
    public class KategoriBs : IKategoriBs
    {
        IKategoriRepository repo;
        public KategoriBs(IKategoriRepository _repo)
        {
            repo = repo;
        }

        public void Delete(Kategori entity)
        {
            repo.Delete(entity);
        }

        public Kategori Get(Expression<Func<Kategori, bool>> filter, params string[] includelist)
        {
            return repo.Get(filter, includelist);
        }

        public List<Kategori> GetAll(Expression<Func<Kategori, bool>> filter = null, params string[] includelist)
        {
            return repo.GetAll(filter, includelist);
        }

        public void Insert(Kategori entity)
        {
            repo.Insert(entity);
        }

        public void Update(Kategori entity)
        {
            repo.Update(entity);
        }
    }
}
