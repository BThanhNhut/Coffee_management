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
    public partial class frm_ThemBan : Form
    {
        public frm_ThemBan()
        {
            InitializeComponent();
        }

        private void btn_themban_Click(object sender, EventArgs e)
        {
            string TenBan = txt_tenban.Text.Trim();
            
            if (TenBan == "")
            {
                MessageBox.Show("Bạn chưa nhập dữ liệu");
                return;
            }

            if (BanAnBLL.Instance.Insert_BanAn(TenBan) == true)
                MessageBox.Show("Thêm bàn thành công");
            else
                MessageBox.Show("Thêm bàn thất bại");
            this.Close();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
