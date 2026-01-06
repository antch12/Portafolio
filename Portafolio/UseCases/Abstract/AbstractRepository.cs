using Portafolio.Models;
using Portafolio.Models.Interfaces;

namespace Portafolio.UseCases.Abstract
{
    public abstract class AbstractRepository<TEntity>
        where TEntity : class, IEntity
    {
        protected readonly TaskContext _context;
        protected readonly List<TEntity> _set;

        protected AbstractRepository(TaskContext context, List<TEntity> set)
        {
            _context = context;
            _set = set;
        }

        public virtual IEnumerable<TEntity> GetAll()
            => _set;

        public virtual TEntity? GetById(Guid id)
            => _set.FirstOrDefault(x => x.Id == id);

        public virtual void Add(TEntity entity)
        {
            _set.Add(entity);
        }

        public virtual void Remove(Guid id)
        {
            var entity = GetById(id);
            if (entity != null)
                _set.Remove(entity);
        }
    }
}
