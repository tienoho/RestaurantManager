using RestaurantManager.Database;
using RestaurantManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.Bussiness
{
    public class CONGTHUCBll
    {
        public List<CONGTHUC_ViewModel> GetListCONGTHUC(int idmon)
        {
            try
            {
                using (var db = new RestaurantManagerDataEntities())
                {
                    var result = (from m in db.MONANs.AsNoTracking()
                                  join d in db.CONGTHUCs.AsNoTracking() on m.idmon equals d.idmon
                                  join n in db.NLIEUx.AsNoTracking() on d.idhang equals n.idhang
                                  where m.idmon == idmon
                                  select new CONGTHUC_ViewModel
                                  {
                                      idmon = m.idmon,
                                      temon = m.temon,
                                      idhang = n.idhang,
                                      tenhang = n.tenhang,
                                      hamluong = d.hamluong,
                                      CreateBy = m.CreateBy,
                                      CreateDate = m.CreateDate,
                                  }
                                  ).ToList();
                    return result;
                }
            }
            catch
            {
                return null;
            }
        }
        public string AddCONGTHUC(CONGTHUC_ViewModel model)
        {
            try
            {
                using (var db = new RestaurantManagerDataEntities())
                {
                    var check = db.CONGTHUCs.FirstOrDefault(x => x.idmon == model.idmon&& x.idhang == model.idhang);
                    if (check == null)
                    {
                        var CONGTHUC = new CONGTHUC
                        {
                            idmon = model.idmon,
                            idhang = model.idhang,
                            hamluong = model.hamluong,
                            CreateBy = model.CreateBy,
                            CreateDate = DateTime.Now,
                        };
                        var result = db.CONGTHUCs.Add(CONGTHUC);
                        db.SaveChanges();
                        return "Thêm thành công!";
                    }
                    else
                    {
                        check.hamluong = model.hamluong;
                        check.ModifyBy = model.ModifyBy;
                        check.ModifyDate = DateTime.Now;
                        db.SaveChanges();
                        return "Cập nhật thành công!";
                    }
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string DeleteCONGTHUC(int idmon, int idhang)
        {
            try
            {
                using (var db = new RestaurantManagerDataEntities())
                {
                    var check = db.CONGTHUCs.FirstOrDefault(x => x.idmon == idmon && x.idhang == idhang);
                    if (check == null)
                    {
                        return "Xóa không thành công!";
                    }
                    else
                    {
                        db.CONGTHUCs.Remove(check);
                        db.SaveChanges();
                        return "Xóa thành công!";
                    }
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
