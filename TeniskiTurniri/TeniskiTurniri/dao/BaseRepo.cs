using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeniskiTurniri.dao
{
    public abstract class BaseRepo<TEntity> : IRepository<TEntity> where TEntity : class
    {
        public BaseRepo() { }

        public void Delete(object id)
        {
            using (var db = new ModelTeniskiTurniriContainer())
            {
                DbSet<TEntity> dbset = db.Set<TEntity>();
                TEntity entityToDelete = db.Set<TEntity>().Find(id);
                db.Entry(entityToDelete).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public TEntity FindById(object id)
        {
            using (var db = new ModelTeniskiTurniriContainer())
            {
                return db.Set<TEntity>().Find(id);
            }
        }

        public List<TEntity> GetList()
        {
            using (var db = new ModelTeniskiTurniriContainer())
            {
                return db.Set<TEntity>().ToList();
            }
        }

        public void Insert(TEntity entity)
        {
            using (var db = new ModelTeniskiTurniriContainer())
            {
                
                db.Set<TEntity>().Add(entity);
                db.SaveChanges();
            }
        }

        public void Update(TEntity entityToUpdate)
        {
            using (var db = new ModelTeniskiTurniriContainer())
            {
                db.Set<TEntity>().Attach(entityToUpdate);
                db.Entry(entityToUpdate).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

       /* public override void Update(TEntity entity) where TEntity : IEntity
        {
            if (entity == null)
            {
                throw new ArgumentException("Cannot add a null entity.");
            }

            var entry = db.Entry<TEntity>(entity);

            if (entry.State == EntityState.Detached)
            {
                var set = db.Set<TEntity>();
                TEntity attachedEntity = set.Local.SingleOrDefault(e => e.Id == entity.Id);  // You need to have access to key

                if (attachedEntity != null)
                {
                    var attachedEntry = db.Entry(attachedEntity);
                    attachedEntry.CurrentValues.SetValues(entity);
                }
                else
                {
                    entry.State = EntityState.Modified; // This should attach entity
                }
            }
        }*/
    }
}
