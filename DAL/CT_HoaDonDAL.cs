using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;

namespace DAL
{
    public class CT_HoaDonDAL
    {
        private static CT_HoaDonDAL instance;
        public static CT_HoaDonDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new CT_HoaDonDAL();
                return CT_HoaDonDAL.instance;
            }
        }
        private CT_HoaDonDAL() { }

        public List<CT_HoaDon> Lay_DSHD(int MaHD)
        {
            List<CT_HoaDon> listhd = new List<CT_HoaDon>();
            DataTable data = DataProvider.Instance.ExcuteQuery("Exec SP_Lay_DSHD @MaHD", new object[] { MaHD });
            foreach (DataRow item in data.Rows)
            {
                CT_HoaDon hd = new CT_HoaDon(item);
                listhd.Add(hd);
            }
            return listhd;
        }

        public void Insert_CT_HoaDon(int MaHD, int MaTA, int SoLuong)
        {
            DataProvider.Instance.ExcuteNonQuery("SP_Insert_CT_HoaDon @MaHD , @MaTA , @SoLuong ", new object[] { MaHD, MaTA, SoLuong});
        }
    }
}
