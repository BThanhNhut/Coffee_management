using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
using DAL;

namespace BLL
{
    public class BanAnBLL
    {
        public static BanAnBLL instance;
        public static BanAnBLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new BanAnBLL();
                return instance;
            }
        }
        private BanAnBLL() { }
        public List<BanAn> LoadBanAn()
        {
            List<BanAn> ListBanAn = BanAnDAL.Instance.LoadBanAn();
            return ListBanAn;
        }

        public DataTable LayAll_BanAn()
        {
            return BanAnDAL.Instance.LayAll_BanAn();
        }

        public bool Insert_BanAn(string TenBan)
        {
            return BanAnDAL.Instance.Insert_BanAn(TenBan);
        }
    }
}
