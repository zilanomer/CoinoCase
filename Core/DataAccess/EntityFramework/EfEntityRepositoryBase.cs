using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity,TContext>: IEntityRepository<TEntity>
         where TEntity : class, IEntitiy, new()
        where TContext : DbContext, new()
    {

        public void Add(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var addedEntity = context.Entry(entity); //ef de refferansı yakalama 
                addedEntity.State = EntityState.Added;    // eklenecek nesne
                context.SaveChanges();        // ekle 
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var deletedEntity = context.Entry(entity); //ef de refferansı yakalama 
                deletedEntity.State = EntityState.Deleted;    // silinecek nesne
                context.SaveChanges();        // sil 
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {

                return context.Set<TEntity>().SingleOrDefault(filter);
            }


        }
        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                // filter null ise tümünü getir değilse 
                return filter == null // filter null mı 
                    ? context.Set<TEntity>().ToList() // evet ise bu çalışır
                    : context.Set<TEntity>().Where(filter).ToList(); // filter null değilse bu çalışır
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var updatedEntity = context.Entry(entity); //ef de refferansı yakalama 
                updatedEntity.State = EntityState.Modified;    // güncellenecek nesne
                context.SaveChanges();        // güncelle 
            }
        }
    }
}
