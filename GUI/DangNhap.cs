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
using DTO;

namespace GUI
{
    public partial class frm_DangNhap : Form
    {
        WaitFormBLL LGBLL = new WaitFormBLL();
        public static TaiKhoan Account;

        public frm_DangNhap()
        {
            InitializeComponent();
        }
        private void cb_hienmatkhau_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_hienmatkhau.Checked)
                txt_matkhau.UseSystemPasswordChar = false;
            if (!cb_hienmatkhau.Checked)
                txt_matkhau.UseSystemPasswordChar = true;
        }
        private void lbl_thoat_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có thật sự muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Yes)
                this.Close();
        }
        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            using (frm_WaitForm frm = new frm_WaitForm(LGBLL.wait))
            {
                frm.ShowDialog(this);
            }
            TaiKhoan _taikhoan = new TaiKhoan(txt_taikhoan.Text, txt_matkhau.Text);
            if (TaiKhoanBLL.Instance.KiemTra_Input(_taikhoan))
            {
                TaiKhoan tk = TaiKhoanBLL.Instance.TimKiem_TK(_taikhoan.TenDN);
                //
              
                //
                frm_TrangChu f = new frm_TrangChu(tk);
                this.Hide();
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác", "Thông Báo");
            }
        }

   
    }
}
