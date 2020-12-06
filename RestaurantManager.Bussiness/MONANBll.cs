using RestaurantManager.Database;
using RestaurantManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.Bussiness
{
   public class MONANBll
    {
        public List<MONAN_ViewModel> GetListMONAN()
        {
            try
            {
                using (var db = new RestaurantManagerDataEntities())
                {
                    var result = (from m in db.MONANs.AsNoTracking()
                                  join d in db.DANHMUCs.AsNoTracking() on m.iddmuc equals d.iddmuc
                                  select new MONAN_ViewModel
                                  {
                                      idmon=m.idmon,
                                      temon = m.temon,
                                      dongiamon = m.dongiamon,
                                      dvt = m.dvt,
                                      hinhanh = m.hinhanh,
                                      iddmuc = m.iddmuc,
                                      tendmuc = d.tendmuc,
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
        /// <summary>
        /// Get danh sachs mon an co cong thuc
        /// </summary>
        /// <returns></returns>
        public List<MONAN_ViewModel> GetListMONAN_OutLeft()
        {
            try
            {
                using (var db = new RestaurantManagerDataEntities())
                {
                    var result = db.Database.SqlQuery<MONAN_ViewModel>("EXEC dbo.Proc_GetMONAN_OutLeft").ToList();
                    return result;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public string AddMONAN(MONAN_ViewModel model)
        {
            try
            {
                using (var db = new RestaurantManagerDataEntities())
                {
                    var check = db.MONANs.FirstOrDefault(x => x.idmon == model.idmon);
                    if (check == null)
                    {
                        var MONAN = new MONAN
                        {
                            temon = model.temon,
                            dongiamon = model.dongiamon,
                            dvt = model.dvt,
                            hinhanh = model.hinhanh,
                            iddmuc = model.iddmuc,
                            CreateBy = model.CreateBy,
                            CreateDate = DateTime.Now,
                        };
                        var result = db.MONANs.Add(MONAN);
                        db.SaveChanges();
                        return "Thêm món ăn thành công!";
                    }
                    else
                    {
                        check.temon = model.temon;
                        check.dongiamon = model.dongiamon;
                        check.dvt = model.dvt;
                        check.hinhanh = model.hinhanh;
                        check.iddmuc = model.iddmuc;
                        check.ModifyBy = model.ModifyBy;
                        check.ModifyDate = DateTime.Now;
                        db.SaveChanges();
                        return "Cập nhật món ăn thành công!";
                    }
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string DeleteMONAN(int id)
        {
            try
            {
                using (var db = new RestaurantManagerDataEntities())
                {
                    var check = db.MONANs.FirstOrDefault(x => x.idmon == id);
                    if (check == null)
                    {
                        return "Xóa không thành công!";
                    }
                    else
                    {
                        db.MONANs.Remove(check);
                        db.SaveChanges();
                        return "Xóa món ăn thành công!";
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
