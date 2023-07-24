using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DTO
{
    public class CT_HoaDon
    {
        public int Ma { get; set; }
        public int MaHD { get; set; }
        public int MaTA { get; set; }
        public int SoLuong { get; set; }

        public CT_HoaDon(int Ma, int MaHD, int MaTA, int SoLuong)
        {
            this.Ma = Ma;
            this.MaHD = MaHD;
            this.MaTA = MaTA;
            this.SoLuong = SoLuong;
        }

        public CT_HoaDon(DataRow r)
        {
            this.Ma = (int)r["Ma"];
            this.MaHD = (int)r["MaHD"];
            this.MaTA = (int)r["MaTA"];
            this.SoLuong = (int)r["SoLuong"];
        }
    }
}
