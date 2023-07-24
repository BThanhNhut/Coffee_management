using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class CT_HoaDonBLL
    {
        private static CT_HoaDonBLL instance;
        public static CT_HoaDonBLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new CT_HoaDonBLL();
                return CT_HoaDonBLL.instance;
            }
        }
        private CT_HoaDonBLL() { }
        
        public List<CT_HoaDon> List_TA (int MaBan)
        {
            return CT_HoaDonDAL.Instance.Lay_DSHD(HoaDonDAL.Instance.LayHoaDon_BanAn(MaBan));
        }

        public void Insert_CT_HoaDon(int MaHD, int MaTA, int SoLuong)
        {
            CT_HoaDonDAL.Instance.Insert_CT_HoaDon(MaHD, MaTA, SoLuong);
        }
    }
}
