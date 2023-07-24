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
    public partial class frm_ThongKe : Form
    {
        public frm_ThongKe()
        {
            InitializeComponent();
            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Tháng";
            chart1.ChartAreas["ChartArea1"].AxisY.Title = "Tổng tiền";
            chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            DataTable table = HoaDonBLL.Instance.ThongKeSoTien(1, 12);
            for (int i = 0; i < table.Rows.Count; i++)
            {
                chart1.Series["TongTien"].Points.AddXY(table.Rows[i]["Thang"], table.Rows[i]["TongTien1Thang"]);
            }
        }

        private void btn_hienthibieudo_Click(object sender, EventArgs e)
        {
           
        }
    }
}
