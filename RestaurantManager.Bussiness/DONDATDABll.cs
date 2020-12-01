using RestaurantManager.Database;
using RestaurantManager.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
                    var result = db.Database.SqlQuery<DONDATDA_ViewModel>("EXEC dbo.Proc_GetDonDatDA_OutLeft").ToList();
                    return result;
                }
            }
            catch
            {
                return null;
            }
        }
        public DONDATDA_ViewModel GetDONDATDA(int iddondat)
        {
            try
            {
                using (var db = new RestaurantManagerDataEntities())
                {
                    var result = (from d in db.DONDATDAs.AsNoTracking()
                                  join m in db.KHACHHANGs.AsNoTracking() on d.idkh equals m.idkh
                                  where d.iddondat == iddondat
                                  select new DONDATDA_ViewModel
                                  {
                                      iddondat = d.iddondat,
                                      idkh = d.idkh,
                                      tenkh = m.tenkh,
                                      ban = d.ban,
                                      ngaydat = d.ngaydat,
                                      sdt = m.sdt
                                  }
                                  )
                        .FirstOrDefault();
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
                                      dvt = m.dvt,
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
        public List<DONDATDA_ViewModel> GetListDONDATDA(int iddondat, DateTime FromDate, DateTime ToDate)
        {
            try
            {
                using (var db = new RestaurantManagerDataEntities())
                {
                    var _iddondat = new SqlParameter("@iddondat", iddondat);
                    var _FromDate = new SqlParameter("@FromDate", FromDate);
                    var _ToDate = new SqlParameter("@ToDate", ToDate);

                    var result = db.Database.SqlQuery<DONDATDA_ViewModel>("EXEC dbo.Proc_GetListDONDATDA @iddondat,@FromDate,@ToDate", _iddondat, _FromDate, _ToDate).ToList();
                    return result;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
