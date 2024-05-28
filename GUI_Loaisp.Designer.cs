namespace Doan01
{
    partial class GUI_Loaisp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_Loaisp));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvLsp = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTkiem = new System.Windows.Forms.Button();
            this.txtTk = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLm = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLsp)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.dgvLsp);
            this.groupBox2.Location = new System.Drawing.Point(589, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(820, 731);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách các loại sản phẩm:";
            // 
            // dgvLsp
            // 
            this.dgvLsp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLsp.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvLsp.Location = new System.Drawing.Point(27, 25);
            this.dgvLsp.Name = "dgvLsp";
            this.dgvLsp.RowHeadersWidth = 62;
            this.dgvLsp.RowTemplate.Height = 28;
            this.dgvLsp.Size = new System.Drawing.Size(787, 686);
            this.dgvLsp.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.txtTl);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMl);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(26, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(557, 310);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin loại sản phẩm:";
            // 
            // txtTl
            // 
            this.txtTl.Location = new System.Drawing.Point(118, 181);
            this.txtTl.Name = "txtTl";
            this.txtTl.Size = new System.Drawing.Size(431, 26);
            this.txtTl.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã loại";
            // 
            // txtMl
            // 
            this.txtMl.Location = new System.Drawing.Point(118, 72);
            this.txtMl.Name = "txtMl";
            this.txtMl.Size = new System.Drawing.Size(416, 26);
            this.txtMl.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên loại";
            // 
            // btnTkiem
            // 
            this.btnTkiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTkiem.Image")));
            this.btnTkiem.Location = new System.Drawing.Point(26, 367);
            this.btnTkiem.Name = "btnTkiem";
            this.btnTkiem.Size = new System.Drawing.Size(129, 47);
            this.btnTkiem.TabIndex = 21;
            this.btnTkiem.Text = "Tìm kiếm";
            this.btnTkiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTkiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTkiem.UseVisualStyleBackColor = true;
            this.btnTkiem.Click += new System.EventHandler(this.btnTkiem_Click_2);
            // 
            // txtTk
            // 
            this.txtTk.ForeColor = System.Drawing.Color.DimGray;
            this.txtTk.Location = new System.Drawing.Point(181, 377);
            this.txtTk.Name = "txtTk";
            this.txtTk.Size = new System.Drawing.Size(394, 26);
            this.txtTk.TabIndex = 22;
            this.txtTk.Text = "Nhập tên hoặc mã";
            this.txtTk.Enter += new System.EventHandler(this.txtTk_Enter);
            this.txtTk.Leave += new System.EventHandler(this.txtTk_Leave);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::Doan01.Properties.Resources.icons8_delete_24;
            this.btnXoa.Location = new System.Drawing.Point(906, 25);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(209, 55);
            this.btnXoa.TabIndex = 20;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click_1);
            // 
            // btnSua
            // 
            this.btnSua.Image = global::Doan01.Properties.Resources.icons8_save_24;
            this.btnSua.Location = new System.Drawing.Point(587, 25);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(209, 55);
            this.btnSua.TabIndex = 19;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click_1);
            // 
            // btnThem
            // 
            this.btnThem.Image = global::Doan01.Properties.Resources.icons8_add_24;
            this.btnThem.Location = new System.Drawing.Point(301, 25);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(209, 55);
            this.btnThem.TabIndex = 18;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLm
            // 
            this.btnLm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLm.Image = ((System.Drawing.Image)(resources.GetObject("btnLm.Image")));
            this.btnLm.Location = new System.Drawing.Point(28, 25);
            this.btnLm.Name = "btnLm";
            this.btnLm.Size = new System.Drawing.Size(209, 55);
            this.btnLm.TabIndex = 17;
            this.btnLm.Text = "Làm mới";
            this.btnLm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLm.UseVisualStyleBackColor = true;
            this.btnLm.Click += new System.EventHandler(this.btnLm_Click_1);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnThoat);
            this.groupBox3.Controls.Add(this.btnThem);
            this.groupBox3.Controls.Add(this.btnXoa);
            this.groupBox3.Controls.Add(this.btnLm);
            this.groupBox3.Controls.Add(this.btnSua);
            this.groupBox3.Location = new System.Drawing.Point(12, 760);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1397, 93);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            // 
            // btnThoat
            // 
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.Location = new System.Drawing.Point(1161, 25);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(209, 55);
            this.btnThoat.TabIndex = 21;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // GUI_Loaisp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1421, 865);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.txtTk);
            this.Controls.Add(this.btnTkiem);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GUI_Loaisp";
            this.Text = "GUI_Loaisp";
            this.Load += new System.EventHandler(this.GUI_Loaisp_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLsp)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvLsp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMl;
        private System.Windows.Forms.TextBox txtTl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTkiem;
        private System.Windows.Forms.TextBox txtTk;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLm;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnThoat;
    }
}