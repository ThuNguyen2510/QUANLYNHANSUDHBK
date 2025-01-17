﻿namespace QLNS.GUI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bttracuu = new System.Windows.Forms.Button();
            this.butTacVuCapNhap = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.butThem = new System.Windows.Forms.Button();
            this.butXoa = new System.Windows.Forms.Button();
            this.butSua = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.butTimKiem = new System.Windows.Forms.Button();
            this.butHienThi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labXuat = new System.Windows.Forms.Label();
            this.path1 = new System.Windows.Forms.Label();
            this.butExport = new System.Windows.Forms.Button();
            this.cbbNoisinh = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtNamDatHV = new System.Windows.Forms.TextBox();
            this.cbbNgoaiNgu = new System.Windows.Forms.ComboBox();
            this.cbbChuyenNganh = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtTruongTN = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtLinhVucNC = new System.Windows.Forms.TextBox();
            this.radFemale = new System.Windows.Forms.RadioButton();
            this.radMale = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.cbbDiaChi = new System.Windows.Forms.ComboBox();
            this.image = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.cbbTenKhoa = new System.Windows.Forms.ComboBox();
            this.txtQueQuan = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbbTenCV = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbbHVi = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbHHam = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbTenPhBan = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.butTHONGKE = new System.Windows.Forms.Button();
            this.loadDataWorker = new System.ComponentModel.BackgroundWorker();
            this.ExportWorker = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::QLNS.Properties.Resources.Capture;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(623, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(460, 57);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bttracuu
            // 
            this.bttracuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttracuu.ForeColor = System.Drawing.Color.Navy;
            this.bttracuu.Image = global::QLNS.Properties.Resources.TC_nhanvien2;
            this.bttracuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttracuu.Location = new System.Drawing.Point(35, 153);
            this.bttracuu.Name = "bttracuu";
            this.bttracuu.Size = new System.Drawing.Size(159, 42);
            this.bttracuu.TabIndex = 2;
            this.bttracuu.Text = "Tra Cứu Thông Tin";
            this.bttracuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttracuu.UseVisualStyleBackColor = true;
            this.bttracuu.Click += new System.EventHandler(this.bttracuu_Click);
            // 
            // butTacVuCapNhap
            // 
            this.butTacVuCapNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butTacVuCapNhap.ForeColor = System.Drawing.Color.Navy;
            this.butTacVuCapNhap.Image = global::QLNS.Properties.Resources.Icon0011;
            this.butTacVuCapNhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butTacVuCapNhap.Location = new System.Drawing.Point(35, 233);
            this.butTacVuCapNhap.Name = "butTacVuCapNhap";
            this.butTacVuCapNhap.Size = new System.Drawing.Size(159, 42);
            this.butTacVuCapNhap.TabIndex = 2;
            this.butTacVuCapNhap.Text = "Tác vụ-Cập nhật";
            this.butTacVuCapNhap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butTacVuCapNhap.UseVisualStyleBackColor = true;
            this.butTacVuCapNhap.Click += new System.EventHandler(this.butTacVuCapNhap_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Navy;
            this.button3.Image = global::QLNS.Properties.Resources.eee;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(35, 308);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(159, 42);
            this.button3.TabIndex = 2;
            this.button3.Text = "Liên hệ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.butThem);
            this.panel1.Controls.Add(this.butXoa);
            this.panel1.Controls.Add(this.butSua);
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.dgv);
            this.panel1.Controls.Add(this.butTimKiem);
            this.panel1.Controls.Add(this.butHienThi);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(275, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(843, 593);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Navy;
            this.button1.Image = global::QLNS.Properties.Resources.upload;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(684, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 34);
            this.button1.TabIndex = 30;
            this.button1.Text = "Tải ảnh lên";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // butThem
            // 
            this.butThem.ForeColor = System.Drawing.Color.Navy;
            this.butThem.Image = global::QLNS.Properties.Resources.add_user1;
            this.butThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butThem.Location = new System.Drawing.Point(171, 386);
            this.butThem.Name = "butThem";
            this.butThem.Size = new System.Drawing.Size(85, 30);
            this.butThem.TabIndex = 29;
            this.butThem.Text = "Thêm";
            this.butThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butThem.UseVisualStyleBackColor = true;
            this.butThem.Click += new System.EventHandler(this.butThem_Click);
            // 
            // butXoa
            // 
            this.butXoa.ForeColor = System.Drawing.Color.Navy;
            this.butXoa.Image = global::QLNS.Properties.Resources.remove_user;
            this.butXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butXoa.Location = new System.Drawing.Point(369, 386);
            this.butXoa.Name = "butXoa";
            this.butXoa.Size = new System.Drawing.Size(85, 30);
            this.butXoa.TabIndex = 28;
            this.butXoa.Text = "Xóa";
            this.butXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butXoa.UseVisualStyleBackColor = true;
            this.butXoa.Click += new System.EventHandler(this.butXoa_Click);
            // 
            // butSua
            // 
            this.butSua.ForeColor = System.Drawing.Color.Navy;
            this.butSua.Image = global::QLNS.Properties.Resources.edit_user;
            this.butSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butSua.Location = new System.Drawing.Point(271, 386);
            this.butSua.Name = "butSua";
            this.butSua.Size = new System.Drawing.Size(85, 30);
            this.butSua.TabIndex = 27;
            this.butSua.Text = "Sửa";
            this.butSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butSua.UseVisualStyleBackColor = true;
            this.butSua.Click += new System.EventHandler(this.butSua_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(457, 391);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(122, 20);
            this.txtTimKiem.TabIndex = 26;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Blue;
            this.label14.Location = new System.Drawing.Point(307, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(203, 25);
            this.label14.TabIndex = 25;
            this.label14.Text = "Thông tin nhân viên";
            this.label14.UseMnemonic = false;
            // 
            // dgv
            // 
            this.dgv.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(26, 417);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(739, 163);
            this.dgv.TabIndex = 10;
            this.dgv.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_RowHeaderMouseClick);
            // 
            // butTimKiem
            // 
            this.butTimKiem.ForeColor = System.Drawing.Color.Navy;
            this.butTimKiem.Image = global::QLNS.Properties.Resources.tim;
            this.butTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butTimKiem.Location = new System.Drawing.Point(585, 386);
            this.butTimKiem.Name = "butTimKiem";
            this.butTimKiem.Size = new System.Drawing.Size(85, 30);
            this.butTimKiem.TabIndex = 8;
            this.butTimKiem.Text = "Tìm Kiếm";
            this.butTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butTimKiem.UseVisualStyleBackColor = true;
            this.butTimKiem.Click += new System.EventHandler(this.butTimKiem_Click);
            // 
            // butHienThi
            // 
            this.butHienThi.ForeColor = System.Drawing.Color.Navy;
            this.butHienThi.Image = global::QLNS.Properties.Resources._1270361629_administrator;
            this.butHienThi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butHienThi.Location = new System.Drawing.Point(62, 386);
            this.butHienThi.Name = "butHienThi";
            this.butHienThi.Size = new System.Drawing.Size(85, 30);
            this.butHienThi.TabIndex = 7;
            this.butHienThi.Text = "Hiển thị";
            this.butHienThi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butHienThi.UseVisualStyleBackColor = true;
            this.butHienThi.Click += new System.EventHandler(this.butHienThi_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labXuat);
            this.groupBox1.Controls.Add(this.path1);
            this.groupBox1.Controls.Add(this.butExport);
            this.groupBox1.Controls.Add(this.cbbNoisinh);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.txtNamDatHV);
            this.groupBox1.Controls.Add(this.cbbNgoaiNgu);
            this.groupBox1.Controls.Add(this.cbbChuyenNganh);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtTruongTN);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.txtLinhVucNC);
            this.groupBox1.Controls.Add(this.radFemale);
            this.groupBox1.Controls.Add(this.radMale);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.cbbDiaChi);
            this.groupBox1.Controls.Add(this.image);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.cbbTenKhoa);
            this.groupBox1.Controls.Add(this.txtQueQuan);
            this.groupBox1.Controls.Add(this.txtTenNV);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtMaNV);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cbbTenCV);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cbbHVi);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbbHHam);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbbTenPhBan);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(26, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(797, 358);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // labXuat
            // 
            this.labXuat.AutoSize = true;
            this.labXuat.Enabled = false;
            this.labXuat.Location = new System.Drawing.Point(655, 305);
            this.labXuat.Name = "labXuat";
            this.labXuat.Size = new System.Drawing.Size(107, 13);
            this.labXuat.TabIndex = 36;
            this.labXuat.Text = "Đang xuất dữ liệu";
            this.labXuat.Visible = false;
            // 
            // path1
            // 
            this.path1.AutoSize = true;
            this.path1.Location = new System.Drawing.Point(658, 211);
            this.path1.Name = "path1";
            this.path1.Size = new System.Drawing.Size(0, 13);
            this.path1.TabIndex = 35;
            this.path1.Visible = false;
            // 
            // butExport
            // 
            this.butExport.ForeColor = System.Drawing.Color.Navy;
            this.butExport.Location = new System.Drawing.Point(664, 271);
            this.butExport.Name = "butExport";
            this.butExport.Size = new System.Drawing.Size(75, 23);
            this.butExport.TabIndex = 34;
            this.butExport.Text = "Export";
            this.butExport.UseVisualStyleBackColor = true;
            this.butExport.Click += new System.EventHandler(this.butExport_Click);
            // 
            // cbbNoisinh
            // 
            this.cbbNoisinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbNoisinh.FormattingEnabled = true;
            this.cbbNoisinh.Location = new System.Drawing.Point(118, 161);
            this.cbbNoisinh.Name = "cbbNoisinh";
            this.cbbNoisinh.Size = new System.Drawing.Size(198, 21);
            this.cbbNoisinh.TabIndex = 33;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 163);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(55, 13);
            this.label19.TabIndex = 32;
            this.label19.Text = "Nơi Sinh";
            // 
            // txtNamDatHV
            // 
            this.txtNamDatHV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamDatHV.Location = new System.Drawing.Point(458, 269);
            this.txtNamDatHV.Name = "txtNamDatHV";
            this.txtNamDatHV.Size = new System.Drawing.Size(161, 20);
            this.txtNamDatHV.TabIndex = 31;
            // 
            // cbbNgoaiNgu
            // 
            this.cbbNgoaiNgu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbNgoaiNgu.FormattingEnabled = true;
            this.cbbNgoaiNgu.Location = new System.Drawing.Point(118, 297);
            this.cbbNgoaiNgu.Name = "cbbNgoaiNgu";
            this.cbbNgoaiNgu.Size = new System.Drawing.Size(198, 21);
            this.cbbNgoaiNgu.TabIndex = 30;
            // 
            // cbbChuyenNganh
            // 
            this.cbbChuyenNganh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbChuyenNganh.FormattingEnabled = true;
            this.cbbChuyenNganh.Location = new System.Drawing.Point(458, 131);
            this.cbbChuyenNganh.Name = "cbbChuyenNganh";
            this.cbbChuyenNganh.Size = new System.Drawing.Size(161, 21);
            this.cbbChuyenNganh.TabIndex = 29;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 300);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(67, 13);
            this.label18.TabIndex = 28;
            this.label18.Text = "Ngoại Ngữ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(340, 268);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(94, 13);
            this.label17.TabIndex = 28;
            this.label17.Text = "Năm đạt học vị";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(340, 163);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(108, 13);
            this.label16.TabIndex = 28;
            this.label16.Text = "Trường tốt nghiệp";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(340, 130);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(90, 13);
            this.label15.TabIndex = 28;
            this.label15.Text = "Chuyên Ngành";
            // 
            // txtTruongTN
            // 
            this.txtTruongTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTruongTN.Location = new System.Drawing.Point(458, 165);
            this.txtTruongTN.Name = "txtTruongTN";
            this.txtTruongTN.Size = new System.Drawing.Size(161, 20);
            this.txtTruongTN.TabIndex = 27;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(118, 99);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(198, 20);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // txtLinhVucNC
            // 
            this.txtLinhVucNC.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtLinhVucNC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLinhVucNC.Location = new System.Drawing.Point(118, 331);
            this.txtLinhVucNC.Name = "txtLinhVucNC";
            this.txtLinhVucNC.Size = new System.Drawing.Size(501, 20);
            this.txtLinhVucNC.TabIndex = 26;
            // 
            // radFemale
            // 
            this.radFemale.AutoSize = true;
            this.radFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radFemale.Location = new System.Drawing.Point(179, 132);
            this.radFemale.Name = "radFemale";
            this.radFemale.Size = new System.Drawing.Size(39, 17);
            this.radFemale.TabIndex = 21;
            this.radFemale.TabStop = true;
            this.radFemale.Text = "Nữ";
            this.radFemale.UseVisualStyleBackColor = true;
            // 
            // radMale
            // 
            this.radMale.AutoSize = true;
            this.radMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMale.Location = new System.Drawing.Point(118, 132);
            this.radMale.Name = "radMale";
            this.radMale.Size = new System.Drawing.Size(47, 17);
            this.radMale.TabIndex = 20;
            this.radMale.TabStop = true;
            this.radMale.Text = "Nam";
            this.radMale.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(2, 331);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(119, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Lĩnh vực ngiên cứu";
            // 
            // cbbDiaChi
            // 
            this.cbbDiaChi.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbbDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbDiaChi.FormattingEnabled = true;
            this.cbbDiaChi.Location = new System.Drawing.Point(118, 197);
            this.cbbDiaChi.Name = "cbbDiaChi";
            this.cbbDiaChi.Size = new System.Drawing.Size(198, 21);
            this.cbbDiaChi.TabIndex = 15;
            // 
            // image
            // 
            this.image.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.image.Location = new System.Drawing.Point(646, 13);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(124, 143);
            this.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.image.TabIndex = 6;
            this.image.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(340, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tên phòng ban";
            // 
            // txtSDT
            // 
            this.txtSDT.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(118, 267);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(198, 20);
            this.txtSDT.TabIndex = 14;
            // 
            // cbbTenKhoa
            // 
            this.cbbTenKhoa.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbbTenKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTenKhoa.FormattingEnabled = true;
            this.cbbTenKhoa.Location = new System.Drawing.Point(458, 98);
            this.cbbTenKhoa.Name = "cbbTenKhoa";
            this.cbbTenKhoa.Size = new System.Drawing.Size(161, 21);
            this.cbbTenKhoa.TabIndex = 24;
            // 
            // txtQueQuan
            // 
            this.txtQueQuan.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtQueQuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQueQuan.Location = new System.Drawing.Point(118, 230);
            this.txtQueQuan.Name = "txtQueQuan";
            this.txtQueQuan.Size = new System.Drawing.Size(198, 20);
            this.txtQueQuan.TabIndex = 13;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNV.Location = new System.Drawing.Point(118, 60);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(198, 20);
            this.txtTenNV.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(340, 97);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Tên Khoa";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(118, 24);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.ReadOnly = true;
            this.txtMaNV.Size = new System.Drawing.Size(198, 20);
            this.txtMaNV.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 271);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Số điện thoại";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 234);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Quê quán";
            // 
            // cbbTenCV
            // 
            this.cbbTenCV.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbbTenCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTenCV.FormattingEnabled = true;
            this.cbbTenCV.Location = new System.Drawing.Point(458, 23);
            this.cbbTenCV.Name = "cbbTenCV";
            this.cbbTenCV.Size = new System.Drawing.Size(161, 21);
            this.cbbTenCV.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(340, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên chức vụ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 197);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Địa chỉ";
            // 
            // cbbHVi
            // 
            this.cbbHVi.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbbHVi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbHVi.FormattingEnabled = true;
            this.cbbHVi.Location = new System.Drawing.Point(458, 238);
            this.cbbHVi.Name = "cbbHVi";
            this.cbbHVi.Size = new System.Drawing.Size(161, 21);
            this.cbbHVi.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Giới tính";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Nhân viên";
            // 
            // cbbHHam
            // 
            this.cbbHHam.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbbHHam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbHHam.FormattingEnabled = true;
            this.cbbHHam.Location = new System.Drawing.Point(458, 204);
            this.cbbHHam.Name = "cbbHHam";
            this.cbbHHam.Size = new System.Drawing.Size(161, 21);
            this.cbbHHam.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Nhân viên";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(340, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Học Hàm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày sinh";
            // 
            // cbbTenPhBan
            // 
            this.cbbTenPhBan.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbbTenPhBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTenPhBan.FormattingEnabled = true;
            this.cbbTenPhBan.Location = new System.Drawing.Point(458, 60);
            this.cbbTenPhBan.Name = "cbbTenPhBan";
            this.cbbTenPhBan.Size = new System.Drawing.Size(161, 21);
            this.cbbTenPhBan.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(340, 237);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Học Vị";
            // 
            // butTHONGKE
            // 
            this.butTHONGKE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butTHONGKE.ForeColor = System.Drawing.Color.Navy;
            this.butTHONGKE.Image = ((System.Drawing.Image)(resources.GetObject("butTHONGKE.Image")));
            this.butTHONGKE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butTHONGKE.Location = new System.Drawing.Point(35, 378);
            this.butTHONGKE.Name = "butTHONGKE";
            this.butTHONGKE.Size = new System.Drawing.Size(159, 42);
            this.butTHONGKE.TabIndex = 5;
            this.butTHONGKE.Text = "Thống kê";
            this.butTHONGKE.UseVisualStyleBackColor = true;
            this.butTHONGKE.Click += new System.EventHandler(this.butTHONGKE_Click);
            // 
            // loadDataWorker
            // 
            this.loadDataWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.loadDataWorker_DoWork);
            this.loadDataWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.loadDataWorker_RunWorkerCompleted);
            // 
            // ExportWorker
            // 
            this.ExportWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.ExportWorker_DoWork);
            this.ExportWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.ExportWorker_RunWorkerCompleted);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = global::QLNS.Properties.Resources.Main;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1130, 741);
            this.Controls.Add(this.butTHONGKE);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.butTacVuCapNhap);
            this.Controls.Add(this.bttracuu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bttracuu;
        private System.Windows.Forms.Button butTacVuCapNhap;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button butTimKiem;
        private System.Windows.Forms.Button butHienThi;
        private System.Windows.Forms.PictureBox image;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbbTenKhoa;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton radFemale;
        private System.Windows.Forms.RadioButton radMale;
        private System.Windows.Forms.ComboBox cbbHVi;
        private System.Windows.Forms.ComboBox cbbHHam;
        private System.Windows.Forms.ComboBox cbbTenPhBan;
        private System.Windows.Forms.ComboBox cbbTenCV;
        private System.Windows.Forms.ComboBox cbbDiaChi;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtQueQuan;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button butThem;
        private System.Windows.Forms.Button butXoa;
        private System.Windows.Forms.Button butSua;
        private System.Windows.Forms.TextBox txtLinhVucNC;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtTruongTN;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtNamDatHV;
        private System.Windows.Forms.ComboBox cbbNgoaiNgu;
        private System.Windows.Forms.ComboBox cbbChuyenNganh;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cbbNoisinh;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button butTHONGKE;
        private System.Windows.Forms.Button butExport;
        private System.Windows.Forms.Label path1;
        private System.ComponentModel.BackgroundWorker loadDataWorker;
        private System.ComponentModel.BackgroundWorker ExportWorker;
        private System.Windows.Forms.Label labXuat;
    }
}