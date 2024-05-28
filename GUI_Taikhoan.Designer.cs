namespace Doan01
{
    partial class GUI_Taikhoan
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLm = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtTk = new System.Windows.Forms.TextBox();
            this.btnTkiem = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvTk = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbMnv = new System.Windows.Forms.ComboBox();
            this.cbCv = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtMk = new System.Windows.Forms.TextBox();
            this.txtTtk = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTk)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.btnSua);
            this.groupBox3.Controls.Add(this.btnThem);
            this.groupBox3.Controls.Add(this.btnThoat);
            this.groupBox3.Controls.Add(this.btnLm);
            this.groupBox3.Controls.Add(this.btnXoa);
            this.groupBox3.Location = new System.Drawing.Point(12, 751);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1402, 96);
            this.groupBox3.TabIndex = 59;
            this.groupBox3.TabStop = false;
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSua.Image = global::Doan01.Properties.Resources.icons8_save_24;
            this.btnSua.Location = new System.Drawing.Point(587, 25);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(209, 55);
            this.btnSua.TabIndex = 11;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnThem.Image = global::Doan01.Properties.Resources.icons8_add_24;
            this.btnThem.Location = new System.Drawing.Point(302, 25);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(209, 55);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnThoat.Image = global::Doan01.Properties.Resources.icons8_exit_24;
            this.btnThoat.Location = new System.Drawing.Point(1166, 25);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(209, 55);
            this.btnThoat.TabIndex = 16;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLm
            // 
            this.btnLm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLm.Image = global::Doan01.Properties.Resources.icons8_refresh_24;
            this.btnLm.Location = new System.Drawing.Point(35, 25);
            this.btnLm.Name = "btnLm";
            this.btnLm.Size = new System.Drawing.Size(209, 55);
            this.btnLm.TabIndex = 9;
            this.btnLm.Text = "Làm mới";
            this.btnLm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLm.UseVisualStyleBackColor = true;
            this.btnLm.Click += new System.EventHandler(this.btnLm_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnXoa.Image = global::Doan01.Properties.Resources.icons8_delete_24;
            this.btnXoa.Location = new System.Drawing.Point(854, 25);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(209, 55);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtTk
            // 
            this.txtTk.ForeColor = System.Drawing.Color.DimGray;
            this.txtTk.Location = new System.Drawing.Point(164, 663);
            this.txtTk.Name = "txtTk";
            this.txtTk.Size = new System.Drawing.Size(334, 26);
            this.txtTk.TabIndex = 58;
            this.txtTk.Text = "Nhập tên tài khoản";
            this.txtTk.Enter += new System.EventHandler(this.txtTk_Enter);
            this.txtTk.Leave += new System.EventHandler(this.txtTk_Leave);
            // 
            // btnTkiem
            // 
            this.btnTkiem.Image = global::Doan01.Properties.Resources.icons8_find_20;
            this.btnTkiem.Location = new System.Drawing.Point(17, 653);
            this.btnTkiem.Name = "btnTkiem";
            this.btnTkiem.Size = new System.Drawing.Size(129, 47);
            this.btnTkiem.TabIndex = 57;
            this.btnTkiem.Text = "Tìm kiếm";
            this.btnTkiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTkiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTkiem.UseVisualStyleBackColor = true;
            this.btnTkiem.Click += new System.EventHandler(this.btnTkiem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.dgvTk);
            this.groupBox2.Location = new System.Drawing.Point(515, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(899, 721);
            this.groupBox2.TabIndex = 56;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách tài khoản";
            // 
            // dgvTk
            // 
            this.dgvTk.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTk.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTk.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvTk.Location = new System.Drawing.Point(4, 25);
            this.dgvTk.Name = "dgvTk";
            this.dgvTk.RowHeadersWidth = 62;
            this.dgvTk.RowTemplate.Height = 28;
            this.dgvTk.Size = new System.Drawing.Size(887, 682);
            this.dgvTk.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.cbMnv);
            this.groupBox1.Controls.Add(this.cbCv);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtMk);
            this.groupBox1.Controls.Add(this.txtTtk);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(486, 556);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin tài khoản";
            // 
            // cbMnv
            // 
            this.cbMnv.FormattingEnabled = true;
            this.cbMnv.Location = new System.Drawing.Point(167, 74);
            this.cbMnv.Name = "cbMnv";
            this.cbMnv.Size = new System.Drawing.Size(285, 28);
            this.cbMnv.TabIndex = 16;
            // 
            // cbCv
            // 
            this.cbCv.FormattingEnabled = true;
            this.cbCv.Items.AddRange(new object[] {
            "Quản lý",
            "Nhân viên"});
            this.cbCv.Location = new System.Drawing.Point(167, 452);
            this.cbCv.Name = "cbCv";
            this.cbCv.Size = new System.Drawing.Size(285, 28);
            this.cbCv.TabIndex = 15;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(167, 352);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(285, 26);
            this.txtEmail.TabIndex = 13;
            // 
            // txtMk
            // 
            this.txtMk.Location = new System.Drawing.Point(167, 262);
            this.txtMk.Name = "txtMk";
            this.txtMk.Size = new System.Drawing.Size(285, 26);
            this.txtMk.TabIndex = 12;
            // 
            // txtTtk
            // 
            this.txtTtk.Location = new System.Drawing.Point(167, 165);
            this.txtTtk.Name = "txtTtk";
            this.txtTtk.Size = new System.Drawing.Size(285, 26);
            this.txtTtk.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Mã nhân viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 455);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Chức vụ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên tài khoản";
            // 
            // GUI_Taikhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1418, 859);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.txtTk);
            this.Controls.Add(this.btnTkiem);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "GUI_Taikhoan";
            this.Text = "GUI_Taikhoan";
            this.Load += new System.EventHandler(this.GUI_Taikhoan_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTk)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLm;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtTk;
        private System.Windows.Forms.Button btnTkiem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvTk;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtMk;
        private System.Windows.Forms.TextBox txtTtk;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbCv;
        private System.Windows.Forms.ComboBox cbMnv;
    }
}