using RestaurantManager.Database;
using RestaurantManager.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.Bussiness
{
    public class DONMHBll
    {
        /// <summary>
        /// ds đơn mua
        /// </summary>
        /// <returns></returns>
        public List<DONMH_ViewModel> GetListDONMH()
        {
            using (var db = new RestaurantManagerDataEntities())
            {
                var result = (from p in db.DONMHs.AsNoTracking()
                              join d in db.NCCs.AsNoTracking() on p.idncc equals d.idncc
                              select new DONMH_ViewModel
                              {
                                  iddonmh = p.iddonmh,
                                  ngaydonmh = p.ngaydonmh.Value,
                                  idncc = p.idncc.Value,
                                  tenncc = d.tenncc,
                                  CreateBy = p.CreateBy,
                                  CreateDate = p.CreateDate
                              }).ToList();
                return result;
            }
        }
        public List<D_DONMH_ViewModel> GetListD_DONMH(int iddonmh)
        {
            using (var db = new RestaurantManagerDataEntities())
            {
                var result = (from d in db.D_DONMH.AsNoTracking()
                              join h in db.NLIEUx.AsNoTracking() on d.idhang equals h.idhang
                              where d.iddonmh == iddonmh
                              select new D_DONMH_ViewModel
                              {
                                  iddonmh = d.iddonmh,
                                  idhang = d.idhang,
                                  tenhang = h.tenhang,
                                  slmh = d.slmh.Value,
                                  dongiamh = d.dongiamh.Value,
                                  totalamount = d.slmh.Value * d.dongiamh.Value,
                                  CreateBy = d.CreateBy,
                                  CreateDate = d.CreateDate
                              })
                    .ToList();
                return result;
            }
        }
        public PYC AddPYC(PYC yC)
        {
            try
            {
                using (var db = new RestaurantManagerDataEntities())
                {
                    var check = db.PYCs.FirstOrDefault(x => x.idyc == yC.idyc);
                    if (check == null)
                    {
                        var PYC = new PYC
                        {
                            ngayyc = yC.ngayyc,
                            CreateDate = DateTime.Now,
                            CreateBy = yC.ModifyBy

                        };
                        check = db.PYCs.Add(PYC);
                        db.SaveChanges();
                        return check;
                    }
                    else
                    {
                        check.ngayyc = yC.ngayyc;
                        check.ModifyDate = DateTime.Now;
                        check.ModifyBy = yC.ModifyBy;
                        db.SaveChanges();
                        return check;
                    }


                }
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public string AddD_PYC(D_PYC model)
        {
            try
            {
                using (var db = new RestaurantManagerDataEntities())
                {
                    var check = db.D_PYC.FirstOrDefault(x => x.idyc == model.idyc && x.idhang == model.idhang);
                    if (check == null)
                    {
                        var D_PYC = new D_PYC
                        {
                            idyc = model.idyc,
                            idhang = model.idhang,
                            sldukien = model.sldukien,
                            slton = model.slton,
                            nguong = model.nguong,
                            CreateDate = DateTime.Now,
                            CreateBy = model.ModifyBy
                        };
                        check = db.D_PYC.Add(D_PYC);
                        db.SaveChanges();
                        return "success";
                    }
                    else
                    {
                        check.sldukien = model.sldukien;
                        check.slton = model.slton;
                        check.nguong = model.nguong;
                        check.ModifyDate = DateTime.Now;
                        check.ModifyBy = model.ModifyBy;
                        db.SaveChanges();
                        return "success";
                    }
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        /// <summary>
        /// lấy id mới đơn mua hàng
        /// </summary>
        /// <returns></returns>
        public string getNewIdDONMH()
        {
            try
            {
                using (var db = new RestaurantManagerDataEntities())
                {

                    var result = db.Database.SqlQuery<DONMH_ViewModel>("EXEC dbo.[Proc_GetNewIdDONMH]").FirstOrDefault();
                    return (result.iddonmh).ToString();
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string saveDONMH(DONMH_ViewModel donmh, List<D_DONMH_ViewModel> lstDdonmh, string nameLog)
        {
            try
            {
                using (var db = new RestaurantManagerDataEntities())
                {
                    //master
                    var check = db.DONMHs.FirstOrDefault(e => e.iddonmh == donmh.iddonmh);
                    if (check == null)
                    {
                        check = new DONMH();
                        check.CreateBy = nameLog;
                        check.CreateDate = DateTime.Now;
                        db.Entry(check).State = EntityState.Added;
                        db.DONMHs.Add(check);
                    }
                    else
                    {
                        check.ModifyBy = nameLog;
                        check.ModifyDate = DateTime.Now;
                        db.Entry(check).State = EntityState.Modified;
                    }
                    check.iddonmh = donmh.iddonmh;
                    check.ngaydonmh = donmh.ngaydonmh;
                    check.idncc = donmh.idncc;
                    db.SaveChanges();

                    //detail
                    var checkD = db.D_DONMH.Where(e => e.iddonmh == check.iddonmh).ToList();
                    if (checkD.Count() > 0)
                    {
                        db.D_DONMH.RemoveRange(checkD);
                    }
                    foreach (var item in lstDdonmh)
                    {
                        var detail = new D_DONMH
                        {
                            iddonmh = check.iddonmh,
                            idhang = item.idhang,
                            slmh = item.slmh,
                            dongiamh = int.Parse(item.dongiamh.ToString()), //đổi sang double
                            CreateBy = nameLog,
                            CreateDate = DateTime.Now,
                        };
                        db.D_DONMH.Add(detail);
                    }
                    db.SaveChanges();
                    return "success";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}