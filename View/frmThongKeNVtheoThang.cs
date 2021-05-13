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
    public partial class frmThongKeNVtheoThang : Form
    {
        ChiTietCtr ctCtr = new ChiTietCtr();
        public frmThongKeNVtheoThang()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string thang = dt.Value.Month.ToString();
            string nam = dt.Value.Year.ToString();
            DataTable dtDS = new System.Data.DataTable();
            dtDS = ctCtr.ThongKeNhanVien(thang, nam);
            dtHH.DataSource = dtDS;
        }

    }
}
