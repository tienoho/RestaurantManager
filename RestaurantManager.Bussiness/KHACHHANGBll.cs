using RestaurantManager.Database;
using RestaurantManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.Bussiness
{
    public class KHACHHANGBll
    {
        public List<KHACHHANG> GetListKHACHHANG()
        {
            try
            {
                using (var db = new RestaurantManagerDataEntities())
                {
                    var result = db.KHACHHANGs.AsNoTracking().OrderBy(x=>x.idkh).ToList();
                    return result;
                }
            }
            catch
            {
                return null;
            }
        }
        public string AddKHACHHANG(KHACHHANG_ViewModel model)
        {
            try
            {
                using (var db = new RestaurantManagerDataEntities())
                {
                    var check = db.KHACHHANGs.FirstOrDefault(x => x.idkh == model.idkh);
                    if (check == null)
                    {
                        var KHACHHANG = new KHACHHANG
                        {
                            tenkh = model.tenkh,
                            sdt = model.sdt,
                            CreateBy = model.CreateBy,
                            CreateDate = DateTime.Now,
                        };
                        var result = db.KHACHHANGs.Add(KHACHHANG);
                        db.SaveChanges();
                        return "Thêm khách hàng thành công!";
                    }
                    else
                    {
                        check.tenkh = model.tenkh;
                        check.sdt = model.sdt;
                        check.ModifyBy = model.ModifyBy;
                        check.ModifyDate = DateTime.Now;
                        db.SaveChanges();
                        return "Cập nhật khách hàng thành công!";
                    }
                }
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }
        public string DeleteKHACHHANG(int id)
        {
            try
            {
                using (var db = new RestaurantManagerDataEntities())
                {
                    var checkDanhMuc = db.KHACHHANGs.FirstOrDefault(x => x.idkh == id);
                    if (checkDanhMuc == null)
                    {
                        return "Xóa không thành công!";
                    }
                    else
                    {
                        db.KHACHHANGs.Remove(checkDanhMuc);
                        db.SaveChanges();
                        return "Xóa khách hàng thành công!";
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
