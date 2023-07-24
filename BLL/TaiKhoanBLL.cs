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
    public class TaiKhoanBLL
    {
        public static TaiKhoanBLL instance;
        public static TaiKhoanBLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new TaiKhoanBLL();
                return instance;
            }
        }

        public bool KiemTra_Input(TaiKhoan a)
        {
            if (a.TenDN.Length == 0)
                return false;
            if (a.Pass.Length == 0)
                return false;
            return TaiKhoanDAL.Instance.KiemTraTaiKhoan(a);
        }
        public TaiKhoan TimKiem_TK(string a)
        {
            DataTable table;
            try
            {
                table = TaiKhoanDAL.Instance.TimKiem_TK(a);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return new TaiKhoan(table.Rows[0]);
        }

        public DataTable SP_LayALL_TaiKhoan()
        {
            return TaiKhoanDAL.Instance.SP_LayALL_TaiKhoan();
        }

        public bool CapNhatTK(string TenDN, string TenHT, string MatKhau, string MatKhauMoi, string ChucVu, string DiaChi, string SDT)
        {
            return TaiKhoanDAL.Instance.CapNhatTK(TenDN, TenHT, MatKhau, MatKhauMoi, ChucVu, DiaChi, SDT);
        }
    }
}
