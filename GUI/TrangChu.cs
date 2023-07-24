using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

using BLL;
using DTO;

namespace GUI
{
    public partial class frm_TrangChu : DevExpress.XtraEditors.XtraForm
    {
        WaitFormBLL WFBLL = new WaitFormBLL();
        
        public frm_TrangChu(TaiKhoan a)
        {
            InitializeComponent();
            frm_DangNhap.Account = a;
            if (a.Loai == 1)
            {
                rib_quanly.Visible = true;
            }
        }
        void OpenForm(Type typefrom) // Mở from tránh trùng lập
        {
            foreach (Form a in MdiChildren)
            {
                if (a.GetType() == typefrom)
                {
                    a.Activate();
                    return;
                }
            }
            Form f = (Form)Activator.CreateInstance(typefrom);
            f.MdiParent = this;
            f.Show();
        }
        private void bbtn_taikhoan_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (frm_WaitForm2 frm = new frm_WaitForm2(WFBLL.wait))
            {
                frm.ShowDialog(this);
            }
            OpenForm(typeof(frm_TaiKhoan));
        }

        private void bbtn_tacvu_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(frm_QuanLy));
        }

        private void bbtn_banan_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(frm_BanAn));
        }

        private void bbtn_dangxuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có chắc chắn muốn thoát khỏi tài khoản !!!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Yes)
            {
                this.Hide();
                frm_DangNhap frm = new frm_DangNhap();
                frm.ShowDialog();
            } 
        }

        private void bbtn_thucdon_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(frm_ThucDon));
        }

        private void bbtn_danhmuc_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(frm_LoaiThucAn));
        }

        private void bbtn_taikhoan_ql_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(frm_TaiKhoan_ql));
        }

        private void bbtn_doanhthu_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(frm_DoanhThu));
        }

        private void bbtn_thongke_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(frm_ThongKe));
        }
    }
}