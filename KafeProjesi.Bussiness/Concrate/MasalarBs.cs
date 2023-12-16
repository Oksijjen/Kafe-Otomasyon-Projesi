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
    public class MasalarBs : IMasalarBs
    {
        IMasalarRepository repo;

        public MasalarBs(IMasalarRepository _repo)
        {
            repo = repo;
        }
        public void Delete(Masalar entity)
        {
            repo.Delete(entity);
        }

        public Masalar Get(Expression<Func<Masalar, bool>> filter, params string[] includelist)
        {
            return repo.Get(filter, includelist);
        }

        public List<Masalar> GetAll(Expression<Func<Masalar, bool>> filter = null, params string[] includelist)
        {
            return repo.GetAll(filter, includelist);
        }

        public void Insert(Masalar entity)
        {
            repo.Insert(entity);
        }

        public void Update(Masalar entity)
        {
            repo.Update(entity);
        }
    }
}

