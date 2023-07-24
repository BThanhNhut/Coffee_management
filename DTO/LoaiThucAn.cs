using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DTO
{
    public class LoaiThucAn
    {
        public int MaLoai_TA { get; set; }
        public string TenLoai { get; set; }

        public LoaiThucAn(int MaLoai_TA, string TenLoai)
        {
            this.MaLoai_TA = MaLoai_TA;
            this.TenLoai = TenLoai;
        }

        public LoaiThucAn(DataRow r)
        {
            this.MaLoai_TA = (int)r["MaLoai_TA"];
            this.TenLoai = r["TenLoai"].ToString();
        }
    }
}
