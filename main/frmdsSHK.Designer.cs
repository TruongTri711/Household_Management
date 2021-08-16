namespace main
{
    partial class frmdsSHK
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
            this.btndong = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvSHK = new System.Windows.Forms.DataGridView();
            this.MaSHK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtngaycap = new System.Windows.Forms.TextBox();
            this.txtmashk = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvtongSHK = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txttongSHK = new System.Windows.Forms.TextBox();
            this.btninreport = new System.Windows.Forms.Button();
            this.cbodiachi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSHK)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtongSHK)).BeginInit();
            this.SuspendLayout();
            // 
            // btndong
            // 
            this.btndong.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btndong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndong.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndong.Location = new System.Drawing.Point(699, 554);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(111, 36);
            this.btndong.TabIndex = 254;
            this.btndong.Text = "Đóng";
            this.btndong.UseVisualStyleBackColor = true;
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(240, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(455, 40);
            this.label4.TabIndex = 251;
            this.label4.Text = "DANH SÁCH SỔ HỘ KHẨU";
            // 
            // dgvSHK
            // 
            this.dgvSHK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSHK.BackgroundColor = System.Drawing.Color.White;
            this.dgvSHK.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvSHK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSHK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSHK,
            this.DiaChi,
            this.NgayCap});
            this.dgvSHK.Location = new System.Drawing.Point(23, 336);
            this.dgvSHK.Name = "dgvSHK";
            this.dgvSHK.Size = new System.Drawing.Size(941, 201);
            this.dgvSHK.TabIndex = 248;
            this.dgvSHK.Click += new System.EventHandler(this.dgvSHK_Click);
            // 
            // MaSHK
            // 
            this.MaSHK.DataPropertyName = "MaSHK";
            this.MaSHK.HeaderText = "Mã sổ hộ khẩu";
            this.MaSHK.Name = "MaSHK";
            this.MaSHK.ReadOnly = true;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            // 
            // NgayCap
            // 
            this.NgayCap.DataPropertyName = "NgayCap";
            this.NgayCap.HeaderText = "Ngày cấp";
            this.NgayCap.Name = "NgayCap";
            this.NgayCap.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.cbodiachi);
            this.groupBox2.Controls.Add(this.txtngaycap);
            this.groupBox2.Controls.Add(this.txtmashk);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.label28);
            this.groupBox2.Controls.Add(this.label33);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(406, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(558, 212);
            this.groupBox2.TabIndex = 250;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin sổ hộ khẩu";
            // 
            // txtngaycap
            // 
            this.txtngaycap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtngaycap.BackColor = System.Drawing.Color.White;
            this.txtngaycap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtngaycap.Location = new System.Drawing.Point(140, 154);
            this.txtngaycap.Name = "txtngaycap";
            this.txtngaycap.ReadOnly = true;
            this.txtngaycap.Size = new System.Drawing.Size(177, 26);
            this.txtngaycap.TabIndex = 5;
            // 
            // txtmashk
            // 
            this.txtmashk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtmashk.BackColor = System.Drawing.Color.White;
            this.txtmashk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmashk.Location = new System.Drawing.Point(140, 36);
            this.txtmashk.Name = "txtmashk";
            this.txtmashk.ReadOnly = true;
            this.txtmashk.Size = new System.Drawing.Size(177, 26);
            this.txtmashk.TabIndex = 3;
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(55, 160);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(79, 20);
            this.label22.TabIndex = 240;
            this.label22.Text = "Ngày cấp:";
            // 
            // label28
            // 
            this.label28.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(73, 103);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(61, 20);
            this.label28.TabIndex = 241;
            this.label28.Text = "Địa chỉ:";
            // 
            // label33
            // 
            this.label33.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(13, 42);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(121, 20);
            this.label33.TabIndex = 239;
            this.label33.Text = "Mã sổ hộ  khẩu:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.txttimkiem);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(18, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 86);
            this.groupBox1.TabIndex = 249;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // txttimkiem
            // 
            this.txttimkiem.BackColor = System.Drawing.Color.White;
            this.txttimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttimkiem.Location = new System.Drawing.Point(168, 36);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(140, 26);
            this.txttimkiem.TabIndex = 1;
            this.txttimkiem.TextChanged += new System.EventHandler(this.txttimkiem_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nhập mã sổ hộ khẩu:";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.dgvtongSHK);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.txttongSHK);
            this.panel4.Location = new System.Drawing.Point(23, 252);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(243, 78);
            this.panel4.TabIndex = 256;
            // 
            // dgvtongSHK
            // 
            this.dgvtongSHK.BackgroundColor = System.Drawing.Color.White;
            this.dgvtongSHK.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvtongSHK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtongSHK.Enabled = false;
            this.dgvtongSHK.Location = new System.Drawing.Point(55, 13);
            this.dgvtongSHK.Name = "dgvtongSHK";
            this.dgvtongSHK.Size = new System.Drawing.Size(68, 31);
            this.dgvtongSHK.TabIndex = 5;
            this.dgvtongSHK.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tổng số hộ:";
            // 
            // txttongSHK
            // 
            this.txttongSHK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txttongSHK.Enabled = false;
            this.txttongSHK.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttongSHK.Location = new System.Drawing.Point(140, 30);
            this.txttongSHK.Multiline = true;
            this.txttongSHK.Name = "txttongSHK";
            this.txttongSHK.Size = new System.Drawing.Size(67, 40);
            this.txttongSHK.TabIndex = 8;
            this.txttongSHK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btninreport
            // 
            this.btninreport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btninreport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninreport.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninreport.Location = new System.Drawing.Point(465, 554);
            this.btninreport.Name = "btninreport";
            this.btninreport.Size = new System.Drawing.Size(111, 36);
            this.btninreport.TabIndex = 257;
            this.btninreport.Text = "In Report";
            this.btninreport.UseVisualStyleBackColor = true;
            this.btninreport.Click += new System.EventHandler(this.btninreport_Click);
            // 
            // cbodiachi
            // 
            this.cbodiachi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbodiachi.BackColor = System.Drawing.Color.White;
            this.cbodiachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbodiachi.Location = new System.Drawing.Point(140, 97);
            this.cbodiachi.Name = "cbodiachi";
            this.cbodiachi.ReadOnly = true;
            this.cbodiachi.Size = new System.Drawing.Size(374, 26);
            this.cbodiachi.TabIndex = 242;
            // 
            // frmdsSHK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(987, 602);
            this.Controls.Add(this.btninreport);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvSHK);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmdsSHK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Danh sách sổ hộ khẩu";
            this.Load += new System.EventHandler(this.frmdsSHK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSHK)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtongSHK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btndong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvSHK;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSHK;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayCap;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtngaycap;
        private System.Windows.Forms.TextBox txtmashk;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvtongSHK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttongSHK;
        private System.Windows.Forms.Button btninreport;
        private System.Windows.Forms.TextBox cbodiachi;
    }
}