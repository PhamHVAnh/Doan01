namespace Doan01
{
    partial class GUI_Hoadonban
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_Hoadonban));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnIn = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbthanhtien = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoaCT = new System.Windows.Forms.Button();
            this.nudGg = new System.Windows.Forms.NumericUpDown();
            this.btnSuaCT = new System.Windows.Forms.Button();
            this.btnThemCT = new System.Windows.Forms.Button();
            this.txtSl = new System.Windows.Forms.TextBox();
            this.txtDg = new System.Windows.Forms.TextBox();
            this.lblSL = new System.Windows.Forms.Label();
            this.dgvCTHDB = new System.Windows.Forms.DataGridView();
            this.cbMsp = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblTongtien = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtMhdb = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtTk = new System.Windows.Forms.TextBox();
            this.btnTkiem = new System.Windows.Forms.Button();
            this.btnLm = new System.Windows.Forms.Button();
            this.dtpNB = new System.Windows.Forms.DateTimePicker();
            this.dgvHDB = new System.Windows.Forms.DataGridView();
            this.cbMkh = new System.Windows.Forms.ComboBox();
            this.cbMnv = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHDB)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDB)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnIn);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.btnXoaCT);
            this.groupBox2.Controls.Add(this.nudGg);
            this.groupBox2.Controls.Add(this.btnSuaCT);
            this.groupBox2.Controls.Add(this.btnThemCT);
            this.groupBox2.Controls.Add(this.txtSl);
            this.groupBox2.Controls.Add(this.txtDg);
            this.groupBox2.Controls.Add(this.lblSL);
            this.groupBox2.Controls.Add(this.dgvCTHDB);
            this.groupBox2.Controls.Add(this.cbMsp);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(693, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(756, 846);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chi tiết";
            // 
            // btnIn
            // 
            this.btnIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnIn.Image = ((System.Drawing.Image)(resources.GetObject("btnIn.Image")));
            this.btnIn.Location = new System.Drawing.Point(549, 166);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(150, 46);
            this.btnIn.TabIndex = 48;
            this.btnIn.Text = "In hoá đơn";
            this.btnIn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbthanhtien);
            this.groupBox4.Location = new System.Drawing.Point(388, 772);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(340, 74);
            this.groupBox4.TabIndex = 48;
            this.groupBox4.TabStop = false;
            // 
            // lbthanhtien
            // 
            this.lbthanhtien.AutoSize = true;
            this.lbthanhtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbthanhtien.ForeColor = System.Drawing.Color.Red;
            this.lbthanhtien.Location = new System.Drawing.Point(6, 22);
            this.lbthanhtien.Name = "lbthanhtien";
            this.lbthanhtien.Size = new System.Drawing.Size(119, 26);
            this.lbthanhtien.TabIndex = 17;
            this.lbthanhtien.Text = "Thành tiền:";
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnThoat.Image = global::Doan01.Properties.Resources.icons8_exit_24;
            this.btnThoat.Location = new System.Drawing.Point(549, 217);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(150, 48);
            this.btnThoat.TabIndex = 20;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoaCT
            // 
            this.btnXoaCT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnXoaCT.Image = global::Doan01.Properties.Resources.icons8_delete_24;
            this.btnXoaCT.Location = new System.Drawing.Point(549, 116);
            this.btnXoaCT.Name = "btnXoaCT";
            this.btnXoaCT.Size = new System.Drawing.Size(150, 46);
            this.btnXoaCT.TabIndex = 16;
            this.btnXoaCT.Text = "Xóa";
            this.btnXoaCT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaCT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoaCT.UseVisualStyleBackColor = true;
            this.btnXoaCT.Click += new System.EventHandler(this.btnXoaCT_Click);
            // 
            // nudGg
            // 
            this.nudGg.Location = new System.Drawing.Point(136, 172);
            this.nudGg.Name = "nudGg";
            this.nudGg.Size = new System.Drawing.Size(242, 26);
            this.nudGg.TabIndex = 33;
            this.nudGg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nudGg_KeyPress);
            // 
            // btnSuaCT
            // 
            this.btnSuaCT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSuaCT.Image = global::Doan01.Properties.Resources.icons8_save_24;
            this.btnSuaCT.Location = new System.Drawing.Point(549, 64);
            this.btnSuaCT.Name = "btnSuaCT";
            this.btnSuaCT.Size = new System.Drawing.Size(150, 46);
            this.btnSuaCT.TabIndex = 15;
            this.btnSuaCT.Text = "Sửa";
            this.btnSuaCT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuaCT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSuaCT.UseVisualStyleBackColor = true;
            this.btnSuaCT.Click += new System.EventHandler(this.btnSuaCT_Click);
            // 
            // btnThemCT
            // 
            this.btnThemCT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnThemCT.Image = global::Doan01.Properties.Resources.icons8_add_24;
            this.btnThemCT.Location = new System.Drawing.Point(549, 14);
            this.btnThemCT.Name = "btnThemCT";
            this.btnThemCT.Size = new System.Drawing.Size(150, 46);
            this.btnThemCT.TabIndex = 14;
            this.btnThemCT.Text = "Thêm";
            this.btnThemCT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemCT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThemCT.UseVisualStyleBackColor = true;
            this.btnThemCT.Click += new System.EventHandler(this.btnThemCT_Click);
            // 
            // txtSl
            // 
            this.txtSl.Location = new System.Drawing.Point(136, 127);
            this.txtSl.Name = "txtSl";
            this.txtSl.Size = new System.Drawing.Size(242, 26);
            this.txtSl.TabIndex = 30;
            this.txtSl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSl_KeyPress);
            // 
            // txtDg
            // 
            this.txtDg.Location = new System.Drawing.Point(136, 84);
            this.txtDg.Name = "txtDg";
            this.txtDg.Size = new System.Drawing.Size(242, 26);
            this.txtDg.TabIndex = 31;
            this.txtDg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDg_KeyPress);
            // 
            // lblSL
            // 
            this.lblSL.AutoSize = true;
            this.lblSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblSL.ForeColor = System.Drawing.Color.Red;
            this.lblSL.Location = new System.Drawing.Point(23, 232);
            this.lblSL.Name = "lblSL";
            this.lblSL.Size = new System.Drawing.Size(133, 22);
            this.lblSL.TabIndex = 27;
            this.lblSL.Text = "Số lượng kho:";
            // 
            // dgvCTHDB
            // 
            this.dgvCTHDB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCTHDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTHDB.Location = new System.Drawing.Point(6, 269);
            this.dgvCTHDB.Name = "dgvCTHDB";
            this.dgvCTHDB.RowHeadersWidth = 62;
            this.dgvCTHDB.RowTemplate.Height = 28;
            this.dgvCTHDB.Size = new System.Drawing.Size(722, 497);
            this.dgvCTHDB.TabIndex = 16;
            // 
            // cbMsp
            // 
            this.cbMsp.FormattingEnabled = true;
            this.cbMsp.Location = new System.Drawing.Point(136, 40);
            this.cbMsp.Name = "cbMsp";
            this.cbMsp.Size = new System.Drawing.Size(242, 28);
            this.cbMsp.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 174);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 20);
            this.label10.TabIndex = 13;
            this.label10.Text = "Giảm giá:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Số lượng:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Đơn giá bán:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Mã sản phẩm:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.txtMhdb);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.txtTk);
            this.groupBox1.Controls.Add(this.btnTkiem);
            this.groupBox1.Controls.Add(this.btnLm);
            this.groupBox1.Controls.Add(this.dtpNB);
            this.groupBox1.Controls.Add(this.dgvHDB);
            this.groupBox1.Controls.Add(this.cbMkh);
            this.groupBox1.Controls.Add(this.cbMnv);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(659, 846);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblTongtien);
            this.groupBox3.Location = new System.Drawing.Point(332, 769);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(321, 71);
            this.groupBox3.TabIndex = 47;
            this.groupBox3.TabStop = false;
            // 
            // lblTongtien
            // 
            this.lblTongtien.AutoSize = true;
            this.lblTongtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTongtien.ForeColor = System.Drawing.Color.Red;
            this.lblTongtien.Location = new System.Drawing.Point(6, 22);
            this.lblTongtien.Name = "lblTongtien";
            this.lblTongtien.Size = new System.Drawing.Size(107, 26);
            this.lblTongtien.TabIndex = 12;
            this.lblTongtien.Text = "Tổng tiền:";
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSua.Image = global::Doan01.Properties.Resources.icons8_save_24;
            this.btnSua.Location = new System.Drawing.Point(483, 84);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(150, 46);
            this.btnSua.TabIndex = 18;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnXoa.Image = global::Doan01.Properties.Resources.icons8_delete_24;
            this.btnXoa.Location = new System.Drawing.Point(483, 135);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(150, 46);
            this.btnXoa.TabIndex = 19;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtMhdb
            // 
            this.txtMhdb.Location = new System.Drawing.Point(174, 34);
            this.txtMhdb.Name = "txtMhdb";
            this.txtMhdb.Size = new System.Drawing.Size(230, 26);
            this.txtMhdb.TabIndex = 30;
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnThem.Image = global::Doan01.Properties.Resources.icons8_add_24;
            this.btnThem.Location = new System.Drawing.Point(483, 29);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(150, 46);
            this.btnThem.TabIndex = 17;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtTk
            // 
            this.txtTk.ForeColor = System.Drawing.Color.DimGray;
            this.txtTk.Location = new System.Drawing.Point(174, 226);
            this.txtTk.Name = "txtTk";
            this.txtTk.Size = new System.Drawing.Size(230, 26);
            this.txtTk.TabIndex = 46;
            this.txtTk.Text = "Nhập mã hoá đơn";
            this.txtTk.Enter += new System.EventHandler(this.txtTk_Enter);
            this.txtTk.Leave += new System.EventHandler(this.txtTk_Leave);
            // 
            // btnTkiem
            // 
            this.btnTkiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTkiem.Image")));
            this.btnTkiem.Location = new System.Drawing.Point(12, 215);
            this.btnTkiem.Name = "btnTkiem";
            this.btnTkiem.Size = new System.Drawing.Size(135, 48);
            this.btnTkiem.TabIndex = 45;
            this.btnTkiem.Text = "Tìm kiếm";
            this.btnTkiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTkiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTkiem.UseVisualStyleBackColor = true;
            this.btnTkiem.Click += new System.EventHandler(this.btnTkiem_Click);
            // 
            // btnLm
            // 
            this.btnLm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLm.Image = global::Doan01.Properties.Resources.icons8_refresh_24;
            this.btnLm.Location = new System.Drawing.Point(483, 191);
            this.btnLm.Name = "btnLm";
            this.btnLm.Size = new System.Drawing.Size(150, 47);
            this.btnLm.TabIndex = 13;
            this.btnLm.Text = "Làm mới";
            this.btnLm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLm.UseVisualStyleBackColor = true;
            this.btnLm.Click += new System.EventHandler(this.btnLm_Click);
            // 
            // dtpNB
            // 
            this.dtpNB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNB.Location = new System.Drawing.Point(174, 166);
            this.dtpNB.MaxDate = new System.DateTime(2025, 1, 1, 0, 0, 0, 0);
            this.dtpNB.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpNB.Name = "dtpNB";
            this.dtpNB.Size = new System.Drawing.Size(230, 26);
            this.dtpNB.TabIndex = 7;
            this.dtpNB.Value = new System.DateTime(2024, 5, 28, 8, 46, 59, 0);
            // 
            // dgvHDB
            // 
            this.dgvHDB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvHDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHDB.Location = new System.Drawing.Point(12, 269);
            this.dgvHDB.Name = "dgvHDB";
            this.dgvHDB.RowHeadersWidth = 62;
            this.dgvHDB.RowTemplate.Height = 28;
            this.dgvHDB.Size = new System.Drawing.Size(635, 497);
            this.dgvHDB.TabIndex = 8;
            // 
            // cbMkh
            // 
            this.cbMkh.FormattingEnabled = true;
            this.cbMkh.Location = new System.Drawing.Point(174, 119);
            this.cbMkh.Name = "cbMkh";
            this.cbMkh.Size = new System.Drawing.Size(230, 28);
            this.cbMkh.TabIndex = 6;
            // 
            // cbMnv
            // 
            this.cbMnv.FormattingEnabled = true;
            this.cbMnv.Location = new System.Drawing.Point(174, 76);
            this.cbMnv.Name = "cbMnv";
            this.cbMnv.Size = new System.Drawing.Size(230, 28);
            this.cbMnv.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã khách hàng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày bán:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã nhân viên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hoá đơn bán:";
            // 
            // GUI_Hoadonban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1455, 870);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GUI_Hoadonban";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GUI_Hoadonban";
            this.Load += new System.EventHandler(this.GUI_Hoadonban_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHDB)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lbthanhtien;
        private System.Windows.Forms.Button btnXoaCT;
        private System.Windows.Forms.NumericUpDown nudGg;
        private System.Windows.Forms.Button btnSuaCT;
        private System.Windows.Forms.Button btnThemCT;
        private System.Windows.Forms.TextBox txtSl;
        private System.Windows.Forms.TextBox txtDg;
        private System.Windows.Forms.Label lblSL;
        private System.Windows.Forms.DataGridView dgvCTHDB;
        private System.Windows.Forms.ComboBox cbMsp;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblTongtien;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtMhdb;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtTk;
        private System.Windows.Forms.Button btnTkiem;
        private System.Windows.Forms.Button btnLm;
        private System.Windows.Forms.DateTimePicker dtpNB;
        private System.Windows.Forms.DataGridView dgvHDB;
        private System.Windows.Forms.ComboBox cbMkh;
        private System.Windows.Forms.ComboBox cbMnv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnThoat;
    }
}