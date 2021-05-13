
namespace QL_BanHang.View
{
    partial class frmDoiPass
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txb_Repeat = new System.Windows.Forms.TextBox();
            this.txb_NewPW = new System.Windows.Forms.TextBox();
            this.txb_OldPW = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Change = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txb_Repeat);
            this.panel1.Controls.Add(this.txb_NewPW);
            this.panel1.Controls.Add(this.txb_OldPW);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_Change);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 244);
            this.panel1.TabIndex = 7;
            // 
            // txb_Repeat
            // 
            this.txb_Repeat.Location = new System.Drawing.Point(160, 139);
            this.txb_Repeat.Margin = new System.Windows.Forms.Padding(2);
            this.txb_Repeat.Name = "txb_Repeat";
            this.txb_Repeat.Size = new System.Drawing.Size(140, 20);
            this.txb_Repeat.TabIndex = 3;
            this.txb_Repeat.UseSystemPasswordChar = true;
            // 
            // txb_NewPW
            // 
            this.txb_NewPW.Location = new System.Drawing.Point(160, 84);
            this.txb_NewPW.Margin = new System.Windows.Forms.Padding(2);
            this.txb_NewPW.Name = "txb_NewPW";
            this.txb_NewPW.Size = new System.Drawing.Size(140, 20);
            this.txb_NewPW.TabIndex = 2;
            this.txb_NewPW.UseSystemPasswordChar = true;
            // 
            // txb_OldPW
            // 
            this.txb_OldPW.Location = new System.Drawing.Point(160, 32);
            this.txb_OldPW.Margin = new System.Windows.Forms.Padding(2);
            this.txb_OldPW.Name = "txb_OldPW";
            this.txb_OldPW.Size = new System.Drawing.Size(140, 20);
            this.txb_OldPW.TabIndex = 1;
            this.txb_OldPW.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mật khẩu cũ:";
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(188, 195);
            this.btn_close.Margin = new System.Windows.Forms.Padding(2);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(56, 32);
            this.btn_close.TabIndex = 5;
            this.btn_close.Text = "Thoát";
            this.btn_close.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(7, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu mới:";
            // 
            // btn_Change
            // 
            this.btn_Change.Location = new System.Drawing.Point(90, 195);
            this.btn_Change.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Change.Name = "btn_Change";
            this.btn_Change.Size = new System.Drawing.Size(56, 32);
            this.btn_Change.TabIndex = 4;
            this.btn_Change.Text = "Đổi";
            this.btn_Change.UseVisualStyleBackColor = true;
            this.btn_Change.Click += new System.EventHandler(this.btn_Change_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(7, 139);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nhập lại mật khẩu:";
            // 
            // frmDoiPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 246);
            this.Controls.Add(this.panel1);
            this.Name = "frmDoiPass";
            this.Text = "frmDoiPass";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txb_Repeat;
        private System.Windows.Forms.TextBox txb_NewPW;
        private System.Windows.Forms.TextBox txb_OldPW;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Change;
        private System.Windows.Forms.Label label4;
    }
}