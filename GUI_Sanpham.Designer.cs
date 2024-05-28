namespace Doan01
{
    partial class GUI_Sanpham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_Sanpham));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLm = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtTk = new System.Windows.Forms.TextBox();
            this.btnTkiem = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvSp = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbMlh = new System.Windows.Forms.ComboBox();
            this.txtDg = new System.Windows.Forms.TextBox();
            this.txtGc = new System.Windows.Forms.TextBox();
            this.txtSl = new System.Windows.Forms.TextBox();
            this.txtTsp = new System.Windows.Forms.TextBox();
            this.txtMsp = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSp)).BeginInit();
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
            this.groupBox3.Location = new System.Drawing.Point(7, 746);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1391, 99);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            // 
            // btnSua
            // 
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.Location = new System.Drawing.Point(560, 33);
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
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(304, 33);
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
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.Location = new System.Drawing.Point(1129, 33);
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
            this.btnLm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLm.Image = ((System.Drawing.Image)(resources.GetObject("btnLm.Image")));
            this.btnLm.Location = new System.Drawing.Point(28, 33);
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
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(837, 33);
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
            this.txtTk.Location = new System.Drawing.Point(171, 663);
            this.txtTk.Name = "txtTk";
            this.txtTk.Size = new System.Drawing.Size(327, 26);
            this.txtTk.TabIndex = 30;
            this.txtTk.Text = "Nhập tên hoặc mã";
            this.txtTk.Enter += new System.EventHandler(this.txtTk_Enter);
            this.txtTk.Leave += new System.EventHandler(this.txtTk_Leave);
            // 
            // btnTkiem
            // 
            this.btnTkiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTkiem.Image")));
            this.btnTkiem.Location = new System.Drawing.Point(12, 653);
            this.btnTkiem.Name = "btnTkiem";
            this.btnTkiem.Size = new System.Drawing.Size(129, 47);
            this.btnTkiem.TabIndex = 29;
            this.btnTkiem.Text = "Tìm kiếm";
            this.btnTkiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTkiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTkiem.UseVisualStyleBackColor = true;
            this.btnTkiem.Click += new System.EventHandler(this.btnTkiem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.dgvSp);
            this.groupBox2.Location = new System.Drawing.Point(505, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(899, 729);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách các sản phẩm:";
            // 
            // dgvSp
            // 
            this.dgvSp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSp.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvSp.Location = new System.Drawing.Point(6, 25);
            this.dgvSp.Name = "dgvSp";
            this.dgvSp.RowHeadersWidth = 62;
            this.dgvSp.RowTemplate.Height = 28;
            this.dgvSp.Size = new System.Drawing.Size(880, 687);
            this.dgvSp.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.cbMlh);
            this.groupBox1.Controls.Add(this.txtDg);
            this.groupBox1.Controls.Add(this.txtGc);
            this.groupBox1.Controls.Add(this.txtSl);
            this.groupBox1.Controls.Add(this.txtTsp);
            this.groupBox1.Controls.Add(this.txtMsp);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(10, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 550);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin loại sản phẩm:";
            // 
            // cbMlh
            // 
            this.cbMlh.FormattingEnabled = true;
            this.cbMlh.Location = new System.Drawing.Point(161, 310);
            this.cbMlh.Name = "cbMlh";
            this.cbMlh.Size = new System.Drawing.Size(285, 28);
            this.cbMlh.TabIndex = 12;
            // 
            // txtDg
            // 
            this.txtDg.Location = new System.Drawing.Point(161, 487);
            this.txtDg.Name = "txtDg";
            this.txtDg.Size = new System.Drawing.Size(285, 26);
            this.txtDg.TabIndex = 11;
            this.txtDg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDg_KeyPress);
            // 
            // txtGc
            // 
            this.txtGc.Location = new System.Drawing.Point(161, 398);
            this.txtGc.Name = "txtGc";
            this.txtGc.Size = new System.Drawing.Size(285, 26);
            this.txtGc.TabIndex = 10;
            // 
            // txtSl
            // 
            this.txtSl.Location = new System.Drawing.Point(161, 221);
            this.txtSl.Name = "txtSl";
            this.txtSl.Size = new System.Drawing.Size(285, 26);
            this.txtSl.TabIndex = 9;
            this.txtSl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSl_KeyPress);
            // 
            // txtTsp
            // 
            this.txtTsp.Location = new System.Drawing.Point(161, 131);
            this.txtTsp.Name = "txtTsp";
            this.txtTsp.Size = new System.Drawing.Size(285, 26);
            this.txtTsp.TabIndex = 8;
            // 
            // txtMsp
            // 
            this.txtMsp.Location = new System.Drawing.Point(161, 45);
            this.txtMsp.Name = "txtMsp";
            this.txtMsp.Size = new System.Drawing.Size(285, 26);
            this.txtMsp.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 487);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Đơn giá";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 401);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Ghi chú";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Mã loại hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số lượng";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(21, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên sản phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sản phẩm";
            // 
            // GUI_Sanpham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1399, 847);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.txtTk);
            this.Controls.Add(this.btnTkiem);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "GUI_Sanpham";
            this.Text = "GUI_Sanpham";
            this.Load += new System.EventHandler(this.GUI_Sanpham_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSp)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvSp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMsp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSl;
        private System.Windows.Forms.TextBox txtTsp;
        private System.Windows.Forms.ComboBox cbMlh;
        private System.Windows.Forms.TextBox txtDg;
        private System.Windows.Forms.TextBox txtGc;
    }
}