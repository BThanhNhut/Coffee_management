using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Thư Viện Dev
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraSplashScreen;
using BLL;


namespace GUI
{
    public partial class frm_ThucDon : Form
    {
        public frm_ThucDon()
        {
            InitializeComponent();
        }
        private void fThucDon_Load(object sender, EventArgs e)
        {
            gv_thucdon.DataSource = ThucAnBLL.Instance.Lay_All_ThucAn();
            cbo_loai.DataSource = LoaiThucAnBLL.Instance.Lay_All_LoaiThucAn();
            cbo_loai.ValueMember = "MaLoai_TA";
            cbo_loai.DisplayMember = "TenLoai";
            
        }

        private void bbtn_them_ql_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_tenthucan.Text))
            {
                MessageBox.Show("Chưa nhập tên thức uốn", "Thông báo");
                txt_tenthucan.Focus();
                return;
            }
            if (txt_gia.Text == "")
            {
                MessageBox.Show("Chưa nhập giá thức uốn", "Thông báo");
                txt_gia.Focus();
                return;
            }
            string TenTA = txt_tenthucan.Text;
            int Loai =  Convert.ToInt32(cbo_loai.SelectedValue);
            int Gia = Convert.ToInt32(txt_gia.Text);
            if (ThucAnBLL.Instance.ThemThucAn(TenTA, Loai, Gia) == true)
                MessageBox.Show("Thêm thành công");
            else
                MessageBox.Show("Thêm thất bại");

        }

        private void gv_thucdon_Click(object sender, EventArgs e)
        {
            gv_thucdon.DataSource = ThucAnBLL.Instance.Lay_All_ThucAn();
        }

        private void btn_refresh_thucan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gv_thucdon.DataSource = ThucAnBLL.Instance.Lay_All_ThucAn();
        }

        private void bbtn_xoa_ql_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có chắc muốn xóa thức ăn","Thông báo",MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (DialogResult.Yes == r)
            {
                if (ThucAnBLL.Instance.XoaThucAn(Convert.ToInt32(gridView1.GetFocusedRowCellValue("MaTA"))) == true)
                {
                    MessageBox.Show("Xóa Thành Công");
                    return;
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                    return;
                }
            }
            

        }
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                txt_gia.Text = gridView1.GetFocusedRowCellValue("Gia").ToString();
                txt_tenthucan.Text = gridView1.GetFocusedRowCellValue("TenTA").ToString();
                cbo_loai.SelectedValue = Convert.ToInt32(gridView1.GetFocusedRowCellValue("Loai"));
            }
            catch (Exception ex)
            {
                return;
                throw ex;
            }
           
        }

        private void bbtn_sua_ql_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int MaTA = Convert.ToInt32(gridView1.GetFocusedRowCellValue("MaTA"));
            string TenTA = txt_tenthucan.Text.Trim();
            int Loai = Convert.ToInt32(cbo_loai.SelectedValue);
            int Gia = Convert.ToInt32(txt_gia.Text);
            if (ThucAnBLL.Instance.SuaThucAn(MaTA, TenTA, Loai, Gia) == true)
                MessageBox.Show("Sửa thành công !", "Thông báo");
            else
                MessageBox.Show("Sửa thất bại ! ", "Thông báo");
        }
    }
}
