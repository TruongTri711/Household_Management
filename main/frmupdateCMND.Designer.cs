namespace main
{
    partial class frmupdateCMND
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
            this.label3 = new System.Windows.Forms.Label();
            this.dgvupdateCMND = new System.Windows.Forms.DataGridView();
            this.CMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NguyenQuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoiCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpngaycap = new System.Windows.Forms.TextBox();
            this.dtpnamsinh = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.txtnoicap = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtmaso = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtnguyenquan = new System.Windows.Forms.TextBox();
            this.grbtimkiem = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnfindmashk = new System.Windows.Forms.Button();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btndong = new System.Windows.Forms.Button();
            this.btncapnhat = new System.Windows.Forms.Button();
            this.pnchuky = new System.Windows.Forms.Panel();
            this.btnthoat = new System.Windows.Forms.Button();
            this.chkhienan = new System.Windows.Forms.CheckBox();
            this.btndangnhap = new System.Windows.Forms.Button();
            this.txtchuky = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvupdateCMND)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grbtimkiem.SuspendLayout();
            this.pnchuky.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(160, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(640, 40);
            this.label3.TabIndex = 34;
            this.label3.Text = "CẬP NHẬT CHỨNG MINH NHÂN DÂN";
            // 
            // dgvupdateCMND
            // 
            this.dgvupdateCMND.BackgroundColor = System.Drawing.Color.White;
            this.dgvupdateCMND.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvupdateCMND.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvupdateCMND.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CMND,
            this.HoTen,
            this.NamSinh,
            this.NguyenQuan,
            this.NoiCap,
            this.NgayCap});
            this.dgvupdateCMND.Location = new System.Drawing.Point(12, 449);
            this.dgvupdateCMND.Name = "dgvupdateCMND";
            this.dgvupdateCMND.Size = new System.Drawing.Size(968, 212);
            this.dgvupdateCMND.TabIndex = 35;
            this.dgvupdateCMND.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvupdateCMND_CellContentClick);
            this.dgvupdateCMND.Click += new System.EventHandler(this.dgvupdateCMND_Click);
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
            this.HoTen.Width = 150;
            // 
            // NamSinh
            // 
            this.NamSinh.DataPropertyName = "NamSinh";
            this.NamSinh.HeaderText = "Năm sinh";
            this.NamSinh.Name = "NamSinh";
            this.NamSinh.ReadOnly = true;
            this.NamSinh.Width = 130;
            // 
            // NguyenQuan
            // 
            this.NguyenQuan.DataPropertyName = "NguyenQuan";
            this.NguyenQuan.HeaderText = "Nguyên quán";
            this.NguyenQuan.Name = "NguyenQuan";
            this.NguyenQuan.ReadOnly = true;
            this.NguyenQuan.Width = 130;
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
            this.groupBox1.Controls.Add(this.dtpngaycap);
            this.groupBox1.Controls.Add(this.dtpnamsinh);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txthoten);
            this.groupBox1.Controls.Add(this.txtnoicap);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtmaso);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.txtnguyenquan);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(402, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(578, 326);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chứng minh nhân dân";
            // 
            // dtpngaycap
            // 
            this.dtpngaycap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dtpngaycap.BackColor = System.Drawing.Color.White;
            this.dtpngaycap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpngaycap.Location = new System.Drawing.Point(149, 260);
            this.dtpngaycap.Name = "dtpngaycap";
            this.dtpngaycap.Size = new System.Drawing.Size(177, 26);
            this.dtpngaycap.TabIndex = 72;
            // 
            // dtpnamsinh
            // 
            this.dtpnamsinh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dtpnamsinh.BackColor = System.Drawing.Color.White;
            this.dtpnamsinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpnamsinh.Location = new System.Drawing.Point(149, 124);
            this.dtpnamsinh.Name = "dtpnamsinh";
            this.dtpnamsinh.ReadOnly = true;
            this.dtpnamsinh.Size = new System.Drawing.Size(177, 26);
            this.dtpnamsinh.TabIndex = 71;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(53, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 68;
            this.label4.Text = "Ngày cấp:";
            // 
            // txthoten
            // 
            this.txthoten.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txthoten.BackColor = System.Drawing.Color.White;
            this.txthoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthoten.Location = new System.Drawing.Point(149, 81);
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
            this.txtnoicap.Location = new System.Drawing.Point(149, 216);
            this.txtnoicap.Name = "txtnoicap";
            this.txtnoicap.Size = new System.Drawing.Size(378, 26);
            this.txtnoicap.TabIndex = 65;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(66, 222);
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
            this.label5.Location = new System.Drawing.Point(25, 176);
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
            this.label12.Location = new System.Drawing.Point(53, 129);
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
            this.txtmaso.Location = new System.Drawing.Point(149, 38);
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
            this.label18.Location = new System.Drawing.Point(76, 44);
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
            this.label20.Location = new System.Drawing.Point(71, 87);
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
            this.txtnguyenquan.Location = new System.Drawing.Point(149, 170);
            this.txtnguyenquan.Name = "txtnguyenquan";
            this.txtnguyenquan.Size = new System.Drawing.Size(177, 26);
            this.txtnguyenquan.TabIndex = 60;
            // 
            // grbtimkiem
            // 
            this.grbtimkiem.BackColor = System.Drawing.Color.White;
            this.grbtimkiem.Controls.Add(this.label7);
            this.grbtimkiem.Controls.Add(this.btnfindmashk);
            this.grbtimkiem.Controls.Add(this.txttimkiem);
            this.grbtimkiem.Controls.Add(this.label2);
            this.grbtimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbtimkiem.Location = new System.Drawing.Point(12, 228);
            this.grbtimkiem.Name = "grbtimkiem";
            this.grbtimkiem.Size = new System.Drawing.Size(304, 131);
            this.grbtimkiem.TabIndex = 37;
            this.grbtimkiem.TabStop = false;
            this.grbtimkiem.Text = "Tìm Kiếm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(86, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(182, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Có thể nhấn enter để tìm kiếm";
            // 
            // btnfindmashk
            // 
            this.btnfindmashk.BackColor = System.Drawing.Color.White;
            this.btnfindmashk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnfindmashk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfindmashk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfindmashk.Location = new System.Drawing.Point(145, 70);
            this.btnfindmashk.Name = "btnfindmashk";
            this.btnfindmashk.Size = new System.Drawing.Size(90, 29);
            this.btnfindmashk.TabIndex = 13;
            this.btnfindmashk.Text = "Tìm kiếm";
            this.btnfindmashk.UseVisualStyleBackColor = false;
            this.btnfindmashk.Click += new System.EventHandler(this.btnfindmashk_Click);
            // 
            // txttimkiem
            // 
            this.txttimkiem.BackColor = System.Drawing.Color.White;
            this.txttimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttimkiem.Location = new System.Drawing.Point(145, 33);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(140, 26);
            this.txttimkiem.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhập mã CMND:";
            // 
            // btndong
            // 
            this.btndong.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btndong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndong.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndong.Location = new System.Drawing.Point(617, 684);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(111, 36);
            this.btndong.TabIndex = 39;
            this.btndong.Text = "Đóng";
            this.btndong.UseVisualStyleBackColor = true;
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // btncapnhat
            // 
            this.btncapnhat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btncapnhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncapnhat.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncapnhat.Location = new System.Drawing.Point(334, 684);
            this.btncapnhat.Name = "btncapnhat";
            this.btncapnhat.Size = new System.Drawing.Size(111, 36);
            this.btncapnhat.TabIndex = 38;
            this.btncapnhat.Text = "Cập nhật";
            this.btncapnhat.UseVisualStyleBackColor = true;
            this.btncapnhat.Click += new System.EventHandler(this.btncapnhat_Click);
            // 
            // pnchuky
            // 
            this.pnchuky.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnchuky.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnchuky.Controls.Add(this.btnthoat);
            this.pnchuky.Controls.Add(this.chkhienan);
            this.pnchuky.Controls.Add(this.btndangnhap);
            this.pnchuky.Controls.Add(this.txtchuky);
            this.pnchuky.Controls.Add(this.label1);
            this.pnchuky.Location = new System.Drawing.Point(286, 211);
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
            this.txtchuky.BackColor = System.Drawing.Color.White;
            this.txtchuky.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtchuky.Location = new System.Drawing.Point(88, 80);
            this.txtchuky.Name = "txtchuky";
            this.txtchuky.Size = new System.Drawing.Size(224, 26);
            this.txtchuky.TabIndex = 1;
            this.txtchuky.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(23, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cần có chữ ký của chủ tịch xã để xác nhận";
            // 
            // frmupdateCMND
            // 
            this.AcceptButton = this.btnfindmashk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(993, 740);
            this.Controls.Add(this.pnchuky);
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.btncapnhat);
            this.Controls.Add(this.grbtimkiem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvupdateCMND);
            this.Controls.Add(this.label3);
            this.Name = "frmupdateCMND";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cập nhật chứng minh nhân dân";
            this.Load += new System.EventHandler(this.frmupdateCMND_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvupdateCMND)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbtimkiem.ResumeLayout(false);
            this.grbtimkiem.PerformLayout();
            this.pnchuky.ResumeLayout(false);
            this.pnchuky.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvupdateCMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NguyenQuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoiCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayCap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
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
        private System.Windows.Forms.Button btndong;
        private System.Windows.Forms.Button btncapnhat;
        private System.Windows.Forms.Panel pnchuky;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.CheckBox chkhienan;
        private System.Windows.Forms.Button btndangnhap;
        private System.Windows.Forms.TextBox txtchuky;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnfindmashk;
        private System.Windows.Forms.TextBox dtpnamsinh;
        private System.Windows.Forms.TextBox dtpngaycap;
    }
}