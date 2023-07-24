using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
using DAL;

namespace BLL
{
    public class ThucAnBLL
    {
        private static ThucAnBLL instance;
        public static ThucAnBLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new ThucAnBLL();
                return ThucAnBLL.instance;
            }
        }
        private ThucAnBLL() { }

        public List<ThucAn> LoadThucAn(int MaLoai_TA)
        {
            return ThucAnDAL.Instance.LoadThucAn(MaLoai_TA);
        }

        public DataTable Lay_All_ThucAn()
        {
            return ThucAnDAL.Instance.Lay_All_ThucAn();
        }

        public bool ThemThucAn(string TenTA, int Loai, int Gia)
        {
            return ThucAnDAL.Instance.ThemThucAn(TenTA, Loai, Gia);
        }
        public bool XoaThucAn(int MaTA)
        {
            return ThucAnDAL.Instance.XoaThucAn(MaTA);
        }
        public bool SuaThucAn(int MaTA, string TenTA, int Loai, int Gia)
        {
            return ThucAnDAL.Instance.SuaThucAn(MaTA, TenTA, Loai, Gia);
        }
    }
}
