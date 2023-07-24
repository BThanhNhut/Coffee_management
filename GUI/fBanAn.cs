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
    public partial class frm_BanAn : Form
    {
        public frm_BanAn()
        {
            InitializeComponent();
        }

        private void frm_BanAn_Load(object sender, EventArgs e)
        {
            gv_banan.DataSource = BanAnBLL.Instance.LayAll_BanAn();
        }

        private void bbtn_themban_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_ThemBan frm  =  new frm_ThemBan();
            frm.Show();
        }
        private void btn_refesh_banan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gv_banan.DataSource = BanAnBLL.Instance.LayAll_BanAn();
        }
    }
}
