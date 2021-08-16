namespace main
{
    partial class frmdsCMND
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
            this.dgvCMND = new System.Windows.Forms.DataGridView();
            this.CMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NguyenQuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoiCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtngaycap = new System.Windows.Forms.TextBox();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.txtnoicap = new System.Windows.Forms.TextBox();
            this.txtnamsinh = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtmaso = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtnguyenquan = new System.Windows.Forms.TextBox();
            this.grbtimkiem = new System.Windows.Forms.GroupBox();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvtongCMND = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txttongCMND = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btndong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCMND)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grbtimkiem.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtongCMND)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCMND
            // 
            this.dgvCMND.BackgroundColor = System.Drawing.Color.White;
            this.dgvCMND.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCMND.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCMND.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CMND,
            this.HoTen,
            this.NamSinh,
            this.NguyenQuan,
            this.NoiCap,
            this.NgayCap});
            this.dgvCMND.Location = new System.Drawing.Point(12, 447);
            this.dgvCMND.Name = "dgvCMND";
            this.dgvCMND.Size = new System.Drawing.Size(1054, 257);
            this.dgvCMND.TabIndex = 0;
            this.dgvCMND.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCMND_CellContentClick);
            this.dgvCMND.Click += new System.EventHandler(this.dgvCMND_Click);
            // 
            // CMND
            // 
            this.CMND.DataPropertyName = "CMND";
            this.CMND.HeaderText = "Mã số";
            this.CMND.Name = "CMND";
            this.CMND.ReadOnly = true;
            this.CMND.Width = 130;
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "Họ tên";
            this.HoTen.Name = "HoTen";
            this.HoTen.ReadOnly = true;
            this.HoTen.Width = 200;
            // 
            // NamSinh
            // 
            this.NamSinh.DataPropertyName = "NamSinh";
            this.NamSinh.HeaderText = "Năm sinh";
            this.NamSinh.Name = "NamSinh";
            this.NamSinh.ReadOnly = true;
            this.NamSinh.Width = 133;
            // 
            // NguyenQuan
            // 
            this.NguyenQuan.DataPropertyName = "NguyenQuan";
            this.NguyenQuan.HeaderText = "Nguyên quán";
            this.NguyenQuan.Name = "NguyenQuan";
            this.NguyenQuan.ReadOnly = true;
            this.NguyenQuan.Width = 150;
            // 
            // NoiCap
            // 
            this.NoiCap.DataPropertyName = "NoiCap";
            this.NoiCap.HeaderText = "Nơi cấp";
            this.NoiCap.Name = "NoiCap";
            this.NoiCap.ReadOnly = true;
            this.NoiCap.Width = 250;
            // 
            // NgayCap
            // 
            this.NgayCap.DataPropertyName = "NgayCap";
            this.NgayCap.HeaderText = "Ngày cấp";
            this.NgayCap.Name = "NgayCap";
            this.NgayCap.ReadOnly = true;
            this.NgayCap.Width = 130;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtngaycap);
            this.groupBox1.Controls.Add(this.txthoten);
            this.groupBox1.Controls.Add(this.txtnoicap);
            this.groupBox1.Controls.Add(this.txtnamsinh);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtmaso);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.txtnguyenquan);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(473, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(593, 326);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chứng minh nhân dân";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(60, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 68;
            this.label4.Text = "Ngày cấp:";
            // 
            // txtngaycap
            // 
            this.txtngaycap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtngaycap.BackColor = System.Drawing.Color.White;
            this.txtngaycap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtngaycap.Location = new System.Drawing.Point(156, 267);
            this.txtngaycap.Name = "txtngaycap";
            this.txtngaycap.ReadOnly = true;
            this.txtngaycap.Size = new System.Drawing.Size(177, 26);
            this.txtngaycap.TabIndex = 67;
            // 
            // txthoten
            // 
            this.txthoten.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txthoten.BackColor = System.Drawing.Color.White;
            this.txthoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthoten.Location = new System.Drawing.Point(156, 88);
            this.txthoten.Name = "txthoten";
            this.txthoten.ReadOnly = true;
            this.txthoten.Size = new System.Drawing.Size(177, 26);
            this.txthoten.TabIndex = 66;
            // 
            // txtnoicap
            // 
            this.txtnoicap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtnoicap.BackColor = System.Drawing.Color.White;
            this.txtnoicap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnoicap.Location = new System.Drawing.Point(156, 223);
            this.txtnoicap.Name = "txtnoicap";
            this.txtnoicap.ReadOnly = true;
            this.txtnoicap.Size = new System.Drawing.Size(391, 26);
            this.txtnoicap.TabIndex = 65;
            // 
            // txtnamsinh
            // 
            this.txtnamsinh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtnamsinh.BackColor = System.Drawing.Color.White;
            this.txtnamsinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnamsinh.Location = new System.Drawing.Point(156, 130);
            this.txtnamsinh.Name = "txtnamsinh";
            this.txtnamsinh.ReadOnly = true;
            this.txtnamsinh.Size = new System.Drawing.Size(177, 26);
            this.txtnamsinh.TabIndex = 59;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(73, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 20);
            this.label6.TabIndex = 62;
            this.label6.Text = "Nơi cấp:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 63;
            this.label5.Text = "Nguyên quán:";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(60, 136);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 20);
            this.label12.TabIndex = 64;
            this.label12.Text = "Năm sinh:";
            // 
            // txtmaso
            // 
            this.txtmaso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtmaso.BackColor = System.Drawing.Color.White;
            this.txtmaso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmaso.Location = new System.Drawing.Point(156, 45);
            this.txtmaso.Name = "txtmaso";
            this.txtmaso.ReadOnly = true;
            this.txtmaso.Size = new System.Drawing.Size(177, 26);
            this.txtmaso.TabIndex = 58;
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(83, 51);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(56, 20);
            this.label18.TabIndex = 57;
            this.label18.Text = "Mã số:";
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(78, 94);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(61, 20);
            this.label20.TabIndex = 61;
            this.label20.Text = "Họ tên:";
            // 
            // txtnguyenquan
            // 
            this.txtnguyenquan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtnguyenquan.BackColor = System.Drawing.Color.White;
            this.txtnguyenquan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnguyenquan.Location = new System.Drawing.Point(156, 177);
            this.txtnguyenquan.Name = "txtnguyenquan";
            this.txtnguyenquan.ReadOnly = true;
            this.txtnguyenquan.Size = new System.Drawing.Size(177, 26);
            this.txtnguyenquan.TabIndex = 60;
            // 
            // grbtimkiem
            // 
            this.grbtimkiem.BackColor = System.Drawing.Color.White;
            this.grbtimkiem.Controls.Add(this.txttimkiem);
            this.grbtimkiem.Controls.Add(this.label2);
            this.grbtimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbtimkiem.Location = new System.Drawing.Point(12, 180);
            this.grbtimkiem.Name = "grbtimkiem";
            this.grbtimkiem.Size = new System.Drawing.Size(291, 85);
            this.grbtimkiem.TabIndex = 31;
            this.grbtimkiem.TabStop = false;
            this.grbtimkiem.Text = "Tìm Kiếm";
            // 
            // txttimkiem
            // 
            this.txttimkiem.BackColor = System.Drawing.Color.White;
            this.txttimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttimkiem.Location = new System.Drawing.Point(117, 33);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(140, 26);
            this.txttimkiem.TabIndex = 1;
            this.txttimkiem.TextChanged += new System.EventHandler(this.txttimkiem_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhập họ tên:";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.dgvtongCMND);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.txttongCMND);
            this.panel4.Location = new System.Drawing.Point(12, 334);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(291, 85);
            this.panel4.TabIndex = 32;
            // 
            // dgvtongCMND
            // 
            this.dgvtongCMND.BackgroundColor = System.Drawing.Color.White;
            this.dgvtongCMND.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvtongCMND.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtongCMND.Enabled = false;
            this.dgvtongCMND.Location = new System.Drawing.Point(86, 12);
            this.dgvtongCMND.Name = "dgvtongCMND";
            this.dgvtongCMND.Size = new System.Drawing.Size(68, 31);
            this.dgvtongCMND.TabIndex = 5;
            this.dgvtongCMND.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tổng số CMND:";
            // 
            // txttongCMND
            // 
            this.txttongCMND.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txttongCMND.Enabled = false;
            this.txttongCMND.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttongCMND.Location = new System.Drawing.Point(178, 29);
            this.txttongCMND.Multiline = true;
            this.txttongCMND.Name = "txttongCMND";
            this.txttongCMND.Size = new System.Drawing.Size(67, 40);
            this.txttongCMND.TabIndex = 8;
            this.txttongCMND.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(107, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(860, 40);
            this.label3.TabIndex = 33;
            this.label3.Text = "DANH SÁCH NGƯỜI CÓ CHỨNG MINH NHÂN DÂN";
            // 
            // btndong
            // 
            this.btndong.BackColor = System.Drawing.Color.White;
            this.btndong.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btndong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndong.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndong.Location = new System.Drawing.Point(960, 726);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(106, 34);
            this.btndong.TabIndex = 34;
            this.btndong.Text = "Đóng";
            this.btndong.UseVisualStyleBackColor = false;
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // frmdsCMND
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1088, 782);
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.grbtimkiem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvCMND);
            this.Name = "frmdsCMND";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Danh sách chứng minh nhân dân";
            this.Load += new System.EventHandler(this.frmdsCMND_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCMND)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbtimkiem.ResumeLayout(false);
            this.grbtimkiem.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtongCMND)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCMND;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.TextBox txtnoicap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtmaso;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtnguyenquan;
        private System.Windows.Forms.GroupBox grbtimkiem;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvtongCMND;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttongCMND;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtngaycap;
        private System.Windows.Forms.TextBox txtnamsinh;
        private System.Windows.Forms.Button btndong;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NguyenQuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoiCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayCap;
    }
}