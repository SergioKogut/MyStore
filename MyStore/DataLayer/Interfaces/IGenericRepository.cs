using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MyStore.DataLayer.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {

        IEnumerable<TEntity> Get();
        TEntity GetByID(object id);
        void Insert(TEntity entity);
        void Delete(object id);
        void Delete(TEntity entityToDelete);
        void Update(TEntity entityToUpdate);
        IEnumerable<TEntity> GetMany(Func<TEntity, bool> where);
        IQueryable<TEntity> GetManyQueryable(Func<TEntity, bool> where);
        TEntity Get(Func<TEntity, Boolean> where);
        void Delete(Func<TEntity, Boolean> where);
        IEnumerable<TEntity> GetAll();
        IQueryable<TEntity> GetWithInclude(System.Linq.Expressions.Expression<Func<TEntity, bool>> predicate, params string[] include);
        bool Exists(object primaryKey);
        TEntity GetSingle(Func<TEntity, bool> predicate);
        TEntity GetFirst(Func<TEntity, bool> predicate);
        //TEntity GetById(int id);
        //Task<TEntity> GetByIdAsync(int id);
        //IEnumerable<TEntity> Get();
        //Task<IEnumerable<TEntity>> GetAsync(Expression<Func<TEntity, bool>> predicate);
        //IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> predicate);
        //IQueryable<TEntity> GetQueryable();
        //IQueryable<TEntity> GetQueryable(Expression<Func<TEntity, bool>> predicate);
        //TEntity GetSingle(Expression<Func<TEntity, bool>> predicate);
        //Task<TEntity> GetSingleAsync(Expression<Func<TEntity, bool>> predicate);
        //void Add(TEntity entity);
        //void Delete(TEntity entity);
        //void Edit(TEntity entity);

    }
}
