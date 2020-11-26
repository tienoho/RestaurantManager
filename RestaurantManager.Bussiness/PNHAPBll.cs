﻿using System;
using System.Collections.Generic;
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
        /// ds chi tiết phiếu nhập
        /// </summary>
        /// <returns></returns>
        public List<D_PNHAP> GetListDNHAP(int idpnhap)
        {
            using (var db = new RestaurantManagerDataEntities())
            {
                return db.D_PNHAP.AsNoTracking().Where(e => e.idpnhap == idpnhap).ToList();
            }
        }
    }
}
