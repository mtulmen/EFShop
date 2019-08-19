using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public abstract class BaseRepository<T> where T:class,IBaseEntity
    {
        protected myShopEntities db;

        
        public virtual List<T> List()
        {
            db = new myShopEntities();
            List<T> result = db.Set<T>().ToList();
            
            return result;
        }

        public virtual void Add(T entity)
        {
            
            //T result = new T();

            db.Set<T>().Add(entity);
            db.SaveChanges();

            
        }

        public virtual void Delete(int id)
        {
            
            myShopEntities db = new myShopEntities();
            var entity = db.Set<T>().Where(c => c.Id == id).FirstOrDefault();
            db.Set<T>().Remove(entity);
            db.SaveChanges();
        }
    }
}
