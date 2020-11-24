using RestaurantManager.Database;
using RestaurantManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.Bussiness
{
    public class GIAOHANGBll
    {
        public List<GIAOHANG_ViewModel> GetListGIAOHANG()
        {
            try
            {
                using (var db = new RestaurantManagerDataEntities())
                {
                    var result = (from g in db.GIAOHANGs.AsNoTracking()
                                  join n in db.NCCs.AsNoTracking() on g.idncc equals n.idncc
                                  join m in db.DONMHs.AsNoTracking() on g.iddonmh equals m.iddonmh
                                  select new GIAOHANG_ViewModel {
                                      iddonmh=g.iddonmh,
                                      idncc = g.idncc,
                                      tenncc = n.tenncc,
                                      ngaygiao = g.ngaygiao,
                                      nguoigiao = g.nguoigiao,
                                      nguoilapphieu = g.nguoilapphieu,
                                      nguoinhan = g.nguoinhan,
                                      cuahang = g.cuahang,
                                      diachi = g.diachi,
                                  }).ToList();
                    return result;
                }
            }
            catch
            {
                return null;
            }
        }
        public string AddGIAOHANG(GIAOHANG_ViewModel model, List<D_GIAOHANG_ViewModel> lstD_GIAOHANG, string userLogin)
        {
            try
            {
                using (var db = new RestaurantManagerDataEntities())
                {
                    var check = db.GIAOHANGs.FirstOrDefault(x => x.idpgiao == model.idpgiao);
                    if (check == null)
                    {
                        var GIAOHANG = new GIAOHANG
                        {
                            iddonmh = model.iddonmh,
                            idncc = model.idncc,
                            diachi = model.diachi,
                            cuahang = model.cuahang,
                            ngaygiao = model.ngaygiao,
                            nguoigiao = model.nguoigiao,
                            nguoilapphieu = model.nguoilapphieu,
                            nguoinhan = model.nguoinhan,
                            CreateBy = userLogin,
                            CreateDate = DateTime.Now,
                        };
                        var result = db.GIAOHANGs.Add(GIAOHANG);
                        db.SaveChanges();

                        foreach (D_GIAOHANG_ViewModel item in lstD_GIAOHANG)
                        {
                            var D_GIAOHANG = new D_GIAOHANG
                            {
                                idpgiao = GIAOHANG.idpgiao,
                                idhang = item.idhang,
                                slgiaohang = item.slgiaohang,
                                slnhanhang = item.slnhanhang,
                                CreateBy = userLogin,
                                CreateDate = DateTime.Now,
                            };
                            db.D_GIAOHANG.Add(D_GIAOHANG);
                        }
                        db.SaveChanges();
                        return "success";
                    }
                    return "Tạo phiếu giao hàng không thành công!";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string DeleteGIAOHANG(int id)
        {
            try
            {
                using (var db = new RestaurantManagerDataEntities())
                {
                    var check = db.GIAOHANGs.FirstOrDefault(x => x.idpgiao == id);
                    if (check == null)
                    {
                        return "Xóa không thành công!";
                    }
                    else
                    {
                        db.GIAOHANGs.Remove(check);
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

        ///Details
        ///
        public List<D_GIAOHANG_ViewModel> GetListD_GIAOHANG(int idpgiao)
        {
            try
            {
                using (var db = new RestaurantManagerDataEntities())
                {
                    var result = (from d in db.D_GIAOHANG.AsNoTracking()
                                  join n in db.NLIEUx.AsNoTracking() on d.idhang equals n.idhang
                                  where d.idpgiao == idpgiao
                                  select new D_GIAOHANG_ViewModel
                                  {
                                      idpgiao = d.idpgiao,
                                      idhang = d.idhang,
                                      tenhang = n.tenhang,
                                      slgiaohang = d.slgiaohang,
                                      slnhanhang = d.slnhanhang,
                                  }).ToList();
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
