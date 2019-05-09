using eCommerce.DAL.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.DAL.Repositories
{
    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
        
    {
        internal DataContext context;
        internal DbSet<TEntity> dbset;
        public BaseRepository(DataContext Context)
        {
            context = Context;
            dbset = context.Set<TEntity>();
        }

        public virtual TEntity GetById(object Id)
        {
            return dbset.Find(Id);
        }

        public virtual IQueryable<TEntity> GetAll()
        {
            return dbset;
        }

        public virtual void Insert(TEntity entity)
        {
            dbset.Add(entity);
            context.SaveChanges();
        }

        public virtual void Update(TEntity entity)
        {

            dbset.Attach(entity);
            context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public virtual void Delete(TEntity entity)
        {
            if (context.Entry(entity).State == EntityState.Detached)
                dbset.Attach(entity);

            dbset.Remove(entity);
            context.SaveChanges();
        }

        public virtual void DeleteById(object Id)
        {
           TEntity ent =  dbset.Find(Id);
            dbset.Remove(ent);
            context.SaveChanges();
        }
    }
}
