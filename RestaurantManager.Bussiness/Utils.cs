using RestaurantManager.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.Bussiness
{
    public static class Utils
    {
        public static DataTable ToDataTable<T>(this IList<T> data)
        {
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;
        }
        public static int getNewId(string table)
        {
            try
            {
                using (var db = new RestaurantManagerDataEntities())
                {
                    var _table= new SqlParameter("@table", table);
                    var result = db.Database.SqlQuery<int>("EXEC dbo.[Proc_GetNewId] @table",_table).FirstOrDefault();
                    return result;
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
