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
    public class BoyutlarBs : IBoyutlarBs
    {
        IBoyutlarRepository repo;
        public BoyutlarBs(IBoyutlarRepository _repo)
        {
            repo = repo;
        }
        public void Delete(Boyutlar entity)
        {
            repo.Delete(entity);
        }

        public Boyutlar Get(Expression<Func<Boyutlar, bool>> filter, params string[] includelist)
        {
            return repo.Get(filter, includelist);
        }

        public List<Boyutlar> GetAll(Expression<Func<Boyutlar, bool>> filter = null, params string[] includelist)
        {
            return repo.GetAll(filter, includelist);
        }

        public void Insert(Boyutlar entity)
        {
            repo.Insert(entity);
        }

        public void Update(Boyutlar entity)
        {
            repo.Update(entity);
        }
    }
}
