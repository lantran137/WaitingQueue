using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using Queue.Model;
using Queue.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Queue
{
    public partial class frmHangDoi : DevExpress.XtraEditors.XtraForm
    {
        public static List<DSBenhNhan> benhNhans = new List<DSBenhNhan>();
        public frmHangDoi()
        {
            InitializeComponent();
        }

        private void LoadHangDoi()
        {
            var value = System.Configuration.ConfigurationManager.AppSettings["phongban"];
            benhNhans = CallAPI.GetSoThuTuTrongNgay(value);
            var result = benhNhans.GroupBy(p => 
            new { p.NamYeuCau, p.TenBenhNhan, p.SoVaoVien, p.TrangThai, p.NoiThucHien_Id })
                .Select(x => new { x.Key.TenBenhNhan, x.Key.NamYeuCau, x.Key.SoVaoVien, x.Key.TrangThai, 
                    x.Key.NoiThucHien_Id,
                    NoiDungChiTiet = string.Join(",", x.Select(y => y.NoiDungChiTiet)),
                    TiepNhan_Id = x.Min(y => y.TiepNhan_Id),
                    SoThuTu= x.Min(y=>y.SoThuTu),
                    Id = x.Min(y => y.Id),
                    CLSYeuCau_Id = x.Min(y => y.CLSYeuCau_Id)});
            gcHangDoi.DataSource = benhNhans;
        }
        private void LoadDSDangXuLi()
        {
            List<DSDangXuLi> dSDangXuLis = CallAPI.GetSoThuTuTrongNgay_DangXuLy();
            gcDangXuLi.DataSource = dSDangXuLis;
        }
        
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            this.LoadHangDoi();
            this.LoadDSDangXuLi();
            btnCall.Click += btnCall_Click;
            btnUuTien.Click += btnUuTien_Click;
            btnDangXuLi.Click += btnDangXuLi_Click;
            btnHuyXuLi.Click += btnHuyXuLi_Click;
            btnHuyGoi.Click += btnHuyGoi_Click;
            gvHangDoi.RowStyle += gvHangDoi_RowStyle;
        }

        private void btnHuyGoi_Click(object sender, EventArgs e)
        {
            int[] selectedRows = gvHangDoi.GetSelectedRows();
            foreach (int index in selectedRows)
            {
                if (benhNhans[index].TiepNhan_Id == "1") 
                {
                    string message = "00";
                    Terminal.frmMain a = new Terminal.frmMain(message);
                    DSBenhNhan dSBenhNhans = gvHangDoi.GetRow(index) as DSBenhNhan;
                    CallAPI.SoThuTu_HuyGoi(dSBenhNhans.CLSYeuCau_Id);
                    gridColumn1.Visible = true;
                    this.LoadHangDoi();
                    MessageBox.Show("Hủy gọi thành công", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn đúng bệnh nhân");
                }
                
            }
            
        }

        private void btnHuyXuLi_Click(object sender, EventArgs e)
        {
            int[] selectedRows = gvDangXuLi.GetSelectedRows();
            foreach (int index in selectedRows)
            {
                DSDangXuLi dSDangXuLi = gvDangXuLi.GetRow(index) as DSDangXuLi;
                CallAPI.SoThuTu_HuyXuLy(dSDangXuLi.CLSYeuCau_Id);
                gvDangXuLi.DeleteRow(index);
            }
            this.LoadDSDangXuLi();
            this.LoadHangDoi();
            MessageBox.Show("Huy thanh cong!!");
        }

        private void btnDangXuLi_Click(object sender, EventArgs e)
        {
            int[] selectedRows = gvHangDoi.GetSelectedRows();
            foreach (int index in selectedRows)
            {
                DSBenhNhan dSBenhNhans = gvHangDoi.GetRow(index) as DSBenhNhan;
                CallAPI.SoThuTu_DangXuLy(dSBenhNhans.CLSYeuCau_Id);
                gvHangDoi.DeleteRow(index);
                this.LoadDSDangXuLi();
                MessageBox.Show("Thanh cong!!");
            }
            
        }

        private void btnUuTien_Click(object sender, EventArgs e)
        {
            int[] selectedRows = gvHangDoi.GetSelectedRows();
            int year = DateTime.Now.Year;
            foreach (int index in selectedRows)
            {
                DSBenhNhan dSBenhNhans = gvHangDoi.GetRow(index) as DSBenhNhan;
                CallAPI.SoThuTu_Uutien(dSBenhNhans.CLSYeuCau_Id);
                this.LoadHangDoi();
            }
            
        }

        private void btnCall_Click(object sender, EventArgs e)
        {
            
            if(XtraMessageBox.Show("Do you want to continue?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                
            }
            else
            {
                string tenbenhnhan =
                    ((DSBenhNhan)gvHangDoi.GetRow(gvHangDoi.GetSelectedRows()[0])).TenBenhNhan.ToString();
                string stt =
                ((DSBenhNhan)gvHangDoi.GetRow(gvHangDoi.GetSelectedRows()[0])).SoThuTu.ToString();
                string message = stt.Substring(stt.Length - 2);
                string thongbao = "Vui lòng bấm hủy gọi bệnh nhân " + tenbenhnhan + "\nSTT: " + stt + " trước khi gọi bệnh nhân khác";
                Terminal.frmMain a = new Terminal.frmMain(message);
                int[] selectedRows = gvHangDoi.GetSelectedRows();
                foreach (int index in selectedRows)
                {
                    DSBenhNhan dSBenhNhans = gvHangDoi.GetRow(index) as DSBenhNhan;
                    CallAPI.SoThuTu_Goi(dSBenhNhans.CLSYeuCau_Id);
                    this.LoadHangDoi();
                    gridColumn1.Visible = false;
                    MessageBox.Show(thongbao, "Thông báo");
                }

            }

        }

        private void gvHangDoi_RowStyle(object sender, RowStyleEventArgs e)
        {
            int year = DateTime.Now.Year;
            if(benhNhans.Count > 0)
            {
                for (int i = 0; i < benhNhans.Count; i++)
                {
                    if (year - benhNhans[i].NamYeuCau > 60 && benhNhans[i].TiepNhan_Id == "0" || benhNhans[i].TrangThai == "2" && benhNhans[i].TiepNhan_Id == "0")
                    {
                        if (e.RowHandle == i)
                        {
                            e.Appearance.ForeColor = Color.Blue;
                        }
                    }
                    else if (year - benhNhans[i].NamYeuCau > 60 && benhNhans[i].TiepNhan_Id == "1" || benhNhans[i].TrangThai == "2" && benhNhans[i].TiepNhan_Id == "1"|| benhNhans[i].TiepNhan_Id == "1")
                    {
                        if (e.RowHandle == i)
                        {
                            e.Appearance.ForeColor = Color.Red;
                        }
                    }
                }
            }
        }

    }
}
