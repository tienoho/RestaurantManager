using RestaurantManager.Database;
using RestaurantManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.Bussiness
{
    public class NLIEUBll
    {
        public List<NLIEU> GetListNLIEU()
        {
            try
            {
                using (var db = new RestaurantManagerDataEntities())
                {
                    var result = db.NLIEUx.AsNoTracking().OrderBy(x => x.idhang).ToList();
                    return result;
                }
            }
            catch
            {
                return null;
            }
        }
        public string AddNLIEU(NLIEU_ViewModel model)
        {
            try
            {
                using (var db = new RestaurantManagerDataEntities())
                {
                    var checkNLieu = db.NLIEUx.FirstOrDefault(x => x.idhang == model.idhang);
                    if (checkNLieu == null)
                    {
                        var NLieu = new NLIEU
                        {
                            tenhang = model.tenhang,
                            slton = model.slton,
                            nguong = model.nguong,
                            dongianl = model.dongianl,
                            CreateBy = model.CreateBy,
                            CreateDate = DateTime.Now,
                        };
                        var result = db.NLIEUx.Add(NLieu);
                        db.SaveChanges();
                        return "Thêm nguyên liệu thành công!";
                    }
                    else
                    {
                        checkNLieu.tenhang = model.tenhang;
                        checkNLieu.slton = model.slton;
                        checkNLieu.nguong = model.nguong;
                        checkNLieu.dongianl = model.dongianl;
                        checkNLieu.ModifyBy = model.ModifyBy;
                        checkNLieu.ModifyDate = DateTime.Now;
                        db.SaveChanges();
                        return "Cập nhật nguyên liệu thành công!";
                    }
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string DeleteNLIEU(int id)
        {
            try
            {
                using (var db = new RestaurantManagerDataEntities())
                {
                    var check = db.NLIEUx.FirstOrDefault(x => x.idhang == id);
                    if (check == null)
                    {
                        return "Xóa không thành công!";
                    }
                    else
                    {
                        db.NLIEUx.Remove(check);
                        db.SaveChanges();
                        return "Xóa danh mục món ăn thành công!";
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
