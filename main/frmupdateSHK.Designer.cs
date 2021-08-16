namespace main
{
    partial class frmupdateSHK
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
            this.dgvSHK = new System.Windows.Forms.DataGridView();
            this.MaSHK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbodiachi = new System.Windows.Forms.ComboBox();
            this.txtngaycap = new System.Windows.Forms.TextBox();
            this.txtmashk = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.pnchuky = new System.Windows.Forms.Panel();
            this.btnthoat = new System.Windows.Forms.Button();
            this.chkhienan = new System.Windows.Forms.CheckBox();
            this.btndangnhap = new System.Windows.Forms.Button();
            this.txtchuky = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btndong = new System.Windows.Forms.Button();
            this.btncapnhat = new System.Windows.Forms.Button();
            this.dgvupdateShk = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSHK)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.pnchuky.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvupdateShk)).BeginInit();
            this.SuspendLayout();
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
            this.dgvSHK.Location = new System.Drawing.Point(19, 376);
            this.dgvSHK.Name = "dgvSHK";
            this.dgvSHK.Size = new System.Drawing.Size(941, 145);
            this.dgvSHK.TabIndex = 6;
            this.dgvSHK.Click += new System.EventHandler(this.dgvupdateSHK_Click);
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btntimkiem);
            this.groupBox1.Controls.Add(this.txttimkiem);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(19, 184);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 128);
            this.groupBox1.TabIndex = 234;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(102, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Có thể bấm enter để tìm kiếm";
            // 
            // btntimkiem
            // 
            this.btntimkiem.BackColor = System.Drawing.Color.White;
            this.btntimkiem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btntimkiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntimkiem.Location = new System.Drawing.Point(162, 61);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(90, 29);
            this.btntimkiem.TabIndex = 2;
            this.btntimkiem.Text = "Tìm kiếm";
            this.btntimkiem.UseVisualStyleBackColor = false;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // txttimkiem
            // 
            this.txttimkiem.BackColor = System.Drawing.Color.White;
            this.txttimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttimkiem.Location = new System.Drawing.Point(162, 20);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(140, 26);
            this.txttimkiem.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nhập mã sổ hộ khẩu:";
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
            this.groupBox2.Location = new System.Drawing.Point(402, 157);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(558, 180);
            this.groupBox2.TabIndex = 235;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin sổ hộ khẩu";
            // 
            // cbodiachi
            // 
            this.cbodiachi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbodiachi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbodiachi.FormattingEnabled = true;
            this.cbodiachi.Items.AddRange(new object[] {
            "Ấp An Nghĩa, Xã An Thới Đông, Cần Giờ, TPHCM",
            "Ấp An Hòa, Xã An Thới Đông, Cần Giờ, TPHCM",
            "Ấp An Bình, Xã An Thới Đông, Cần Giờ, TPHCM",
            "Ấp Rạch Lá, Xã An Thới Đông, Cần Giờ, TPHCM"});
            this.cbodiachi.Location = new System.Drawing.Point(140, 80);
            this.cbodiachi.Name = "cbodiachi";
            this.cbodiachi.Size = new System.Drawing.Size(369, 27);
            this.cbodiachi.TabIndex = 242;
            // 
            // txtngaycap
            // 
            this.txtngaycap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtngaycap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtngaycap.Location = new System.Drawing.Point(140, 129);
            this.txtngaycap.Name = "txtngaycap";
            this.txtngaycap.Size = new System.Drawing.Size(177, 26);
            this.txtngaycap.TabIndex = 5;
            // 
            // txtmashk
            // 
            this.txtmashk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtmashk.Enabled = false;
            this.txtmashk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmashk.Location = new System.Drawing.Point(140, 36);
            this.txtmashk.Name = "txtmashk";
            this.txtmashk.Size = new System.Drawing.Size(177, 26);
            this.txtmashk.TabIndex = 3;
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(55, 135);
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
            this.label28.Location = new System.Drawing.Point(73, 87);
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
            // pnchuky
            // 
            this.pnchuky.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnchuky.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnchuky.Controls.Add(this.btnthoat);
            this.pnchuky.Controls.Add(this.chkhienan);
            this.pnchuky.Controls.Add(this.btndangnhap);
            this.pnchuky.Controls.Add(this.txtchuky);
            this.pnchuky.Controls.Add(this.label2);
            this.pnchuky.Location = new System.Drawing.Point(267, 138);
            this.pnchuky.Name = "pnchuky";
            this.pnchuky.Size = new System.Drawing.Size(393, 232);
            this.pnchuky.TabIndex = 244;
            // 
            // btnthoat
            // 
            this.btnthoat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnthoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnthoat.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.Location = new System.Drawing.Point(206, 158);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(106, 36);
            this.btnthoat.TabIndex = 4;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // chkhienan
            // 
            this.chkhienan.AutoSize = true;
            this.chkhienan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkhienan.Location = new System.Drawing.Point(88, 117);
            this.chkhienan.Name = "chkhienan";
            this.chkhienan.Size = new System.Drawing.Size(145, 23);
            this.chkhienan.TabIndex = 3;
            this.chkhienan.Text = "Hiện / Ẩn mật khẩu";
            this.chkhienan.UseVisualStyleBackColor = true;
            this.chkhienan.CheckedChanged += new System.EventHandler(this.chkhienan_CheckedChanged);
            // 
            // btndangnhap
            // 
            this.btndangnhap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btndangnhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndangnhap.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndangnhap.Location = new System.Drawing.Point(88, 158);
            this.btndangnhap.Name = "btndangnhap";
            this.btndangnhap.Size = new System.Drawing.Size(106, 36);
            this.btndangnhap.TabIndex = 2;
            this.btndangnhap.Text = "Xác nhận";
            this.btndangnhap.UseVisualStyleBackColor = true;
            this.btndangnhap.Click += new System.EventHandler(this.btndangnhap_Click);
            // 
            // txtchuky
            // 
            this.txtchuky.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtchuky.Location = new System.Drawing.Point(88, 80);
            this.txtchuky.Name = "txtchuky";
            this.txtchuky.Size = new System.Drawing.Size(224, 26);
            this.txtchuky.TabIndex = 1;
            this.txtchuky.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(23, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(358, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cần có chữ ký của chủ tịch xã để xác nhận";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(260, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(426, 40);
            this.label4.TabIndex = 239;
            this.label4.Text = "CẬP NHẬT SỔ HỘ KHẨU";
            // 
            // btndong
            // 
            this.btndong.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btndong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndong.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndong.Location = new System.Drawing.Point(598, 544);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(111, 36);
            this.btndong.TabIndex = 246;
            this.btndong.Text = "Đóng";
            this.btndong.UseVisualStyleBackColor = true;
            this.btndong.Click += new System.EventHandler(this.btndong_Click_1);
            // 
            // btncapnhat
            // 
            this.btncapnhat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btncapnhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncapnhat.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncapnhat.Location = new System.Drawing.Point(326, 544);
            this.btncapnhat.Name = "btncapnhat";
            this.btncapnhat.Size = new System.Drawing.Size(111, 36);
            this.btncapnhat.TabIndex = 245;
            this.btncapnhat.Text = "Cập nhật";
            this.btncapnhat.UseVisualStyleBackColor = true;
            this.btncapnhat.Click += new System.EventHandler(this.btncapnhat_Click_1);
            // 
            // dgvupdateShk
            // 
            this.dgvupdateShk.BackgroundColor = System.Drawing.Color.White;
            this.dgvupdateShk.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvupdateShk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvupdateShk.Location = new System.Drawing.Point(191, 544);
            this.dgvupdateShk.Name = "dgvupdateShk";
            this.dgvupdateShk.Size = new System.Drawing.Size(80, 36);
            this.dgvupdateShk.TabIndex = 247;
            // 
            // frmupdateSHK
            // 
            this.AcceptButton = this.btntimkiem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(987, 603);
            this.Controls.Add(this.dgvupdateShk);
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.btncapnhat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvSHK);
            this.Controls.Add(this.pnchuky);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmupdateSHK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cập nhật sổ hộ khẩu";
            this.Load += new System.EventHandler(this.frmupdateSHK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSHK)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.pnchuky.ResumeLayout(false);
            this.pnchuky.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvupdateShk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvSHK;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSHK;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayCap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtngaycap;
        private System.Windows.Forms.TextBox txtmashk;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Panel pnchuky;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.CheckBox chkhienan;
        private System.Windows.Forms.Button btndangnhap;
        private System.Windows.Forms.TextBox txtchuky;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btndong;
        private System.Windows.Forms.Button btncapnhat;
        private System.Windows.Forms.ComboBox cbodiachi;
        private System.Windows.Forms.DataGridView dgvupdateShk;
    }
}