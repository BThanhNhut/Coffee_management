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
    public partial class frm_TaiKhoan_ql : Form
    {
        public frm_TaiKhoan_ql()
        {
            InitializeComponent();
        }
        private void frm_TaiKhoan_ql_Load(object sender, EventArgs e)
        {
            gv_taikhoan.DataSource = TaiKhoanBLL.Instance.SP_LayALL_TaiKhoan();
        }
    }
}
