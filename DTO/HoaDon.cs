using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DTO
{
    public class HoaDon
    {
        public int MaHD { get; set; }
        public DateTime? NgayVao { get; set; }
        public DateTime? NgayRa { get; set; }
        public int TinhTrang { get; set; }

        public int GiamGia { get; set; }

        public HoaDon(int id, DateTime? ngayvao, DateTime? ngayra, int TinhTrang, int GiamGia)
        {
            this.MaHD = id;
            this.NgayVao = ngayvao;
            this.NgayRa = ngayra;
            this.TinhTrang = TinhTrang;
            this.GiamGia = GiamGia;
        }

        public HoaDon(DataRow row)
        {
            this.MaHD = (int)row["MaHD"];
            this.NgayVao = (DateTime?)row["NgayVao"];

            var datecheckout = row["NgayRa"];
            if (datecheckout.ToString() != "")
                this.NgayRa = (DateTime?)datecheckout;
            this.TinhTrang = (int)row["TinhTrang"];
            this.GiamGia = (int)row["GiamGia"];
        }
    }

}
