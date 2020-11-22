using RestaurantManager.Database;
using RestaurantManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.Bussiness
{
    public class DONDATDABll
    {
        //lấy danh sách hóa đơn đặt
        public List<DONDATDA> GetLisDONDATDA()
        {
            try
            {
                using (var db = new RestaurantManagerDataEntities())
                {
                    var result = db.DONDATDAs.AsNoTracking().ToList();
                    return result;
                }
            }
            catch
            {
                return null;
            }
        }
        public string AddDONDATDA(DONDATDA_ViewModel model)
        {
            try
            {
                using (var db = new RestaurantManagerDataEntities())
                {
                    var check = db.DONDATDAs.FirstOrDefault(x => x.iddondat == model.iddondat);
                    if (check == null)
                    {
                        var DONDATDA = new DONDATDA
                        {
                            ngaydat = model.ngaydat,
                            ban = model.ban,
                            idkh = model.idkh,
                            CreateBy = model.CreateBy,
                            CreateDate = DateTime.Now,
                        };
                        var result = db.DONDATDAs.Add(DONDATDA);
                        db.SaveChanges();

                        foreach (D_DONDATDA_ViewModel item in model.D_DONDATDA)
                        {
                            var D_DONDATDA = new D_DONDATDA
                            {
                                iddondat = DONDATDA.iddondat,
                                idmon = item.idmon,
                                sldat = item.sldat,
                                CreateBy = model.CreateBy,
                                CreateDate = DateTime.Now,
                            };
                            db.D_DONDATDA.Add(D_DONDATDA);
                        }
                        db.SaveChanges();
                        return "Lưu đơn đặt đồ ăn thành công!";
                    }
                    else
                    {
                        check.ngaydat = model.ngaydat;
                        check.ban = model.ban;
                        check.idkh = model.idkh;
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
        public string DeleteDONDATDA(int id)
        {
            try
            {
                using (var db = new RestaurantManagerDataEntities())
                {
                    var check = db.DONDATDAs.FirstOrDefault(x => x.iddondat == id);
                    if (check == null)
                    {
                        return "Xóa không thành công!";
                    }
                    else
                    {
                        db.DONDATDAs.Remove(check);
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

        //lấy danh sách đơn chưa thanh toán
        public List<DONDATDA_ViewModel> GetOuterOrder()
        {
            try
            {
                using (var db = new RestaurantManagerDataEntities())
                {
                    //var result = (from d in db.DONDATDAs.AsNoTracking()
                    //              join k in db.KHACHHANGs.AsNoTracking() on d.idkh equals k.idkh
                    //              join h in db.HOADONTTs.AsNoTracking() on d.iddondat equals h.iddondat into gj
                    //              from subpet in gj.DefaultIfEmpty()
                    //              select new DONDATDA_ViewModel
                    //              {
                    //                  iddondat = d.iddondat,
                    //                  ban = d.ban,
                    //                  ngaydat = d.ngaydat,
                    //                  idkh = d.idkh,
                    //                  tenkh = k.tenkh,
                    //                  CreateBy = d.CreateBy,
                    //                  CreateDate = d.CreateDate
                    //              }
                    //             ).ToList();

                    var result = db.Database.SqlQuery<DONDATDA_ViewModel>("EXEC dbo.Proc_GetDonDatDA_OutLeft").ToList();
                    return result;
                }
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// lấy danh sách món ăn
        /// </summary>
        /// <param name="iddondat"></param>
        /// <returns></returns>
        public List<D_DONDATDA_ViewModel> GetListD_DONDATDA(int iddondat)
        {
            try
            {
                using (var db = new RestaurantManagerDataEntities())
                {
                    var result = (from d in db.D_DONDATDA.AsNoTracking()
                                  join m in db.MONANs.AsNoTracking() on d.idmon equals m.idmon
                                  where d.iddondat == iddondat
                                  select new D_DONDATDA_ViewModel
                                  {
                                      iddondat = d.iddondat,
                                      idmon = d.idmon,
                                      sldat = d.sldat,
                                      dongiamon = m.dongiamon.Value,
                                      tenmon = m.temon,
                                      TotalAmount = m.dongiamon.Value * d.sldat,
                                  }
                                  )
                        .ToList();
                    return result;
                }
            }
            catch
            {
                return null;
            }
        }
    }
}
