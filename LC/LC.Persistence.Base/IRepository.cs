using System;

namespace LC.Persistence.Base
{
    public interface IRepository<TEntity>
    {
        TEntity Get(Guid id);
        //TEntity GetOne(ISpecification<TEntity> spec);
        //IEnumerable<TEntity> Get(ISpecification<TEntity> spec);
        void Add(TEntity entity);
        void Remove(TEntity entity);
        void Update(TEntity entity);
        void Save(TEntity entity);
    }
}
