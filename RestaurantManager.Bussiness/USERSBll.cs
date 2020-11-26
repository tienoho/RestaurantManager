using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantManager.Database;
using RestaurantManager.Model;

namespace RestaurantManager.Bussiness
{
    public class USERSBll
    {
        public USER Login(string username, string password)
        {
            try
            {
                using (var db = new RestaurantManagerDataEntities())
                {
                    var result = db.USERS.AsNoTracking().FirstOrDefault(x => x.UserName == username && x.Password == password);
                    if (result == null)
                    {
                        return null;
                    }
                    return result;
                }
            }
            catch
            {
                return null;
            }
        }


        public List<USER> GetUsersByPosition(string position, string loginCode,ref string outmess)
        {
            try
            {
                using (var db = new RestaurantManagerDataEntities())
                {
                    var lst = db.USERS.AsNoTracking().Where(e => e.ChucVu == position).ToList();
                    outmess = "success";
                    return lst;
                }
            }
            catch (Exception ex)
            {
                outmess = ex.Message;
                return null;
            }
        }

    }
}
