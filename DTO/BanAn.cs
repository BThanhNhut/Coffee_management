using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DTO
{
    public class BanAn
    {
        public int ID { get; set; }
        public string TenBan { get; set; }
        public string TinhTrang { get; set; }

        public BanAn (int ID, string TenBan, string TinhTrang)
        {
            this.ID = ID;
            this.TenBan = TenBan;
            this.TinhTrang = TinhTrang;
        }
        public BanAn (DataRow row)
        {
            this.ID = (int)row["MaBan"];
            this.TenBan = row["TenBan"].ToString();
            this.TinhTrang = row["TinhTrang"].ToString();
        }
    }
}
