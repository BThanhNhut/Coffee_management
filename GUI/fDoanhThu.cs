            using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace GUI
{
    public partial class frm_DoanhThu : Form
    {
        public frm_DoanhThu()
        {
            InitializeComponent();
        }



        void Load_HoaDon_TheoNgay(DateTime NgayVao, DateTime NgayRa)
        {
            gv_doanhthu.DataSource = HoaDonBLL.Instance.Lay_All_DSHD_ThongKe(NgayVao, NgayRa);
        }

        private void btn_thongke_Click(object sender, EventArgs e)
        {
            Load_HoaDon_TheoNgay(dtp_ngayvao.Value, dtp_ngayra.Value);
        }

   
    }
}
