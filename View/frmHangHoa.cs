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
    public partial class frmHangHoa : Form
    {
        HangHoaCtr hhCtr = new HangHoaCtr();
        private int flagLuu = 0;
        string fileName;

        public frmHangHoa()
        {
            InitializeComponent();
        }

        private void frmHangHoa_Load(object sender, EventArgs e)
        {
            DataTable dtDS = new System.Data.DataTable();
            dtDS = hhCtr.GetData();
            dtgvDS.DataSource = dtDS;
            DisEnl(false);
        }
        private void dtgvDS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMa.DataBindings.Clear();
            txtMa.DataBindings.Add("Text", dtgvDS.DataSource, "MaHang");
            txtTen.DataBindings.Clear();
            txtTen.DataBindings.Add("Text", dtgvDS.DataSource, "TenHang");

            txtDonGia.DataBindings.Clear();
            txtDonGia.DataBindings.Add("Text", dtgvDS.DataSource, "DonGia");
            txtSL.DataBindings.Clear();
            txtSL.DataBindings.Add("Text", dtgvDS.DataSource, "SoLuong");
            txtAnh.DataBindings.Clear();
            txtAnh.DataBindings.Add("Text", dtgvDS.DataSource, "Anh");
            ShowAnh(txtAnh.Text.Trim());
        }

        private void clearData()
        {
            txtTen.Text = "";
            txtDonGia.Text = "";
            txtSL.Text = "";
            txtAnh.Text = "";
        }

        private void addData(HangHoaObj hh)
        {
            hh.MaHangHoa = hhCtr.MaHangHoa();
            hh.DonGia = int.Parse(txtDonGia.Text.Trim());
            hh.SoLuong = int.Parse(txtSL.Text.Trim());
            hh.TenHangHoa = txtTen.Text.Trim();
            hh.Anh = txtAnh.Text.Trim();
        }

        private void DisEnl(bool e)
        {
            btnThem.Enabled = !e;
            btnXoa.Enabled = !e;
            btnSua.Enabled = !e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            txtTen.Enabled = e;
            txtDonGia.Enabled = e;
            txtSL.Enabled = e;
            txtAnh.Enabled = e;
            btnNhapHang.Enabled = !e;
            btnMoAnh.Enabled = e;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMa.Text = hhCtr.MaHangHoa();
            flagLuu = 0;
            clearData();
            DisEnl(true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa hàng hoá này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (hhCtr.DelData(txtMa.Text.Trim()))
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Xóa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            frmHangHoa_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flagLuu = 1;
            DisEnl(true);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            HangHoaObj hhObj = new HangHoaObj();
            addData(hhObj);
            if (flagLuu == 0)
            {
                if (hhCtr.AddData(hhObj))
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Thêm không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (flagLuu == 1)
            {
                if (hhCtr.UpdData(hhObj))
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Sửa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (hhCtr.UpdData(hhObj))
                    MessageBox.Show("Nhập hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Nhập hàng không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            frmHangHoa_Load(sender, e);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                frmHangHoa_Load(sender, e);
            else
                return;
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            flagLuu = 2;
            btnNhapHang.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            txtSL.Enabled = true;
        }

        private void ShowAnh(string filename)
        {
            if (filename != "")
            {
                Image img = Image.FromFile(filename);
                picHang.Image = img;
            }
        }
        private void btnMoAnh_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string fileName;
                fileName = dlg.FileName;
                txtAnh.Text = fileName;
                ShowAnh(txtAnh.Text.Trim());
            }
        }

        private void btnMoAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                fileName = dlg.FileName;
                txtAnh.Text = fileName;
                ShowAnh(txtAnh.Text.Trim());
            }
        }
    }
}
