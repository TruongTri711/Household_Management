namespace main
{
    partial class frmSHK
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtngaycap = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txtmashk = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.btndong = new System.Windows.Forms.Button();
            this.dgvSHK = new System.Windows.Forms.DataGridView();
            this.MaSHK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSHK)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btntimkiem);
            this.groupBox1.Controls.Add(this.txttimkiem);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 128);
            this.groupBox1.TabIndex = 117;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(159, 100);
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
            this.groupBox2.Controls.Add(this.txtngaycap);
            this.groupBox2.Controls.Add(this.txtdiachi);
            this.groupBox2.Controls.Add(this.txtmashk);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.label28);
            this.groupBox2.Controls.Add(this.label33);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(452, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(565, 180);
            this.groupBox2.TabIndex = 233;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin";
            // 
            // txtngaycap
            // 
            this.txtngaycap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtngaycap.BackColor = System.Drawing.Color.White;
            this.txtngaycap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtngaycap.Location = new System.Drawing.Point(143, 129);
            this.txtngaycap.Name = "txtngaycap";
            this.txtngaycap.ReadOnly = true;
            this.txtngaycap.Size = new System.Drawing.Size(177, 26);
            this.txtngaycap.TabIndex = 244;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtdiachi.BackColor = System.Drawing.Color.White;
            this.txtdiachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiachi.Location = new System.Drawing.Point(143, 81);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.ReadOnly = true;
            this.txtdiachi.Size = new System.Drawing.Size(416, 26);
            this.txtdiachi.TabIndex = 243;
            // 
            // txtmashk
            // 
            this.txtmashk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtmashk.BackColor = System.Drawing.Color.White;
            this.txtmashk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmashk.Location = new System.Drawing.Point(143, 36);
            this.txtmashk.Name = "txtmashk";
            this.txtmashk.ReadOnly = true;
            this.txtmashk.Size = new System.Drawing.Size(177, 26);
            this.txtmashk.TabIndex = 242;
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(58, 135);
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
            this.label28.Location = new System.Drawing.Point(76, 87);
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
            this.label33.Location = new System.Drawing.Point(16, 42);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(121, 20);
            this.label33.TabIndex = 239;
            this.label33.Text = "Mã sổ hộ  khẩu:";
            // 
            // btndong
            // 
            this.btndong.BackColor = System.Drawing.Color.White;
            this.btndong.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btndong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndong.Location = new System.Drawing.Point(927, 506);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(90, 32);
            this.btndong.TabIndex = 3;
            this.btndong.Text = "Đóng";
            this.btndong.UseVisualStyleBackColor = false;
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // dgvSHK
            // 
            this.dgvSHK.BackgroundColor = System.Drawing.Color.White;
            this.dgvSHK.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvSHK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSHK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSHK,
            this.DiaChi,
            this.NgayCap});
            this.dgvSHK.Location = new System.Drawing.Point(12, 334);
            this.dgvSHK.Name = "dgvSHK";
            this.dgvSHK.Size = new System.Drawing.Size(1005, 148);
            this.dgvSHK.TabIndex = 235;
            this.dgvSHK.Click += new System.EventHandler(this.dgvSHK_Click);
            // 
            // MaSHK
            // 
            this.MaSHK.DataPropertyName = "MaSHK";
            this.MaSHK.HeaderText = "Mã sổ hộ khẩu";
            this.MaSHK.Name = "MaSHK";
            this.MaSHK.ReadOnly = true;
            this.MaSHK.Width = 200;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            this.DiaChi.Width = 560;
            // 
            // NgayCap
            // 
            this.NgayCap.DataPropertyName = "NgayCap";
            this.NgayCap.HeaderText = "Ngày cấp";
            this.NgayCap.Name = "NgayCap";
            this.NgayCap.ReadOnly = true;
            this.NgayCap.Width = 200;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(271, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(447, 40);
            this.label4.TabIndex = 236;
            this.label4.Text = "THÔNG TIN SỔ HỘ KHẨU";
            // 
            // frmSHK
            // 
            this.AcceptButton = this.btntimkiem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1029, 564);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvSHK);
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmSHK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sổ hộ khẩu";
            this.Load += new System.EventHandler(this.frmSHK_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSHK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtngaycap;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txtmashk;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Button btndong;
        private System.Windows.Forms.DataGridView dgvSHK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSHK;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayCap;
    }
}