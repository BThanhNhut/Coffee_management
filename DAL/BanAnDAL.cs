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
    public class BanAnDAL
    {
        private static BanAnDAL instance;
        public static BanAnDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new BanAnDAL();
                return BanAnDAL.instance;
            }
        }
        private BanAnDAL() { }

        public List<BanAn> LoadBanAn()
        {
            List<BanAn> ListBanAn = new List<BanAn>();
            DataTable data = DataProvider.Instance.ExcuteQuery("Exec SP_LoadBan");
            foreach (DataRow item in data.Rows)
            {
                BanAn a = new BanAn(item);
                ListBanAn.Add(a);
            }
            return ListBanAn;
        }

        public DataTable LayAll_BanAn()
        {
            return DataProvider.Instance.ExcuteQuery("SP_LayAll_BanAn ");
        }

        public bool Insert_BanAn(string TenBan)
        {
            return DataProvider.Instance.ExcuteNonQuery("SP_ThemBan @TenBan", new object[] { TenBan }) > 0;
        }
    }
}
