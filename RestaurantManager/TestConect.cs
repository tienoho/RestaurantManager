using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager
{
    public class TestConect
    {
        public void test()
        {
            using(var db=new RestaurantManager.Database.RestaurantManagerDataEntities())
            {
                //db.SaveChanges();
            }
        }
    }
}
