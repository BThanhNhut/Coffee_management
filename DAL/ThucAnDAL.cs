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
    public class ThucAnDAL
    {
        private static ThucAnDAL instance;
        public static ThucAnDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new ThucAnDAL();
                return ThucAnDAL.instance;
            }
        }
        private ThucAnDAL() { }

        public List<ThucAn> LoadThucAn(int MaLoai_TA)
        {
            List<ThucAn> lst = new List<ThucAn>();
            DataTable table = DataProvider.Instance.ExcuteQuery("SP_LoadThucAn  @MaLoai_TA", new object[] { MaLoai_TA });
            foreach (DataRow item in table.Rows)
            {
                ThucAn info = new ThucAn(item);
                lst.Add(info);
            }
            return lst;
        }

        public DataTable Lay_All_ThucAn()
        {
            return DataProvider.Instance.ExcuteQuery("SP_Lay_All_ThucAn");
        }

        public bool ThemThucAn(string TenTA, int Loai, int Gia)
        {
            return DataProvider.Instance.ExcuteNonQuery("SP_ThemThucAn @TenTA , @Loai , @Gia", new object[] { TenTA, Loai, Gia }) > 0;
        }

        public bool XoaThucAn(int MaTa)
        {
            return DataProvider.Instance.ExcuteNonQuery("SP_XoaThucAn @MaTA", new object[] { MaTa }) > 0;
        }

        public bool SuaThucAn(int MaTA, string TenTA, int Loai, int Gia)
        {
            return DataProvider.Instance.ExcuteNonQuery("SP_SuaThucAn @MaTA , @TenTA , @Loai , @Gia ", new object[] { MaTA, TenTA, Loai, Gia }) > 0;
        }
    }
}
