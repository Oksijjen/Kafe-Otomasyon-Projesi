using Core.DataAccess.Absract;
using Core.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.Concrate.EntityFramework
{
    public class EfRepositoryBase<Entity,TContext> : IRepository<Entity>
        where Entity : BaseEntity, IBaseDomain
        where TContext : DbContext, new()
    {
        public void Delete(Entity entity)
        {
            
            using(TContext ctx = new TContext())
            {
                ctx.Set<Entity>().Remove(entity);
                ctx.SaveChanges();
            }
            
        }

        public Entity Get(Expression<Func<Entity, bool>> filter=null, params string[] includelist)
        {
            using (TContext ctx = new TContext())
            {
                IQueryable<Entity> query = ctx.Set<Entity>();
                if (includelist.Length>0)
                {
                    foreach (string item in includelist)
                    {
                        query = query.Include(item);
                    }
                }
                
                return filter == null ? query.ToList().FirstOrDefault() : query.SingleOrDefault(filter);
            }
        }

        public List<Entity> GetAll(Expression<Func<Entity, bool>> filter=null, params string[] includelist)
        {
            using (TContext ctx = new TContext())
            {
                IQueryable<Entity> query = ctx.Set<Entity>();
                if (includelist.Length > 0)
                {
                    foreach (string item in includelist)
                    {
                        query = query.Include(item);
                    }
                }
                

                return filter == null ? query.ToList() : query.Where(filter).ToList();
            }
        }

        public void Insert(Entity entity)
        {
            using (TContext ctx = new TContext())
            {
                ctx.Set<Entity>().Add(entity);
                ctx.SaveChanges();
            }
        }

        public void Update(Entity entity)
        {
            using (TContext ctx = new TContext())
            {
                ctx.Set<Entity>().Update(entity);
                ctx.SaveChanges();
            }
        }
    }
}
