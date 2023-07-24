using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DTO
{
    public class ThucAn
    {
        public int MaTA { get; set; }
        public string TenTA { get; set; }
        public int Loai { get; set; }
        public double Gia { get; set; }
        public ThucAn(int MaTA, string TenTA, int Loai, double Gia)
        {
            this.MaTA = MaTA;
            this.TenTA = TenTA;
            this.Loai = Loai;
            this.Gia = Gia;
        }

        public ThucAn(DataRow r)
        {
            this.MaTA = (int)r["MaTA"];
            this.TenTA = r["TenTA"].ToString();
            this.Loai = (int)r["Loai"];
            this.Gia = (double)Convert.ToDouble(r["Gia"].ToString());
        }
    }
}
