using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Repository.Repositories
{
    public class GenericRepository<TEntity> where TEntity : class
    {
        internal AppFileContext context;
        internal DbSet<TEntity> dbSet;

        public GenericRepository(AppFileContext context)
        {
            this.context = context;
            this.dbSet = context.Set<TEntity>();
        }
        public IEnumerable<TEntity> Get()
        {
            return dbSet.ToList();
        }

        public virtual void Insert(TEntity entity)
        {
            dbSet.Add(entity);
            context.SaveChanges();
        }
        public virtual void Delete(object id)
        {
            TEntity entity = dbSet.Find(id);
            dbSet.Remove(entity);
            context.SaveChanges();
        }
    }
}
