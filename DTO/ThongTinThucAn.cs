using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DTO
{
    public class ThongTinThucAn
    {
        public string TenTA { get; set; }
        public int Gia { get; set; }
        public int SoLuong { get; set; }
        public float TongTien { get; set; }
        public int GiamGia { get; set; }

        public ThongTinThucAn (string TenTA, int SoLuong, int Gia, float TongTien, int GiamGia)
        {
            this.TenTA = TenTA;
            this.SoLuong = SoLuong;
            this.Gia = Gia;
            this.TongTien = TongTien;
            this.GiamGia = GiamGia;
        }
        public ThongTinThucAn(DataRow r)
        {
            this.TenTA = r["TenTA"].ToString();
            this.SoLuong = (int)r["SoLuong"];
            this.Gia = (int)r["Gia"];
            this.TongTien = (float)Convert.ToDouble(r["TongTien"].ToString());
            
        }
        //public ThongTinThucAn (DataRow r, int a)
        //{
        //    this.TenTA = r["TenTA"].ToString();
        //    this.SoLuong = (int)r["SoLuong"];
        //    this.Gia = (int)r["Gia"];
        //    this.TongTien = (float)Convert.ToDouble(r["ThanhTien"].ToString());
        //    this.GiamGia = (int)r["GiamGia"];
        //}
    }
}
