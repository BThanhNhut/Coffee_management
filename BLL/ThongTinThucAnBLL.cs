using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using DTO;

namespace BLL
{
    public class ThongTinThucAnBLL
    {
        private static ThongTinThucAnBLL instance;
        public static ThongTinThucAnBLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new ThongTinThucAnBLL();
                return ThongTinThucAnBLL.instance;
            }
        }
        private ThongTinThucAnBLL() { }

        public List<ThongTinThucAn> LayTT_BanAn(int MaBan)
        {
            return ThongTinThucAnDAL.Instance.LayTT_BanAn(MaBan);
        }

        public DataTable SP_Lay_TT_InHD(int MaBan, int MaHD)
        {
            return ThongTinThucAnDAL.Instance.SP_Lay_TT_InHD(MaBan,MaHD);
        }
        public int BinDing_LoaiTA(string TenTA)
        {
            return ThongTinThucAnDAL.Instance.BinDing_LoaiTA(TenTA);
        }

        public int SP_BinDing_ThucAn(string TenTA)
        {
            return ThongTinThucAnDAL.Instance.SP_BinDing_ThucAn(TenTA);
        }

    }
}
