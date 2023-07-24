using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using DAL;

namespace BLL
{
    public class LoaiThucAnBLL
    {
        private static LoaiThucAnBLL instance;
        public static LoaiThucAnBLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new LoaiThucAnBLL();
                return LoaiThucAnBLL.instance;
            }
        }
        private LoaiThucAnBLL() { }

        public List<LoaiThucAn> LoadLoaiThucAn()
        {
            return LoaiThucAnDAL.Instance.LoadLoaiThucAn();
        }

        public DataTable Lay_All_LoaiThucAn()
        {
            return LoaiThucAnDAL.Instance.Lay_All_LoaiThucAn();
        }

        public bool ThemLoaiThucAn(string TenLoai)
        {
            return LoaiThucAnDAL.Instance.ThemLoaiThucAn(TenLoai);
        }


    }
}
