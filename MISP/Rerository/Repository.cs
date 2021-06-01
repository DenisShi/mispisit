using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MISP.Rerository
{
    public class Repository<T> : IRepository<T> where T : class, IDomainObject, new()
    {
        private Context _context;

        public Repository(Context context)
        {
            _context = context;
        }
        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>();
        }

        public void Create(T obj)
        {
            _context.Set<T>().Add(obj);
        }
        public void Save()
        {
            _context.SaveChanges();
        }

        public T Get(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public void Update(T item)
        {
            _context.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            _context.Set<T>().Remove(Get(id));
        }

        public void Dispose()
        {
            Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
