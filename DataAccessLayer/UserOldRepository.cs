using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class UserOldRepository:BaseRepository<UsersOld>
    {

        public UserOldRepository()
        {
            db = new myShopEntities();
        }

        public UsersOld Edit(UsersOld entity)
        {
            
           
            UsersOld result = db.UsersOld.Where(c => c.Id == entity.Id).FirstOrDefault();
            result.Password = entity.Password;
            result.UserName = entity.UserName;
            result.Bakiye = entity.Bakiye;
            result.FullName = entity.FullName;
            db.SaveChanges();
            return result;

        }
       
    }
}
