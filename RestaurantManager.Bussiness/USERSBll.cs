using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantManager.Database;
using RestaurantManager.Model;

namespace RestaurantManager.Bussiness
{
    public class USERSBll
    {
        public USER Login(string username, string password, ref string outmess)
        {
            try
            {
                using (var db = new RestaurantManagerDataEntities())
                {
                    var result = db.USERS.AsNoTracking().FirstOrDefault(x => x.UserName == username && x.Password == password);
                    if (result == null)
                    {
                        return null;
                    }
                    return result;
                }
            }
            catch (Exception ex)
            {
                outmess = ex.Message;
                return null;
            }
        }

        public USER ChangePassword(string username, string password, ref string outmess)
        {
            try
            {
                using (var db = new RestaurantManagerDataEntities())
                {
                    var result = db.USERS.AsNoTracking().FirstOrDefault(x => x.UserName == username);
                    if (result == null)
                    {
                        outmess = "Tài khoản không tồn tại!";
                        return null;
                    }
                    result.Password = password;
                    db.SaveChanges();
                    outmess = "success";
                    return result;
                }
            }
            catch (Exception ex)
            {
                outmess = ex.Message;
                return null;
            }
        }
        public List<USER> GetListUsers()
        {
            try
            {
                using (var db = new RestaurantManagerDataEntities())
                {
                    var lst = db.USERS.AsNoTracking().ToList();
                    return lst;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public string saveUser(USER user, ref string outmess)
        {
            try
            {
                using (var db = new RestaurantManagerDataEntities())
                {
                    var result = db.USERS.AsNoTracking().FirstOrDefault(x => x.UserName == user.UserName);
                    if (result == null)
                    {
                        db.USERS.Add(user);
                        db.SaveChanges();
                        outmess = "success";
                        return "Thêm nhân viên thành công!";
                    }
                    else
                    {
                        result.Password = user.Password;
                        result.SoDT = user.SoDT;
                        result.DiaChi = user.DiaChi;
                        result.ten = user.ten;
                        //result. = user.ChucVu;
                        result.ChucVu = user.ChucVu;
                        outmess = "success";
                        return "Cập nhật nhân viên thành công!";
                    }
                }
            }
            catch (Exception ex)
            {
                outmess = "error";
                return ex.Message;
            }
        }
        public List<USER> GetUsersByPosition(string position, string loginCode, ref string outmess)
        {
            try
            {
                using (var db = new RestaurantManagerDataEntities())
                {
                    var lst = db.USERS.AsNoTracking().Where(e => e.ChucVu == position).ToList();
                    outmess = "success";
                    return lst;
                }
            }
            catch (Exception ex)
            {
                outmess = ex.Message;
                return null;
            }
        }

    }
}
