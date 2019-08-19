using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class UserRepository:BaseRepository<Users>
    {

        public UserRepository()
        {
            db = new myShopEntities();
        }
        

        public Users Update(Users entity)
        {
            
            Users defaultUsers = db.Users.Where(c => c.Id == entity.Id).FirstOrDefault();
            defaultUsers.Password = entity.Password;
            defaultUsers.UserName = entity.UserName;
            defaultUsers.Credit = entity.Credit;
            defaultUsers.FullName = entity.FullName;
            db.SaveChanges();
            return defaultUsers;
        }

        
    }
}
