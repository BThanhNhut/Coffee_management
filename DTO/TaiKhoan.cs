using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DTO
{
    public class TaiKhoan
    {
        public string TenDN { get; set; }
        public string TenHT { get; set; }
        public string Pass { get; set; }
        public int Loai { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public byte HinhAnh { get; set; }

        public TaiKhoan(string TenDN, string Pass)
        {
            this.TenDN = TenDN;
            this.Pass = Pass;
        }
        public TaiKhoan(string TenDN, string TenHT, int Loai, string Pass = null)
        {
            this.TenDN = TenDN;
            this.TenHT = TenHT;
            this.Loai = Loai;
            this.Pass = Pass;
        }
        public TaiKhoan(DataRow row)
        {
            this.TenDN = row["TenDN"].ToString();
            this.TenHT = row["TenHT"].ToString();
            this.Loai =  (int)row["Loai"];
            this.Pass =  row["Pass"].ToString();
            this.DiaChi = row["DiaChi"].ToString();
            this.SDT = row["SDT"].ToString();
        }
    }
}
