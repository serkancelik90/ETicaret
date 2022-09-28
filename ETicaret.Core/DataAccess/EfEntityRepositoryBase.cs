using ETicaret.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ETicaret.Core.DataAccess
{
    public class EfEntityRepositoryBase<T, TContext> : IEntityRepository<T>
        where T : class, IEntity, new()
        where TContext : DbContext, new()
    {
        TContext _context;
        public EfEntityRepositoryBase(TContext context)
        {
            _context = context;
        }
        public void Add(T entity)
        {
                _context.Entry(entity).State = EntityState.Added;
                _context.SaveChanges();
            
        }

        public void Delete(T entity)
        {
           
                _context.Entry(entity).State = EntityState.Deleted;
                _context.SaveChanges();
          
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            
                return _context.Set<T>().SingleOrDefault(filter);
            
        }

        public List<T> GetAll(Expression<Func<T, bool>> filter = null)
        {
           
                return filter == null ? _context.Set<T>().ToList() : _context.Set<T>().Where(filter).ToList();
            
        }

        public void Update(T entity)
        {
           
                _context.Entry(entity).State = EntityState.Modified;
                _context.SaveChanges();
            
        }
    }
}
