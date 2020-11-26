using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantManager.Database;
using RestaurantManager.Model;

namespace RestaurantManager.Bussiness
{
    public class PNHAPBll
    {
        //public List<>

        public List<D_GIAOHANG_ViewModel> GetLstDonGiao(int id,ref string outmess)
        {
            try
            {
                using (var db = new RestaurantManagerDataEntities())
                {
                    var result = (from d in db.D_GIAOHANG.AsNoTracking()
                                  join h in db.NLIEUx.AsNoTracking() on d.idhang equals h.idhang
                                  where d.idpgiao == id
                                  select new D_GIAOHANG_ViewModel
                                  {
                                      idpgiao = d.idpgiao,
                                      idhang = d.idhang,
                                      tenhang = h.tenhang,
                                      slgiaohang = d.slgiaohang.Value,
                                      slnhanhang = d.slnhanhang.Value,
                                      CreateBy = d.CreateBy,
                                      CreateDate = d.CreateDate
                                  })
                   .ToList();
                    return result;
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
