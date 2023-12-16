using Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.Absract
{
    public interface IRepository<TEntity>
        where TEntity : BaseEntity, IBaseDomain
    {
        void Insert(TEntity entity);
        void Delete(TEntity entity);
        void Update(TEntity entity);
        List<TEntity> GetAll(Expression<Func<TEntity,bool>> filter=null,params string[] includelist);
        TEntity Get(Expression<Func<TEntity, bool>> filter=null, params string[] includelist);
    }
}
