using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WebDAL.DataModels;

namespace WebBLL.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {

        protected ShopContext db;

        public object Get()
        {
            throw new NotImplementedException();
        }

        protected DbSet<TEntity> tbl;

        public Repository()
        {
            db = new ShopContext();
            tbl = db.Set<TEntity>();
        }
        public bool Add(TEntity entity)
        {
            try
            {
                tbl.Add(entity);
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool AddRange(IEnumerable<TEntity> entities)
        {
            try
            {
                tbl.AddRange(entities);
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool Edit(TEntity entity)
        {
            try
            {
                db.Entry(entity).State = EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public TEntity Get(object id)
        {
            return tbl.Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return tbl;
        }

        public IEnumerable<TEntity> GetBy(Func<TEntity, bool> predicate)
        {
            return tbl.Where(predicate);
        }

        public TEntity GetBy1(Expression<Func<TEntity, bool>> where)
        {
            try
            {
                return tbl.Where(where).FirstOrDefault();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool Remove(object id)
        {
            try
            {
                tbl.Remove(Get(id));
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool Remove(TEntity entity)
        {
            try
            {
                tbl.Remove(entity);
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool RemoveRange(IEnumerable<TEntity> entities)
        {
            try
            {
                tbl.RemoveRange(entities);
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public TEntity SingleBy(Func<TEntity, bool> predicate)
        {
            return tbl.FirstOrDefault(predicate);
        }

        public bool Update(TEntity entity)
        {
            try
            {
                tbl.Attach(entity);
                db.Entry(entity).State = EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }
    }
}

