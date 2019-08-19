using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class ProductRepository:BaseRepository<Products>
    {
        public ProductRepository()
        {
            db = new myShopEntities();
        }
        
        public Products Edit(Products entity)
        {
           
            Products defaultPro = db.Products.Where(c => c.Id == entity.Id).FirstOrDefault();
            defaultPro.Name = entity.Name;
            defaultPro.stocks = entity.stocks;
            defaultPro.Price = entity.Price;
            defaultPro.productCode = entity.productCode;
            defaultPro.categoryId = entity.categoryId;
            db.SaveChanges();
            return defaultPro;
        }
    } 
}
