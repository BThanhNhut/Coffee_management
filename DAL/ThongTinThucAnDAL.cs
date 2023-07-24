using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
namespace DAL
{
    public class ThongTinThucAnDAL
    {
        private static ThongTinThucAnDAL instance;
        public static ThongTinThucAnDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new ThongTinThucAnDAL();
                return ThongTinThucAnDAL.instance;
            }
        }
        private ThongTinThucAnDAL() { }

        public List<ThongTinThucAn> LayTT_BanAn(int MaBan)
        {
            List<ThongTinThucAn> lst = new List<ThongTinThucAn>();
            DataTable data = DataProvider.Instance.ExcuteQuery("EXEC SP_LayTT_ThucAn @MaBan", new object[] { MaBan });
            foreach (DataRow item in data.Rows)
            {
                ThongTinThucAn info = new ThongTinThucAn(item);
                lst.Add(info);
            }
            return lst;
        }

        public DataTable SP_Lay_TT_InHD (int MaBan, int MaHD)
        {
            return DataProvider.Instance.ExcuteQuery("SP_Lay_TT_InHD @MaBan , @MaHD ", new object[] { MaBan, MaHD });
        }

        public int BinDing_LoaiTA(string TenTA)
        {
            TenTA.Trim();
            return (int)DataProvider.Instance.ExcuteScalar("SP_BinDing_LoaiTA @TenTA", new object[] { TenTA });
        }

        public int SP_BinDing_ThucAn(string TenTA)
        {
            TenTA.Trim();
            return (int)DataProvider.Instance.ExcuteScalar("SP_BinDing_ThucAn @TenTA", new object[] { TenTA });
        }
    }
}
