using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QL_BanHang.Control;
using QL_BanHang.Obiect;

namespace QL_BanHang.View
{
    public partial class frmThongKe : Form
    {
        HoaDonCtr hdCtr = new HoaDonCtr();
        HoaDonObj hdObj = new HoaDonObj();
        public frmThongKe()
        {
            InitializeComponent();
        }
        private void addData(HoaDonObj hd)
        {
            hd.NgayLap = dpNgayBan.Text;
            hd.NguoiLap = cmbNhanVien.SelectedValue.ToString();
        }
        private void LoadcmbNhanVien()
        {
            NhanVienCtr nvctr = new NhanVienCtr();
            cmbNhanVien.DataSource = nvctr.GetData();
            cmbNhanVien.DisplayMember = "TenNV";
            cmbNhanVien.ValueMember = "MaNV";
        }
        private void frmThongKe_Load(object sender, EventArgs e)
        {
            DataTable dt = new System.Data.DataTable();
            dt = hdCtr.GetData();
            dtgvDSHD.DataSource = dt;
            LoadcmbNhanVien();
        }
        private void DSHD_Load(DataTable tbl, string count)
        {
            addData(hdObj);
            DataTable dt = new System.Data.DataTable();
            dt = tbl;
            dtgvDSHD.DataSource = dt;
            lblSoLuong.Text = count;
        }
        private void btnNgayBan_Click(object sender, EventArgs e)
        {
            DSHD_Load(hdCtr.GetData("select hd.MaHD, hd.NgayLap, nv.TenNV, kh.TenKH from tb_HoaDon hd, tb_KhachHang kh, tb_NhanVien nv where kh.MaKH = hd.KhachHang and nv.MaNV = hd.NguoiLap and hd.NguoiLap = " +"'" + hdObj.NguoiLap +"'"), hdCtr.CountData("select count(*) from tb_HoaDon AS hd where MaHD != '' and hd.NguoiLap = " + "'" + hdObj.NguoiLap + "'").ToString());
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            DSHD_Load(hdCtr.GetData("select hd.MaHD, hd.NgayLap, nv.TenNV, kh.TenKH from tb_HoaDon hd, tb_KhachHang kh, tb_NhanVien nv where kh.MaKH = hd.KhachHang and nv.MaNV = hd.NguoiLap and hd.NgayLap = CONVERT(DATE, '" + hdObj.NgayLap + "', 103)"), hdCtr.CountData("select count (*) from tb_HoaDon AS hd where MaHD != '' and hd.NgayLap = CONVERT(DATE, '" + hdObj.NgayLap + "', 103)").ToString());
            lblDoanhThu.Text = hdCtr.SumDoanhThu(hdObj).ToString();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DSHD_Load(hdCtr.GetData("select hd.MaHD, hd.NgayLap, nv.TenNV, kh.TenKH from tb_HoaDon hd, tb_KhachHang kh, tb_NhanVien nv where kh.MaKH = hd.KhachHang and nv.MaNV = hd.NguoiLap and hd.NguoiLap = " + "'" + hdObj.NguoiLap + "'"
                + "and hd.NgayLap = CONVERT(DATE, '" + hdObj.NgayLap + "', 103)"), hdCtr.CountData("select count (*) from tb_HoaDon AS hd where MaHD != '' and hd.NguoiLap = " + "'" + hdObj.NguoiLap + "' and hd.NgayLap = CONVERT(DATE, '" + hdObj.NgayLap + "', 103)").ToString());
        }
    }
}
