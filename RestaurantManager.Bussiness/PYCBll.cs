using RestaurantManager.Database;
using RestaurantManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.Bussiness
{
    public class PYCBll
    {
        public List<PYC_ViewModel> GetListPYC()
        {
            using (var db = new RestaurantManagerDataEntities())
            {
                var result = db.PYCs.AsNoTracking()
                    .Select(p => new PYC_ViewModel
                    {
                        idyc = p.idyc,
                        ngayyc = p.ngayyc,
                        CreateBy = p.CreateBy,
                        CreateDate = p.CreateDate
                    })
                    .ToList();
                return result;
            }
        }
        public List<D_PYC_ViewModel> GetListD_PYC(int idyc)
        {
            using (var db = new RestaurantManagerDataEntities())
            {
                var result = (from d in db.D_PYC.AsNoTracking()
                              join h in db.NLIEUx.AsNoTracking() on d.idhang equals h.idhang
                              where d.idyc == idyc
                              select new D_PYC_ViewModel
                              {
                                  idyc = d.idyc,
                                  idhang = d.idhang,
                                  tenhang = h.tenhang,
                                  sldukien = d.sldukien,
                                  nguong = d.nguong,
                                  slton = d.slton,
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
        public string SavePYC(PYC obj, List<D_PYC_ViewModel> details, string loginUser)
        {
            try
            {
                using (var db = new RestaurantManagerDataEntities())
                {
                    var check = db.PYCs.FirstOrDefault(x => x.idyc == obj.idyc);
                    if (check == null)
                    {
                        var PYC = new PYC
                        {
                            ngayyc = obj.ngayyc,
                            CreateDate = DateTime.Now,
                            CreateBy = loginUser

                        };
                        check = db.PYCs.Add(PYC);
                        db.SaveChanges();

                        foreach (D_PYC_ViewModel item in details)
                        {
                            var d_pyc = new D_PYC
                            {
                                idyc = check.idyc,
                                idhang = item.idhang,
                                sldukien = item.sldukien,
                                slton = item.slton,
                                nguong = item.nguong,
                                CreateBy = loginUser,
                                CreateDate = DateTime.Now,
                            };

                            db.D_PYC.Add(d_pyc);
                        }
                        db.SaveChanges();
                        return "success";
                    }
                    else
                    {
                        check.ngayyc = obj.ngayyc;
                        check.ModifyDate = DateTime.Now;
                        check.ModifyBy = loginUser;
                        db.SaveChanges();

                        db.D_PYC.RemoveRange(db.D_PYC.Where(x => x.idyc == obj.idyc));
                        db.SaveChanges();
                        foreach (D_PYC_ViewModel item in details)
                        {
                            var d_pyc = new D_PYC
                            {
                                idyc = check.idyc,
                                idhang = item.idhang,
                                sldukien = item.sldukien,
                                slton = item.slton,
                                nguong = item.nguong,
                                CreateBy = loginUser,
                                CreateDate = DateTime.Now,
                            };

                            db.D_PYC.Add(d_pyc);
                        }
                        db.SaveChanges();
                        return "success";
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        #region D_PYC
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
        public string DeleteD_PYC(int idyc, int idhang)
        {
            try
            {
                using (var db = new RestaurantManagerDataEntities())
                {
                    var check = db.D_PYC.FirstOrDefault(x => x.idyc == idyc && x.idhang == idhang);
                    if (check == null)
                    {
                        return "Xóa không thành công!";
                    }
                    else
                    {
                        db.D_PYC.Remove(check);
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
        #endregion
    }
}
