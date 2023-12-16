using Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace KafeProjesi.Bussiness.Abstract
{
    public interface IBussinessBase<TEntity>
        where TEntity : BaseEntity,IBaseDomain
    {
        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        List<TEntity> GetAll(Expression<Func<TEntity,bool>> filter = null, params string[] includelist);
        TEntity Get(Expression<Func<TEntity, bool>> filter, params string[] includelist);
    }
}
