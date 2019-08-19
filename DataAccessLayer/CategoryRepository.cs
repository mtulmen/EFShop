using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class CategoryRepository:BaseRepository<Categories>
    {
        public CategoryRepository()
        {
            db = new myShopEntities();
        }
        
        public Categories Edit(Categories entity)
        {
            
            Categories defaulCategory = db.Categories.Where(c => c.Id == entity.Id).FirstOrDefault();
            defaulCategory.Description = entity.Description;
            defaulCategory.Name = entity.Name;
            defaulCategory.CatOrder = entity.CatOrder;
            
            db.SaveChanges();
            return defaulCategory;
        }

        
    }
}
