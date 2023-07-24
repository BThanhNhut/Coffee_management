using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using BLL;
using DTO;

namespace GUI
{
    public partial class frm_QuanLy : Form
    {
        public frm_QuanLy()
        {
            InitializeComponent();
            LoadBanAn();
            LoadLoaiThucAn();
            TaiKhoan a = frm_DangNhap.Account;
            lbl_tennv.Text = a.TenHT;
            if (a.Loai == 1)
                lbl_chucvu.Text = "Quản Lý";
            else
                lbl_chucvu.Text = "Nhân Viên";
            
        }

        void Binding(DataTable tb)
        {
            cbo_loaithucan.DataBindings.Clear();
            cbo_loaithucan.DataBindings.Add("Text", tb, "Tên thức ăn");
            
        }
        void LoadBanAn()
        {
            flp_banan.Controls.Clear();
            foreach (BanAn item in BanAnBLL.Instance.LoadBanAn())
            {
                Button btn = new Button() { Width = 140, Height = 140 };
                btn.Text = item.TenBan + "\n" +item.TinhTrang;
                btn.Click += Btn_Click;
                btn.ImageAlign = ContentAlignment.BottomRight;
                if (item.TinhTrang == "Bàn Trống")
                    btn.Image = null;
                else
                    btn.Image = ListHinh.Images[0]; 
                btn.Tag = item;
                btn.BackColor = Color.BurlyWood;
                flp_banan.Controls.Add(btn);
            }
        }
        void LoadThucAn(int Ma)
        {
            cbo_thucan.DataSource = ThucAnBLL.Instance.LoadThucAn(Ma);
            cbo_thucan.ValueMember = "MaTA";
            cbo_thucan.DisplayMember = "TenTA";
        }

        void LoadLoaiThucAn()
        {
            cbo_loaithucan.DataSource = LoaiThucAnBLL.Instance.LoadLoaiThucAn();
            cbo_loaithucan.DisplayMember = "TenLoai";
        }


        void HienThiHoaDon(int MaBan)
        {
            float TongTien = 0;
            lsv_hoadon.Items.Clear();
            List<ThongTinThucAn> lst_TA = ThongTinThucAnBLL.Instance.LayTT_BanAn(MaBan); // lấy thông tin tự tạo của 1 món ăn
            foreach (ThongTinThucAn item in lst_TA)
            {
                ListViewItem lst = new ListViewItem(item.TenTA.ToString());
                lst.SubItems.Add(item.Gia.ToString());
                lst.SubItems.Add(item.SoLuong.ToString());
                lst.SubItems.Add(item.TongTien.ToString());
                TongTien += item.TongTien;
                lsv_hoadon.Items.Add(lst);
            }
            CultureInfo culture = new CultureInfo("vi-VN");
            txt_tongtien.Text = TongTien.ToString("c",culture);
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            int id = ((sender as Button).Tag as BanAn).ID;
            lsv_hoadon.Tag = (sender as Button).Tag;
            lbl_banchon.Text = ((sender as Button).Tag as BanAn).TenBan.ToString();
            HienThiHoaDon(id);
        }

        private void cbo_loaithucan_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Ma_Loai = 0;
            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem == null)
                return;

            LoaiThucAn selected = cb.SelectedItem as LoaiThucAn;

            Ma_Loai = selected.MaLoai_TA;

            LoadThucAn(Ma_Loai);
        }

        private void btn_themmon_Click(object sender, EventArgs e)
        {
            BanAn table = lsv_hoadon.Tag as BanAn; 

            int MaHD = HoaDonBLL.Instance.LayHoaDon_BanAn(table.ID);
            int MaTA = (cbo_thucan.SelectedItem as ThucAn).MaTA;
            int SoLuong = Convert.ToInt32(txt_soluong.Text);
            if (MaHD == -1)
            {
                HoaDonBLL.Instance.Insert_HoaDon(table.ID);
                CT_HoaDonBLL.Instance.Insert_CT_HoaDon(HoaDonBLL.Instance.LayIDMax_HoaDon(), MaTA, SoLuong);
            }
            else // Hóa đơn tồn tại
            {
                CT_HoaDonBLL.Instance.Insert_CT_HoaDon(MaHD, MaTA, SoLuong);
            }
            HienThiHoaDon(table.ID);
            LoadBanAn();
        }

        private void btn_thanhtoan_Click(object sender, EventArgs e)
        {
            BanAn table = lsv_hoadon.Tag as BanAn;
            int MaHD = HoaDonBLL.Instance.LayHoaDon_BanAn(table.ID);
            int GiamGia = Convert.ToInt32(txt_giamgia.Text);
            float tongtien = float.Parse(txt_tongtien.Text, NumberStyles.Currency, new CultureInfo("vi-VN")); ; // chuyển tt từ currency sang double
            float tt_sau_gg = tongtien - (tongtien / 100) * GiamGia; 
            if (MaHD != 1)
            {
                DialogResult r;
                r = MessageBox.Show("Bạn có thật sự muốn thanh toán hóa đơn " + table.TenBan +"\n Tổng tiền là : " + tt_sau_gg.ToString() + " VNĐ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (r == DialogResult.Yes)
                {
                    HoaDonBLL.Instance.ThanhToan(MaHD,GiamGia, tt_sau_gg);
                    //in report
                    Rpt_HoaDon rpt = new Rpt_HoaDon();
                    rpt.SetDataSource(ThongTinThucAnBLL.Instance.SP_Lay_TT_InHD(table.ID, MaHD));                  
                    frm_InHoaDon frm = new frm_InHoaDon();
                    frm.crystalReportViewer1.ReportSource = rpt;
                    frm.ShowDialog();
                    //end
                    HienThiHoaDon(table.ID);
                    LoadBanAn();
                    
                }    
            }
        }

        private void lsv_hoadon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsv_hoadon.SelectedItems.Count > 0)
            {
                string TenTA = lsv_hoadon.SelectedItems[0].SubItems[0].Text;
                int a = ThongTinThucAnBLL.Instance.BinDing_LoaiTA(TenTA) - 1;
                cbo_loaithucan.SelectedIndex = a;
                int b = ThongTinThucAnBLL.Instance.SP_BinDing_ThucAn(TenTA);
                cbo_thucan.SelectedValue = b;
            }
            

        }

        //private void lsv_hoadon_Click(object sender, EventArgs e)
        //{
        //    Binding(LoaiThucAnBLL.Instance.Lay_All_LoaiThucAn());
        //}
    }
}
