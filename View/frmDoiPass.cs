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
    public partial class frmDoiPass : Form
    {
        public frmDoiPass()
        {
            InitializeComponent();
        }
        string username;
        public frmDoiPass(string _username)
        {
            username = _username;
            InitializeComponent();
        }
        NhanVienCtr nvCtr = new NhanVienCtr();
        private void btn_Change_Click(object sender, EventArgs e)
        {
            NhanVienObj nvObj = new NhanVienObj();
            DataTable dt = nvCtr.GetPass(username);
            if (txb_OldPW.Text == dt.Rows[0]["MatKhau"].ToString())
            {
                if (txb_Repeat.Text == txb_NewPW.Text)
                {
                    nvObj.MaNhanVien = username;
                    nvObj.MatKhau = txb_NewPW.Text;
                    if (nvCtr.DoiPass(nvObj))
                    {
                        MessageBox.Show("Đã đổi mật khẩu thành công!", "Thông báo");
                    }
                    else
                    {
                        MessageBox.Show("Đã có lỗi xảy ra, xin thử lại sau.", "Thông báo lỗi",
                               MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra, xin thử lại sau.", "Thông báo lỗi",
                                       MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
