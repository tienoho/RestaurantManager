using RestaurantManager.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.Bussiness
{
    public class HOADONMBll
    {
        //lấy danh sách hóa đơn
        public List<HOADONM> GetLisHOADONM()
        {
            try
            {
                using (var db = new RestaurantManagerDataEntities())
                {
                    var result = db.HOADONMs.AsNoTracking().ToList();
                    return result;
                }
            }
            catch
            {
                return null;
            }
        }
        public string AddHOADONM(HOADONM model,List<D_HOADONM> details,string loginUser)
        {
            try
            {
                using (var db = new RestaurantManagerDataEntities())
                {
                    var check = db.HOADONMs.FirstOrDefault(x => x.idhoadonm == model.idhoadonm);
                    if (check == null)
                    {
                        var pnhap = db.PNHAPs.AsNoTracking().FirstOrDefault(x => x.idpnhap == model.idpnhap);
                        var pgiao = db.GIAOHANGs.AsNoTracking().FirstOrDefault(x => x.idpgiao == pnhap.idpgiao);
                        model.idhoadonm = pgiao.iddonmh.Value;
                        var result = db.HOADONMs.Add(model);
                        db.SaveChanges();

                        foreach (D_HOADONM item in details)
                        {
                            item.idhoadonm = result.idhoadonm;
                            db.D_HOADONM.Add(item);
                        }
                        db.SaveChanges();
                        return "Lưu hóa đơn mua thành công!";
                    }
                    return "Lưu hóa đơn mua không thành công!";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
