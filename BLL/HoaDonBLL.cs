using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using DAL;

namespace BLL
{
    public class HoaDonBLL
    {
        private static HoaDonBLL instance;
        public static HoaDonBLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new HoaDonBLL();
                return HoaDonBLL.instance;
            }
        }
        private HoaDonBLL() { }

        public int LayHoaDon_BanAn(int MaBan)
        {
            return HoaDonDAL.Instance.LayHoaDon_BanAn(MaBan);
        }

        public void Insert_HoaDon(int MaBan)
        {
            HoaDonDAL.Instance.Insert_HoaDon(MaBan);
        }

        public int LayIDMax_HoaDon()
        {
            return HoaDonDAL.Instance.LayIDMax_HoaDon();
        }

        public void ThanhToan(int MaHD, int GiamGia, float TongTien)
        {
            HoaDonDAL.Instance.ThanhToan(MaHD, GiamGia, TongTien);
        }

        public DataTable Lay_All_DSHD_ThongKe(DateTime NgayVao, DateTime NgayRa)
        {
            return HoaDonDAL.Instance.Lay_All_DSHD_ThongKe(NgayVao, NgayRa);
        }

        public DataTable ThongKeSoTien(int BatDau, int KetThuc)
        {
            return HoaDonDAL.Instance.ThongKeSoTien(BatDau, KetThuc);
        }
    }
}
