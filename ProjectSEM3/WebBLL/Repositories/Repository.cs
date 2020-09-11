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
    public class Repository<T>:IRepository<T> where T:class,new()
    {
        protected ShopDbContext ctx;
        protected DbSet<T> tbl;
        public Repository()
        {
            ctx = new ShopDbContext();
            tbl = ctx.Set<T>();
        }
        public bool Add(T entity)
        {
            throw new NotImplementedException();
        }

        public bool Edit(T entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> Get()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> Get(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public T Get(object id)
        {
            throw new NotImplementedException();
        }

        public bool Remove(object id)
        {
            throw new NotImplementedException();
        }
    }
}
