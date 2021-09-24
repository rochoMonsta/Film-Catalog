using FilmCatalog.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace FilmCatalog.Helpers
{
    public class GenericRepository
    {
        private readonly DbContext _context;

        public GenericRepository(DbContext context)
        {
            _context = context;
        }

        public Task<TEntity> Get<TEntity>(int id) where TEntity : DomainObject
        {
            return _context.Set<TEntity>().FirstOrDefaultAsync(e => e.Id == id);
        }

        public Task<List<TEntity>> GetAll<TEntity>() where TEntity : DomainObject
        {
            return  _context.Set<TEntity>().ToListAsync();
        }

        public Task<List<TEntity>> GetAllByPredicate<TEntity>(Expression<Func<TEntity, bool>> predicate) where TEntity : DomainObject
        {
            return _context.Set<TEntity>().Where(predicate).ToListAsync();
        }

        public TEntity Update<TEntity>(int id, TEntity entity) where TEntity : DomainObject
        {
            try
            {
                entity.Id = id;
                _context.Set<TEntity>().Update(entity);
            }
            catch (Exception ex)
            {
                var log = ex;
            }
            return entity;
        }

        public List<TEntity> UpdateAll<TEntity>(IEnumerable<TEntity> items) where TEntity : DomainObject
        {
            var updatedItems = new List<TEntity>();
            try
            {
                foreach (var item in items)
                {
                    _context.Set<TEntity>().Update(item);
                    updatedItems.Add(item);
                }
            }
            catch (Exception ex)
            {
                var log = ex;
            }
            return updatedItems;
        }

        public void Delete<TEntity>(int id) where TEntity : DomainObject
        {
            TEntity entity = _context.Set<TEntity>().FirstOrDefault((e) => e.Id == id);

            if (entity == null)
            {
                return;
            }

            _context.Set<TEntity>().Remove(entity);
        }

        public void Delete<TEntity>(TEntity item) where TEntity : DomainObject
        {
            if (item != null)
            {
                TEntity entity = _context.Set<TEntity>().FirstOrDefault((e) => e.Id == item.Id);

                if (entity != null)
                {
                    _context.Set<TEntity>().Remove(entity);
                }
            }
        }

        public void DeleteAll<TEntity>(List<TEntity> items) where TEntity : DomainObject
        {
            if (items.Count <= 0)
            {
                return;
            }

            foreach (TEntity p in items.Select(domainObject => _context.Set<TEntity>().FirstOrDefault(x => x.Id == domainObject.Id)))
            {
                if (p == null)
                {
                    return;
                }

                try
                {
                    _context.Set<TEntity>().Remove(p);
                }
                catch (Exception ex)
                {
                    var log = ex;
                }
            }
        }
    }
}
