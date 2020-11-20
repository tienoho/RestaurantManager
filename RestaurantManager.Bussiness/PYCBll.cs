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
        public PYC AddPYX(PYC yC)
        {
            try
            {
                using (var db = new RestaurantManagerDataEntities())
                {
                    var check = db.PYCs.FirstOrDefault(x => x.idyc == yC.idyc);
                    if (check == null)
                    {
                        check.ngayyc = yC.ngayyc;
                        check.CreateDate = DateTime.Now;
                        check.CreateBy = yC.ModifyBy;
                        db.PYCs.Add(check);
                    }
                    else
                    {
                        check.ngayyc = yC.ngayyc;
                        check.ModifyDate = DateTime.Now;
                        check.ModifyBy = yC.ModifyBy;
                    }
                    db.SaveChanges();
                    return check;
                }
            }
            catch
            {
                return null;
            }
            
        }
    }
}
