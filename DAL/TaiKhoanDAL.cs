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
    public class TaiKhoanDAL
    {
        private static TaiKhoanDAL instance;
        public static TaiKhoanDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new TaiKhoanDAL();
                return TaiKhoanDAL.instance;
            }
        }

        public bool KiemTraTaiKhoan(TaiKhoan a)
        {
            string sql = "Exec SP_DangNhap @TenDN , @Pass";
            DataTable table = new DataTable();
            table = DataProvider.Instance.ExcuteQuery(sql, new object[] { a.TenDN, a.Pass });
            return table.Rows.Count > 0;
        }

        public DataTable TimKiem_TK(string a)
        {
            string sql = "Exec SP_TimKiem_TK @TenDN";
            return DataProvider.Instance.ExcuteQuery(sql, new object[] { a });
        }

        public DataTable SP_LayALL_TaiKhoan()
        {
            return DataProvider.Instance.ExcuteQuery("SP_LayALL_TaiKhoan");
        }

        public bool CapNhatTK (string TenDN, string TenHT, string MatKhau, string MatKhauMoi, string ChucVu, string DiaChi, string SDT)
        {
            int data = DataProvider.Instance.ExcuteNonQuery("SP_CapNhatTK @TenDN , @TenHT , @MatKhau , @MatKhauMoi , @ChucVu , @DiaChi , @SDT ", new object[] { TenDN, TenHT, MatKhau, MatKhauMoi, ChucVu, DiaChi, SDT });
            return data > 0;
        }
    }
}
