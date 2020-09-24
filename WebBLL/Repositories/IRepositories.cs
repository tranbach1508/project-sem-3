using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace WebBLL.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        // lấy tất cả các bản ghi
        IEnumerable<TEntity> GetAll();

        // lấy các bản ghi theo điều kiện ( predicate: biểu thức điều kiện )
        IEnumerable<TEntity> GetBy(Func<TEntity, bool> predicate);

        // lấy 1 đối tượng theo khóa chính ID
        TEntity Get(object id);

        // lấy 1 đối tượng theo điều kiện
        TEntity SingleBy(Func<TEntity, bool> predicate);

        bool Add(TEntity entity);
        // phương thức add nhiều
        bool AddRange(IEnumerable<TEntity> entities);
        bool Edit(TEntity entity);
        bool Remove(object id);
        bool Remove(TEntity entity);

        // phương thức xóa nhiều
        bool RemoveRange(IEnumerable<TEntity> entities);

        bool Update(TEntity entity);

        TEntity GetBy1(Expression<Func<TEntity, bool>> where);

    }
}
