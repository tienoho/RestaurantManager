﻿using RestaurantManager.Database;
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
        public HOADONTT_ViewModel GetHOADONTT(int id)
        {
            try
            {
                using (var db = new RestaurantManagerDataEntities())
                {
                    var result = (from h in db.HOADONTTs.AsNoTracking()
                                  join k in db.KHACHHANGs.AsNoTracking() on h.idkh equals k.idkh
                                  into ps
                                  from k in ps.DefaultIfEmpty()
                                  join d in db.DONDATDAs.AsNoTracking() on h.iddondat equals d.iddondat
                                  where h.idhoadontt == id
                                  select new HOADONTT_ViewModel
                                  {
                                      idhoadontt = h.idhoadontt,
                                      iddondat = d.iddondat,
                                      ban = d.ban,
                                      idkh = k.idkh,
                                      tenkh = k.tenkh,
                                      sdt = k.sdt,
                                      ngayhd = h.ngayhd,
                                      thoigian = h.thoigian,
                                      thungan = h.thungan
                                  }
                                  ).FirstOrDefault();
                    return result;
                }
            }
            catch
            {
                return null;
            }
        }
        public List<D_HOADONTT_ViewModel> GetListD_HOADONTT(int idhoadontt)
        {
            try
            {
                using (var db = new RestaurantManagerDataEntities())
                {
                    var result = (from d in db.D_HOADONTT.AsNoTracking()
                                  join m in db.MONANs.AsNoTracking() on d.idmon equals m.idmon
                                  where d.idhoadontt == idhoadontt
                                  select new D_HOADONTT_ViewModel
                                  {
                                      idhoadontt = d.idhoadontt,
                                      idmon = d.idmon,
                                      slban = d.slban,
                                      dvt = m.dvt,
                                      dongiaban = d.dongiaban,
                                      tenmon = m.temon,
                                      TotalAmount = d.dongiaban * d.slban,
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
        public HOADONTT AddHOADONTT(HOADONTT_ViewModel model)
        {

            using (var db = new RestaurantManagerDataEntities())
            {
                using (var trans = db.Database.BeginTransaction())
                {
                    try
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
                            trans.Commit();
                            return result;
                        }
                    }
                    catch
                    {
                        trans.Rollback();
                        return null;
                    }
                    return null;
                }
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
        public List<HOADONTT_ViewModel> GetListHOADONTT(int idkh, DateTime FromDate, DateTime ToDate)
        {
            try
            {
                using (var db = new RestaurantManagerDataEntities())
                {
                    var _idkh = new SqlParameter("@idkh", idkh);
                    var _FromDate = new SqlParameter("@FromDate", FromDate);
                    var _ToDate = new SqlParameter("@ToDate", ToDate);

                    var result = db.Database.SqlQuery<HOADONTT_ViewModel>("EXEC dbo.Proc_GetListHOADONTT @idkh,@FromDate,@ToDate", _idkh, _FromDate, _ToDate).ToList();
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
