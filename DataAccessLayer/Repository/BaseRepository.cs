using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class BaseRepository<T> : IBaseDal<T> where T : class
    {
        public void Add(T entity)
        {
            using var c = new Context();
            c.Add(entity);
        }

        public void Delete(T entity)
        {
            using var c = new Context();
            c.Remove(entity);
            c.SaveChanges();
        }

        public List<T> GetAll()
        {
            using var c = new Context();
            return c.Set<T>().ToList();
        }

        public void Update(T entity)
        {
            using var c = new Context();
            c.Update(entity);
        }
    }
}
