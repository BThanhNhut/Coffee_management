using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using BLL;

namespace GUI
{
    public partial class frm_LoaiThucAn : Form
    {
        public frm_LoaiThucAn()
        {
            InitializeComponent();
        }

        private void fLoaiThucAn_Load(object sender, EventArgs e)
        {
            gv_loaithucan.DataSource = LoaiThucAnBLL.Instance.Lay_All_LoaiThucAn();
        }

        private void bbtn_refesh_loaithucan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gv_loaithucan.DataSource = LoaiThucAnBLL.Instance.Lay_All_LoaiThucAn();
        }

        private void bbtn_themloaithucan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_ThemLoaiThucAn frm = new frm_ThemLoaiThucAn();
            frm.Show();
        }

        private void gv_loaithucan_Click(object sender, EventArgs e)
        {

        }


    }
}
