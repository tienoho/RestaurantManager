using RestaurantManager.Database;
using RestaurantManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace RestaurantManager.Bussiness
{
    public class HOADONTTBll
    {
        //lấy danh sách hóa đơn đặt
        public List<HOADONTT> GetLisHOADONTT()
        {
            try
            {
                using (var db = new RestaurantManagerDataEntities())
                {
                    var result = db.HOADONTTs.AsNoTracking().ToList();
                    return result;
                }
            }
            catch
            {
                return null;
            }
        }
        public string AddHOADONTT(HOADONTT_ViewModel model)
        {
            try
            {
                using (var db = new RestaurantManagerDataEntities())
                {
                    var check = db.HOADONTTs.FirstOrDefault(x => x.idhoadontt == model.idhoadontt);
                    if (check == null)
                    {
                        var HOADONTT = new HOADONTT
                        {
                            iddondat = model.iddondat,
                            ngayhd = model.ngayhd,
                            thoigian = DateTime.Now,
                            thungan = model.CreateBy,
                            idkh = model.idkh,
                            CreateBy = model.CreateBy,
                            CreateDate = DateTime.Now,
                        };
                        var result = db.HOADONTTs.Add(HOADONTT);
                        db.SaveChanges();

                        foreach (D_HOADONTT_ViewModel item in model.D_HOADONTT)
                        {
                            var D_HOADONTT = new D_HOADONTT
                            {
                                idhoadontt = HOADONTT.idhoadontt,
                                idmon = item.idmon,
                                slban = item.slban,
                                dongiaban = item.dongiaban,
                                CreateBy = model.CreateBy,
                                CreateDate = DateTime.Now,
                            };
                            db.D_HOADONTT.Add(D_HOADONTT);
                        }
                        db.SaveChanges();
                        return "Thanh toán thành công!";
                    }
                    //else
                    //{
                    //    check.ngaydat = model.ngaydat;
                    //    check.ban = model.ban;
                    //    check.idkh = model.idkh;
                    //    check.ModifyBy = model.ModifyBy;
                    //    check.ModifyDate = DateTime.Now;
                    //    db.SaveChanges();
                    //    return "Cập nhật món ăn thành công!";
                    //}
                    return "Thanh toán không thành công!";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string DeleteHOADONTT(int id)
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
        public List<HOADONTT_ViewModel> GetListHOADONTT(int idkh,DateTime FromDate, DateTime ToDate)
        {
            try
            {
                using (var db = new RestaurantManagerDataEntities())
                {
                    var _idkh = new SqlParameter("@idkh", idkh);
                    var _FromDate = new SqlParameter("@FromDate", FromDate);
                    var _ToDate = new SqlParameter("@ToDate", ToDate);

                    var result = db.Database.SqlQuery<HOADONTT_ViewModel>("EXEC dbo.Proc_GetListHOADONTT @idkh,@FromDate,@ToDate", _idkh,_FromDate,_ToDate).ToList();
                    return result;
                }
            }
            catch(Exception ex)
            {
                return null;
            }
        }
    }
}
