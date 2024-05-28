namespace Doan01
{
    partial class GUI_Thongke
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_Thongke));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartCot = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTke = new System.Windows.Forms.Button();
            this.dtpC2 = new System.Windows.Forms.DateTimePicker();
            this.dtpC1 = new System.Windows.Forms.DateTimePicker();
            this.chartTron = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblBanra = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDoanhThu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvThongke = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.chartCot)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTron)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongke)).BeginInit();
            this.SuspendLayout();
            // 
            // chartCot
            // 
            chartArea3.Name = "ChartArea1";
            this.chartCot.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartCot.Legends.Add(legend3);
            this.chartCot.Location = new System.Drawing.Point(6, 25);
            this.chartCot.Name = "chartCot";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartCot.Series.Add(series3);
            this.chartCot.Size = new System.Drawing.Size(945, 505);
            this.chartCot.TabIndex = 0;
            this.chartCot.Text = "chart1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.chartTron);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.dgvThongke);
            this.groupBox1.Controls.Add(this.chartCot);
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1440, 833);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Location = new System.Drawing.Point(9, 543);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(402, 37);
            this.label3.TabIndex = 9;
            this.label3.Text = "DANH SÁCH SẢN PHẨM";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnTke);
            this.groupBox2.Controls.Add(this.dtpC2);
            this.groupBox2.Controls.Add(this.dtpC1);
            this.groupBox2.Location = new System.Drawing.Point(914, 583);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(505, 244);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(267, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Đến:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(31, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Từ:";
            // 
            // btnTke
            // 
            this.btnTke.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTke.Image = ((System.Drawing.Image)(resources.GetObject("btnTke.Image")));
            this.btnTke.Location = new System.Drawing.Point(165, 119);
            this.btnTke.Name = "btnTke";
            this.btnTke.Size = new System.Drawing.Size(212, 79);
            this.btnTke.TabIndex = 7;
            this.btnTke.Text = "Thống kê";
            this.btnTke.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTke.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTke.UseVisualStyleBackColor = true;
            this.btnTke.Click += new System.EventHandler(this.btnTke_Click);
            // 
            // dtpC2
            // 
            this.dtpC2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpC2.Location = new System.Drawing.Point(324, 52);
            this.dtpC2.Name = "dtpC2";
            this.dtpC2.Size = new System.Drawing.Size(168, 26);
            this.dtpC2.TabIndex = 6;
            // 
            // dtpC1
            // 
            this.dtpC1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpC1.Location = new System.Drawing.Point(79, 52);
            this.dtpC1.Name = "dtpC1";
            this.dtpC1.Size = new System.Drawing.Size(182, 26);
            this.dtpC1.TabIndex = 5;
            // 
            // chartTron
            // 
            chartArea4.Name = "ChartArea1";
            this.chartTron.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartTron.Legends.Add(legend4);
            this.chartTron.Location = new System.Drawing.Point(968, 126);
            this.chartTron.Name = "chartTron";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            series4.YValuesPerPoint = 2;
            this.chartTron.Series.Add(series4);
            this.chartTron.Size = new System.Drawing.Size(451, 404);
            this.chartTron.TabIndex = 4;
            this.chartTron.Text = "chart2";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.lblBanra);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(1201, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(218, 74);
            this.panel2.TabIndex = 3;
            // 
            // lblBanra
            // 
            this.lblBanra.AutoSize = true;
            this.lblBanra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblBanra.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblBanra.Location = new System.Drawing.Point(97, 38);
            this.lblBanra.Name = "lblBanra";
            this.lblBanra.Size = new System.Drawing.Size(21, 22);
            this.lblBanra.TabIndex = 2;
            this.lblBanra.Text = "0";
            this.lblBanra.Click += new System.EventHandler(this.lblBanra_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số sản phẩm đã bán";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.lblDoanhThu);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(968, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 74);
            this.panel1.TabIndex = 2;
            // 
            // lblDoanhThu
            // 
            this.lblDoanhThu.AutoSize = true;
            this.lblDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDoanhThu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDoanhThu.Location = new System.Drawing.Point(21, 38);
            this.lblDoanhThu.Name = "lblDoanhThu";
            this.lblDoanhThu.Size = new System.Drawing.Size(19, 20);
            this.lblDoanhThu.TabIndex = 1;
            this.lblDoanhThu.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doanh thu";
            // 
            // dgvThongke
            // 
            this.dgvThongke.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongke.Location = new System.Drawing.Point(9, 583);
            this.dgvThongke.Name = "dgvThongke";
            this.dgvThongke.RowHeadersWidth = 62;
            this.dgvThongke.RowTemplate.Height = 28;
            this.dgvThongke.Size = new System.Drawing.Size(888, 244);
            this.dgvThongke.TabIndex = 1;
            // 
            // GUI_Thongke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1455, 870);
            this.Controls.Add(this.groupBox1);
            this.Name = "GUI_Thongke";
            this.Text = "GUI_Thongke";
            this.Load += new System.EventHandler(this.GUI_Thongke_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartCot)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTron)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongke)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartCot;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvThongke;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTron;
        private System.Windows.Forms.Button btnTke;
        private System.Windows.Forms.DateTimePicker dtpC2;
        private System.Windows.Forms.DateTimePicker dtpC1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblBanra;
        private System.Windows.Forms.Label lblDoanhThu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}