namespace QL_BanHang.View
{
    partial class frmHoaDon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtgvDSHD = new System.Windows.Forms.DataGridView();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbNhanVien = new System.Windows.Forms.ComboBox();
            this.dpNgayLap = new System.Windows.Forms.DateTimePicker();
            this.cmbKhachHang = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbGiamGia = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dtgvDSHH = new System.Windows.Forms.DataGridView();
            this.MaHD1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HangHoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbHH = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBot = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lbThanhTien = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSHD)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSHH)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvDSHD
            // 
            this.dtgvDSHD.AllowUserToAddRows = false;
            this.dtgvDSHD.AllowUserToDeleteRows = false;
            this.dtgvDSHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDSHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDSHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHD,
            this.TenKH,
            this.TenNV,
            this.NgayLap});
            this.dtgvDSHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvDSHD.Location = new System.Drawing.Point(3, 22);
            this.dtgvDSHD.Name = "dtgvDSHD";
            this.dtgvDSHD.ReadOnly = true;
            this.dtgvDSHD.Size = new System.Drawing.Size(616, 199);
            this.dtgvDSHD.TabIndex = 0;
            this.dtgvDSHD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDSHD_CellClick);
            // 
            // MaHD
            // 
            this.MaHD.DataPropertyName = "MaHD";
            this.MaHD.HeaderText = "Mã Hoá Đơn";
            this.MaHD.Name = "MaHD";
            this.MaHD.ReadOnly = true;
            // 
            // TenKH
            // 
            this.TenKH.DataPropertyName = "TenKH";
            this.TenKH.HeaderText = "Tên Khách Hàng";
            this.TenKH.Name = "TenKH";
            this.TenKH.ReadOnly = true;
            // 
            // TenNV
            // 
            this.TenNV.DataPropertyName = "TenNV";
            this.TenNV.HeaderText = "Tên Nhân Viên";
            this.TenNV.Name = "TenNV";
            this.TenNV.ReadOnly = true;
            // 
            // NgayLap
            // 
            this.NgayLap.DataPropertyName = "NgayLap";
            this.NgayLap.HeaderText = "Ngày Lập";
            this.NgayLap.Name = "NgayLap";
            this.NgayLap.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cmbNhanVien);
            this.groupBox1.Controls.Add(this.dpNgayLap);
            this.groupBox1.Controls.Add(this.cmbKhachHang);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMa);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(622, 123);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hóa đơn";
            // 
            // cmbNhanVien
            // 
            this.cmbNhanVien.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbNhanVien.FormattingEnabled = true;
            this.cmbNhanVien.Location = new System.Drawing.Point(398, 31);
            this.cmbNhanVien.Name = "cmbNhanVien";
            this.cmbNhanVien.Size = new System.Drawing.Size(173, 27);
            this.cmbNhanVien.TabIndex = 2;
            // 
            // dpNgayLap
            // 
            this.dpNgayLap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dpNgayLap.CustomFormat = "dd/MM/yyyy";
            this.dpNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpNgayLap.Location = new System.Drawing.Point(141, 70);
            this.dpNgayLap.Name = "dpNgayLap";
            this.dpNgayLap.Size = new System.Drawing.Size(130, 26);
            this.dpNgayLap.TabIndex = 3;
            // 
            // cmbKhachHang
            // 
            this.cmbKhachHang.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbKhachHang.FormattingEnabled = true;
            this.cmbKhachHang.Location = new System.Drawing.Point(398, 73);
            this.cmbKhachHang.Name = "cmbKhachHang";
            this.cmbKhachHang.Size = new System.Drawing.Size(173, 27);
            this.cmbKhachHang.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(277, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Khách hàng (*)";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(277, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nhân viên lập (*)";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày lập (*)";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã hóa đơn (*)";
            // 
            // txtMa
            // 
            this.txtMa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMa.Location = new System.Drawing.Point(141, 31);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(130, 26);
            this.txtMa.TabIndex = 1;
            this.txtMa.TextChanged += new System.EventHandler(this.txtMa_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dtgvDSHD);
            this.groupBox2.Location = new System.Drawing.Point(12, 205);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(622, 224);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách hóa đơn";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(93, 141);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 58);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Tạo";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.btnDel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Location = new System.Drawing.Point(190, 141);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 58);
            this.btnDel.TabIndex = 2;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Location = new System.Drawing.Point(287, 141);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 58);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "In";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.lbGiamGia);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.cmbHH);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.btnBot);
            this.groupBox3.Controls.Add(this.btnThem);
            this.groupBox3.Controls.Add(this.txtSL);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtDonGia);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.lbThanhTien);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(640, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(539, 414);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi tiết hóa đơn";
            // 
            // lbGiamGia
            // 
            this.lbGiamGia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbGiamGia.AutoSize = true;
            this.lbGiamGia.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGiamGia.ForeColor = System.Drawing.Color.Blue;
            this.lbGiamGia.Location = new System.Drawing.Point(416, 95);
            this.lbGiamGia.Name = "lbGiamGia";
            this.lbGiamGia.Size = new System.Drawing.Size(20, 22);
            this.lbGiamGia.TabIndex = 6;
            this.lbGiamGia.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(328, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 19);
            this.label10.TabIndex = 4;
            this.label10.Text = "Giảm giá";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.groupBox4.Controls.Add(this.dtgvDSHH);
            this.groupBox4.Location = new System.Drawing.Point(6, 193);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(527, 215);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách hàng hóa";
            // 
            // dtgvDSHH
            // 
            this.dtgvDSHH.AllowUserToAddRows = false;
            this.dtgvDSHH.AllowUserToDeleteRows = false;
            this.dtgvDSHH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDSHH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDSHH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHD1,
            this.HangHoa,
            this.SoLuong,
            this.DonGia,
            this.ThanhTien});
            this.dtgvDSHH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvDSHH.Location = new System.Drawing.Point(3, 22);
            this.dtgvDSHH.Name = "dtgvDSHH";
            this.dtgvDSHH.ReadOnly = true;
            this.dtgvDSHH.Size = new System.Drawing.Size(521, 190);
            this.dtgvDSHH.TabIndex = 0;
            this.dtgvDSHH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDSHH_CellClick);
            // 
            // MaHD1
            // 
            this.MaHD1.DataPropertyName = "MaHD";
            this.MaHD1.HeaderText = "Mã Hoá Đơn";
            this.MaHD1.Name = "MaHD1";
            this.MaHD1.ReadOnly = true;
            // 
            // HangHoa
            // 
            this.HangHoa.DataPropertyName = "HangHoa";
            this.HangHoa.HeaderText = "Hàng Hoá";
            this.HangHoa.Name = "HangHoa";
            this.HangHoa.ReadOnly = true;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn Giá";
            this.DonGia.Name = "DonGia";
            this.DonGia.ReadOnly = true;
            // 
            // ThanhTien
            // 
            this.ThanhTien.DataPropertyName = "ThanhTien";
            this.ThanhTien.HeaderText = "Thành Tiền";
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.ReadOnly = true;
            // 
            // cmbHH
            // 
            this.cmbHH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbHH.FormattingEnabled = true;
            this.cmbHH.Location = new System.Drawing.Point(146, 25);
            this.cmbHH.Name = "cmbHH";
            this.cmbHH.Size = new System.Drawing.Size(309, 27);
            this.cmbHH.TabIndex = 5;
            this.cmbHH.SelectedIndexChanged += new System.EventHandler(this.cmbHH_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Hàng hóa (*)";
            // 
            // btnBot
            // 
            this.btnBot.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBot.Location = new System.Drawing.Point(300, 129);
            this.btnBot.Name = "btnBot";
            this.btnBot.Size = new System.Drawing.Size(75, 58);
            this.btnBot.TabIndex = 2;
            this.btnBot.Text = "Bớt";
            this.btnBot.UseVisualStyleBackColor = true;
            this.btnBot.Click += new System.EventHandler(this.btnBot_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Location = new System.Drawing.Point(211, 129);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 58);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtSL
            // 
            this.txtSL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSL.Location = new System.Drawing.Point(420, 61);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(35, 26);
            this.txtSL.TabIndex = 6;
            this.txtSL.Text = "1";
            this.txtSL.TextChanged += new System.EventHandler(this.txtSL_TextChanged);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(328, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 19);
            this.label7.TabIndex = 1;
            this.label7.Text = "Số lượng (*)";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDonGia.Enabled = false;
            this.txtDonGia.Location = new System.Drawing.Point(146, 58);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(117, 26);
            this.txtDonGia.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(269, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 19);
            this.label8.TabIndex = 1;
            this.label8.Text = "(VNĐ)";
            // 
            // lbThanhTien
            // 
            this.lbThanhTien.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbThanhTien.AutoSize = true;
            this.lbThanhTien.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThanhTien.ForeColor = System.Drawing.Color.Blue;
            this.lbThanhTien.Location = new System.Drawing.Point(142, 95);
            this.lbThanhTien.Name = "lbThanhTien";
            this.lbThanhTien.Size = new System.Drawing.Size(20, 22);
            this.lbThanhTien.TabIndex = 1;
            this.lbThanhTien.Text = "0";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(58, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 19);
            this.label9.TabIndex = 1;
            this.label9.Text = "Thành tiền";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 19);
            this.label6.TabIndex = 1;
            this.label6.Text = "Đơn giá (*) ";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(384, 141);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 58);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(481, 141);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 58);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 441);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmHoaDon";
            this.Text = "frmHoaDon";
            this.Load += new System.EventHandler(this.frmHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSHD)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSHH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvDSHD;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbKhachHang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dtgvDSHH;
        private System.Windows.Forms.ComboBox cmbHH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBot;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbThanhTien;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dpNgayLap;
        private System.Windows.Forms.ComboBox cmbNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD1;
        private System.Windows.Forms.DataGridViewTextBoxColumn HangHoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.Label lbGiamGia;
        private System.Windows.Forms.Label label10;
    }
}