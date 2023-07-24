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
    public class HoaDonDAL
    {
        private static HoaDonDAL instance;
        public static HoaDonDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new HoaDonDAL();
                return HoaDonDAL.instance;
            }
        }
        private HoaDonDAL() { }

        public int LayHoaDon_BanAn(int MaBan)
        {
            DataTable data = DataProvider.Instance.ExcuteQuery("Exec SP_LayHoaDon_BanAn @MaBan", new object[] { MaBan });
            if (data.Rows.Count > 0)
            {
                HoaDon hd = new HoaDon(data.Rows[0]);
                return hd.MaHD;
            }
            return -1; //Không có mã
        }

        public void Insert_HoaDon(int Ma)
        {
            try
            {
                DataProvider.Instance.ExcuteNonQuery("SP_Insert_HoaDon @MaBan", new object[] { Ma });
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
        }

        public int LayIDMax_HoaDon()
        {
            return (int)DataProvider.Instance.ExcuteScalar("SP_LayIDMax_HoaDon");
        }

        public void ThanhToan(int MaHD, int GiamGia, float TongTien)
        {
            DataProvider.Instance.ExcuteNonQuery("SP_ThanhToanHD @MaHD , @GiamGia , @TongTien ", new object[] { MaHD, GiamGia, TongTien });
        }

        public DataTable Lay_All_DSHD_ThongKe(DateTime NgayVao, DateTime NgayRa)
        {
           return DataProvider.Instance.ExcuteQuery("Lay_All_DSHD_ThongKe @NgayVao , @NgayRa", new object[] { NgayVao, NgayRa});
        }

        public DataTable ThongKeSoTien(int BatDau, int KetThuc)
        {
            return DataProvider.Instance.ExcuteQuery("SP_ThongKeSoTien @BatDau , @KetThuc", new object[] { BatDau, KetThuc });
        }
    }
}
