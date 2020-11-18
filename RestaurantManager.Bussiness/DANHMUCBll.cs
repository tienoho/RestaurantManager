using RestaurantManager.Database;
using RestaurantManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.Bussiness
{
    public class DANHMUCBll
    {
        public List<DANHMUC> GetListDANHMUC()
        {
            try
            {
                using (var db = new RestaurantManagerDataEntities())
                {
                    var result = db.DANHMUCs.AsNoTracking().OrderBy(x=>x.iddmuc).ToList();
                    return result;
                }
            }
            catch
            {
                return null;
            }
        }
        public string AddDANHMUC(DANHMUC_ViewModel model)
        {
            try
            {
                using (var db = new RestaurantManagerDataEntities())
                {
                    var checkDanhMuc = db.DANHMUCs.FirstOrDefault(x => x.iddmuc == model.iddmuc);
                    if (checkDanhMuc == null)
                    {
                        var danhMuc = new DANHMUC
                        {
                            tendmuc = model.tendmuc,
                            CreateBy = model.CreateBy,
                            CreateDate = DateTime.Now,
                        };
                        var result = db.DANHMUCs.Add(danhMuc);
                        db.SaveChanges();
                        return "Thêm danh mục món ăn thành công!";
                    }
                    else
                    {
                        checkDanhMuc.tendmuc = model.tendmuc;
                        checkDanhMuc.ModifyBy = model.ModifyBy;
                        checkDanhMuc.ModifyDate = DateTime.Now;
                        db.SaveChanges();
                        return "Cập nhật danh mục món ăn thành công!";
                    }
                }
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }
        public string DeleteDANHMUC(int id)
        {
            try
            {
                using (var db = new RestaurantManagerDataEntities())
                {
                    var checkDanhMuc = db.DANHMUCs.FirstOrDefault(x => x.iddmuc == id);
                    if (checkDanhMuc == null)
                    {
                        return "Xóa không thành công!";
                    }
                    else
                    {
                        db.DANHMUCs.Remove(checkDanhMuc);
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
