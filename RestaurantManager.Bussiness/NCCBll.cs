using RestaurantManager.Database;
using RestaurantManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.Bussiness
{
    public class NCCBll
    {
        public List<NCC_ViewModel> GetListNCC()
        {
            try
            {
                using (var db = new RestaurantManagerDataEntities())
                {
                    var result = (from m in db.NCCs.AsNoTracking()
                                  select new NCC_ViewModel
                                  {
                                      idncc = m.idncc,
                                      tenncc = m.tenncc,
                                      diachi = m.diachi,
                                      sdt = m.sdt,
                                      stk = m.stk,
                                      CreateDate = m.CreateDate,
                                      CreateBy = m.CreateBy,
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
        public string AddNCC(NCC_ViewModel model)
        {
            try
            {
                using (var db = new RestaurantManagerDataEntities())
                {
                    var check = db.NCCs.FirstOrDefault(x => x.idncc == model.idncc);
                    if (check == null)
                    {
                        var NCC = new NCC
                        {
                            idncc = model.idncc,
                            tenncc = model.tenncc,
                            diachi = model.diachi,
                            sdt = model.sdt,
                            stk = model.stk,
                            CreateBy = model.CreateBy,
                            CreateDate = DateTime.Now,
                        };
                        var result = db.NCCs.Add(NCC);
                        db.SaveChanges();
                        return "Thêm nhà cung cấp thành công!";
                    }
                    else
                    {
                        check.tenncc = model.tenncc;
                        check.diachi = model.diachi;
                        check.sdt = model.sdt;
                        check.stk = model.stk;
                        check.ModifyBy = model.ModifyBy;
                        check.ModifyDate = DateTime.Now;
                        db.SaveChanges();
                        return "Cập nhật nhà cung cấp thành công!";
                    }
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string DeleteNCC(int id)
        {
            try
            {
                using (var db = new RestaurantManagerDataEntities())
                {
                    var check = db.NCCs.FirstOrDefault(x => x.idncc == id);
                    if (check == null)
                    {
                        return "Xóa không thành công!";
                    }
                    else
                    {
                        db.NCCs.Remove(check);
                        db.SaveChanges();
                        return "Xóa nhà cung cấp thành công!";
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
