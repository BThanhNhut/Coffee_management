using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class LoaiThucAnDAL
    {
        private static LoaiThucAnDAL instance;
        public static LoaiThucAnDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new LoaiThucAnDAL();
                return LoaiThucAnDAL.instance;
            }
        }
        private LoaiThucAnDAL() { }

        public List<LoaiThucAn> LoadLoaiThucAn()
        {
            List<LoaiThucAn> lst = new List<LoaiThucAn>();
            DataTable table = DataProvider.Instance.ExcuteQuery("SP_LoadLoaiThucAn ");
            foreach (DataRow item in table.Rows)
            {
                LoaiThucAn info = new LoaiThucAn(item);
                lst.Add(info);
            }
            return lst;
        }

        public DataTable Lay_All_LoaiThucAn()
        {
            return DataProvider.Instance.ExcuteQuery("SP_Lay_All_LoaiThucAn");
        }

        public bool ThemLoaiThucAn(string TenLoai)
        {
            return DataProvider.Instance.ExcuteNonQuery("SP_ThemLoaiThucAn @TenLoai", new object[] { TenLoai }) > 0;
        }
    }

}
