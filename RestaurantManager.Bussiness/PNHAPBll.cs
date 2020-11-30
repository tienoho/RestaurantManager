using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantManager.Database;
using RestaurantManager.Model;

namespace RestaurantManager.Bussiness
{
    public class PNHAPBll
    {
        //public List<>

        public List<D_GIAOHANG_ViewModel> GetLstDonGiao(int id, ref string outmess)
        {
            try
            {
                using (var db = new RestaurantManagerDataEntities())
                {
                    var result = (from d in db.D_GIAOHANG.AsNoTracking()
                                  join h in db.NLIEUx.AsNoTracking() on d.idhang equals h.idhang
                                  where d.idpgiao == id
                                  select new D_GIAOHANG_ViewModel
                                  {
                                      idpgiao = d.idpgiao,
                                      idhang = d.idhang,
                                      tenhang = h.tenhang,
                                      slgiaohang = d.slgiaohang.Value,
                                      slnhanhang = d.slnhanhang.Value,
                                      CreateBy = d.CreateBy,
                                      CreateDate = d.CreateDate
                                  })
                   .ToList();
                    return result;
                }
            }
            catch (Exception ex)
            {
                outmess = ex.Message;
                return null;
            }
        }

        public object DeletePNHAP(int idpnhap)
        {
            using (var db = new RestaurantManagerDataEntities())
            {
                using (var trans = db.Database.BeginTransaction())
                {
                    try
                    {
                        //validate với bảng khác
                        var master = db.PNHAPs.FirstOrDefault(e => e.idpnhap == idpnhap);
                        //find detail
                        var details = db.D_PNHAP.Where(e => e.idpnhap == master.idpnhap).ToList();
                        db.D_PNHAP.RemoveRange(details);
                        db.PNHAPs.Remove(master);
                        trans.Commit();
                        return "success";
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        return ex.Message;
                    }
                }
            }
        }

        /// <summary>
        /// ds phiếu nhập
        /// </summary>
        /// <returns></returns>
        public List<PNHAP> GetListPNHAP()
        {
            using (var db = new RestaurantManagerDataEntities())
            {
                return db.PNHAPs.AsNoTracking().ToList();
            }
        }

        /// <summary>
        /// ds phiếu nhập full
        /// </summary>
        /// <returns></returns>
        public List<PNHAP_ViewModel> GetListPNHAPFull()
        {
            using (var db = new RestaurantManagerDataEntities())
            {
                var result = (from p in db.PNHAPs.AsNoTracking()
                              join u in db.USERS.AsNoTracking() on p.nguoilapphieu equals u.UserName
                              join uu in db.USERS.AsNoTracking() on p.thukho equals uu.UserName
                              //join g in db.GIAOHANGs.AsNoTracking() on p.idpgiao equals g.idpgiao
                              //join m in db.DONMHs.AsNoTracking() on g.iddonmh equals m.iddonmh
                              select new PNHAP_ViewModel
                              {
                                  idpnhap = p.idpnhap,
                                  idpgiao = p.idpgiao,
                                  ngaynhap = p.ngaynhap,
                                  nguoigiao = p.nguoigiao,
                                  nguoilapphieu = p.nguoilapphieu,
                                  //tennguoilapphieu=u.ten,
                                  thukho = p.thukho,
                                  //tenthukho=uu.ten,
                              }
                            ).ToList();
                return result;
            }
        }

        /// <summary>
        /// ds chi tiết phiếu nhập
        /// </summary>
        /// <returns></returns>
        public List<D_PNHAP_ViewModel> GetListD_PNHAP_Full(int idpnhap)
        {
            //using (var db = new RestaurantManagerDataEntities())
            //{
            //var result = (from p in db.D_PNHAP.AsNoTracking()
            //              join n in db.NLIEUx.AsNoTracking() on p.idhang equals n.idhang
            //              select new D_PNHAP_ViewModel
            //              {
            //                  idpnhap = p.idpnhap,
            //                  idhang = p.idhang,
            //                  tenhang = n.tenhang,
            //                  slgiao = p.slgiao,
            //                  slnhan = p.slnhan,
            //              }).ToList();

            try
            {
                using (var db = new RestaurantManagerDataEntities())
                {
                    var _idpnhap = new SqlParameter("@idpnhap", idpnhap);

                    var result = db.Database.SqlQuery<D_PNHAP_ViewModel>("EXEC dbo.Proc_GetListD_PNHAP @idpnhap", _idpnhap).ToList();
                    return result;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
            //    return result;
            //}
        }
        /// <summary>
        /// ds chi tiết phiếu nhập
        /// </summary>
        /// <returns></returns>
        public List<D_PNHAP_ViewModel> GetListDNHAP(int idpnhap)
        {
            using (var db = new RestaurantManagerDataEntities())
            {
                var result = (from d in db.D_PNHAP.AsNoTracking()
                              join n in db.NLIEUx.AsNoTracking() on d.idhang equals n.idhang
                              where d.idpnhap == idpnhap
                              select new D_PNHAP_ViewModel
                              {
                                  idpnhap = d.idpnhap,
                                  idhang = n.idhang,
                                  slgiao = d.slgiao,
                                  slnhan = d.slnhan,
                                  tenhang = n.tenhang,
                                  CreateDate = d.CreateDate,
                                  CreateBy = d.CreateBy
                              }
                            ).ToList();
                return result;
            }
        }

        public string savePNHAP(PNHAP_ViewModel model, List<D_PNHAP_ViewModel> lstDetail, string nameLog)
        {
            using (var db = new RestaurantManagerDataEntities())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {

                        //master
                        var check = db.PNHAPs.FirstOrDefault(e => e.idpnhap == model.idpnhap);
                        if (check == null)
                        {
                            check = new PNHAP();
                            check.CreateBy = nameLog;
                            check.CreateDate = DateTime.Now;
                            db.PNHAPs.Add(check);
                        }
                        else
                        {
                            check.ModifyBy = nameLog;
                            check.ModifyDate = DateTime.Now;
                            db.Entry(check).State = EntityState.Modified;
                        }
                        check.thukho = model.thukho;
                        check.ngaynhap = model.ngaynhap;
                        check.idpgiao = model.idpgiao;
                        check.nguoigiao = model.nguoigiao;
                        check.nguoilapphieu = nameLog;
                        db.SaveChanges();

                        //detail
                        var details = db.D_PNHAP.Where(p => p.idpnhap == check.idpnhap).ToList();
                        if (details.Count() > 0)
                        {
                            db.D_PNHAP.RemoveRange(details);
                        }
                        db.SaveChanges();
                        foreach (var item in lstDetail)
                        {
                            var detail = new D_PNHAP
                            {
                                idpnhap = check.idpnhap,
                                idhang = item.idhang,
                                slgiao = item.slgiao,
                                slnhan = item.slnhan,
                                CreateBy = nameLog,
                                CreateDate = DateTime.Now,
                            };
                            db.D_PNHAP.Add(detail);
                        }
                        db.SaveChanges();
                        transaction.Commit();
                        return "success";
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        return ex.Message;
                    }
                }
            }
        }
    }
}
