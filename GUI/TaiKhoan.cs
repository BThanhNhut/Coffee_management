using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DTO;
using BLL;


namespace GUI
{
    public partial class frm_TaiKhoan : Form
    {
        public frm_TaiKhoan()
        {
            InitializeComponent();
            ptb_avatar.Image = Image.FromFile(@"D:\Cong_Nghe.net\Bao_Cao_Cuoi_Ki\QL_QuanCafe10\QL_QuanCafe\Image\goimon.png");
            Load_TT();
        }

        void Load_TT()
        {
            TaiKhoan a = frm_DangNhap.Account;
            txt_tendangnhap.Text = a.TenDN;
            txt_tenhienthi.Text = a.TenHT;
            txt_matkhau.Text = a.Pass;
            if (a.Loai == 1)
                txt_chucvu.Text = "Quản Lý";
            else
                txt_chucvu.Text = "Nhân Viên";
            txt_diachi.Text = a.DiaChi;
            txt_sdt.Text = a.SDT;

            txt_matkhau.Enabled = false;
            txt_matkhaumoi.Enabled = false;
            txt_nhaplaimk.Enabled = false;
            txt_tendangnhap.Enabled = false;
            txt_tenhienthi.Enabled = false;
            txt_chucvu.Enabled = false;
            txt_sdt.Enabled = false;
            txt_diachi.Enabled = false;

        }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            CapNhat();
        }

        void CapNhat()
        {
            string TenDN = txt_tendangnhap.Text.Trim();
            string TenHT = txt_tenhienthi.Text.Trim();
            string MatKhau = txt_matkhau.Text.Trim();
            string MatKhauMoi = txt_matkhaumoi.Text.Trim();
            string NhapLaiMK = txt_nhaplaimk.Text.Trim();
            string ChucVu = txt_chucvu.Text.Trim();
            string DiaChi = txt_diachi.Text.Trim();
            string SDT = txt_sdt.Text.Trim();

            if (!MatKhauMoi.Equals(NhapLaiMK))
            {
                MessageBox.Show("Mật khẩu mới phải trùng khớp với mật khẩu");
            }
            else
            {
                if (TaiKhoanBLL.Instance.CapNhatTK(TenDN, TenHT, MatKhau, MatKhauMoi, ChucVu, DiaChi, SDT))
                {
                    MessageBox.Show("Cập nhật thành công");
                    txt_matkhau.Enabled = false;
                    txt_matkhaumoi.Enabled = false;
                    txt_nhaplaimk.Enabled = false;
                    txt_tendangnhap.Enabled = false;
                    txt_tenhienthi.Enabled = false;
                    txt_chucvu.Enabled = false;
                    txt_sdt.Enabled = false;
                    txt_diachi.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Vui lòng điền đúng mật khẩu");
                }
            }
        }

        private void btn_thaydoitt_Click(object sender, EventArgs e)
        {
            txt_matkhau.Enabled = true;
            txt_tenhienthi.Enabled = true;
            txt_sdt.Enabled = true;
            txt_diachi.Enabled = true;
        }

        private void btn_thaydoimk_Click(object sender, EventArgs e)
        {
            txt_matkhau.Enabled = true;
            txt_matkhaumoi.Enabled = true;
            txt_nhaplaimk.Enabled = true;
        }
    }
}
