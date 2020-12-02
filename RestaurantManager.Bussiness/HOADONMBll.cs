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
    public class HOADONMBll
    {
        //lấy danh sách hóa đơn
        public List<HOADONM> GetLisHOADONM()
        {
            try
            {
                using (var db = new RestaurantManagerDataEntities())
                {
                    var result = db.HOADONMs.AsNoTracking().ToList();
                    return result;
                }
            }
            catch
            {
                return null;
            }
        }
        public List<HOADONM_ViewModel> GetListFullHOADONM(DateTime FromDate, DateTime ToDate)
        {
            try
            {
                using (var db = new RestaurantManagerDataEntities())
                {
                    var _FromDate = new SqlParameter("@FromDate", FromDate);
                    var _ToDate = new SqlParameter("@ToDate", ToDate);

                    var result = db.Database.SqlQuery<HOADONM_ViewModel>("EXEC dbo.Proc_GetListHOADONM @FromDate,@ToDate", _FromDate, _ToDate).ToList();
                    return result;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public HOADONM_ViewModel GetHOADONM(int idhoadonm)
        {
            try
            {
                using (var db = new RestaurantManagerDataEntities())
                {
                    var result = (from h in db.HOADONMs.AsNoTracking()
                                  join p in db.PNHAPs.AsNoTracking() on h.idpnhap equals p.idpnhap
                                  join g in db.GIAOHANGs.AsNoTracking() on p.idpgiao equals g.idpgiao
                                  join d in db.DONMHs.AsNoTracking() on g.iddonmh equals d.iddonmh
                                  join n in db.NCCs.AsNoTracking() on d.idncc equals n.idncc
                                  where h.idhoadonm == idhoadonm
                                  select new HOADONM_ViewModel
                                  {
                                      idhoadonm = h.idhoadonm,
                                      ngaymua = h.ngaymua,
                                      idpnhap = h.idpnhap,
                                      idpgiao = g.idpgiao,
                                      iddonmh = d.iddonmh,
                                      idncc = n.idncc,
                                      tenncc = n.tenncc
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
        public List<D_HOADONM_ViewModel> GetLisD_HOADONM(int idhoadonm)
        {
            try
            {
                using (var db = new RestaurantManagerDataEntities())
                {
                    var result = (from d in db.D_HOADONM.AsNoTracking()
                                  join n in db.NLIEUx.AsNoTracking() on d.idhang equals n.idhang
                                  where d.idhoadonm == idhoadonm
                                  select new D_HOADONM_ViewModel
                                  {
                                      idhoadonm = d.idhoadonm,
                                      idhang = d.idhang,
                                      dongiamua = d.dongiamua,
                                      slmua = d.slmua,
                                      tenhang = n.tenhang,
                                  }).ToList();
                    return result;
                }
            }
            catch
            {
                return null;
            }
        }
        public HOADONM AddHOADONM(HOADONM model, List<D_HOADONM> details, string loginUser)
        {
            try
            {
                using (var db = new RestaurantManagerDataEntities())
                {
                    var check = db.HOADONMs.FirstOrDefault(x => x.idhoadonm == model.idhoadonm);
                    if (check == null)
                    {
                        var pnhap = db.PNHAPs.AsNoTracking().FirstOrDefault(x => x.idpnhap == model.idpnhap);
                        var pgiao = db.GIAOHANGs.AsNoTracking().FirstOrDefault(x => x.idpgiao == pnhap.idpgiao);
                        model.idhoadonm = pgiao.iddonmh.Value;
                        model.CreateBy = loginUser;
                        model.CreateDate = DateTime.Now;
                        var result = db.HOADONMs.Add(model);
                        db.SaveChanges();

                        foreach (D_HOADONM item in details)
                        {
                            item.idhoadonm = result.idhoadonm;
                            item.CreateBy = loginUser;
                            item.CreateDate = DateTime.Now;
                            db.D_HOADONM.Add(item);
                        }
                        db.SaveChanges();
                        return result;
                    }
                    return null;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
