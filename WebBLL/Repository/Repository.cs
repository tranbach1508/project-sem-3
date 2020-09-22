using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WebDAL.DataModels;

namespace WebBLL.Repository
{
    public class Repository<T> : IRepository<T> where T : class,new()
    {
        public ShopContext db;
        public DbSet<T> tbl;
        public Repository()
        {
            db = new ShopContext();
            tbl = db.Set<T>();
        }
        public bool Add(T entity)
        {
            tbl.Add(entity);
            SaveChange();
            return true;
        }

        public bool Edit(T entity)
        {
            db.Entry(entity).State = EntityState.Modified;
            SaveChange();
            return true;
        }

        public IEnumerable<T> Get()
        {
            return tbl.ToList();
        }

        public IEnumerable<T> Get(Expression<Func<T, bool>> predicate)
        {
            return tbl.Where(predicate);
        }

        public T Get(object id)
        {
            return tbl.Find(id);
        }

        public bool Remove(object id)
        {
            tbl.Remove(tbl.Find(id));
            SaveChange();
            return true;
        }

        public void SaveChange()
        {
            db.SaveChanges();
        }
    }
}
