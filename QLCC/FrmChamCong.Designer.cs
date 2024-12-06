namespace QLCC
{
    partial class FrmChamCong
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
            this.cboMaNV = new System.Windows.Forms.ComboBox();
            this.dataGridCV = new System.Windows.Forms.DataGridView();
            this.txtThang = new System.Windows.Forms.NumericUpDown();
            this.txtNgayPhep = new System.Windows.Forms.TextBox();
            this.lblMaPB = new System.Windows.Forms.Label();
            this.lblNuocSX = new System.Windows.Forms.Label();
            this.lblMaLoaiTS = new System.Windows.Forms.Label();
            this.lblTenTS = new System.Windows.Forms.Label();
            this.lblNamSD = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnChen = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtNgayCong = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtTienLuong = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThang)).BeginInit();
            this.SuspendLayout();
            // 
            // cboMaNV
            // 
            this.cboMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaNV.FormattingEnabled = true;
            this.cboMaNV.Location = new System.Drawing.Point(283, 95);
            this.cboMaNV.Name = "cboMaNV";
            this.cboMaNV.Size = new System.Drawing.Size(443, 37);
            this.cboMaNV.TabIndex = 42;
            // 
            // dataGridCV
            // 
            this.dataGridCV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCV.Location = new System.Drawing.Point(36, 358);
            this.dataGridCV.Name = "dataGridCV";
            this.dataGridCV.RowHeadersWidth = 51;
            this.dataGridCV.RowTemplate.Height = 24;
            this.dataGridCV.Size = new System.Drawing.Size(914, 147);
            this.dataGridCV.TabIndex = 41;
            // 
            // txtThang
            // 
            this.txtThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThang.Location = new System.Drawing.Point(283, 148);
            this.txtThang.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.txtThang.Name = "txtThang";
            this.txtThang.Size = new System.Drawing.Size(443, 34);
            this.txtThang.TabIndex = 40;
            // 
            // txtNgayPhep
            // 
            this.txtNgayPhep.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayPhep.Location = new System.Drawing.Point(283, 242);
            this.txtNgayPhep.Name = "txtNgayPhep";
            this.txtNgayPhep.Size = new System.Drawing.Size(443, 34);
            this.txtNgayPhep.TabIndex = 38;
            // 
            // lblMaPB
            // 
            this.lblMaPB.AutoSize = true;
            this.lblMaPB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaPB.Location = new System.Drawing.Point(31, 289);
            this.lblMaPB.Name = "lblMaPB";
            this.lblMaPB.Size = new System.Drawing.Size(128, 29);
            this.lblMaPB.TabIndex = 37;
            this.lblMaPB.Text = "Tien luong";
            // 
            // lblNuocSX
            // 
            this.lblNuocSX.AutoSize = true;
            this.lblNuocSX.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuocSX.Location = new System.Drawing.Point(31, 247);
            this.lblNuocSX.Name = "lblNuocSX";
            this.lblNuocSX.Size = new System.Drawing.Size(161, 29);
            this.lblNuocSX.TabIndex = 36;
            this.lblNuocSX.Text = "So ngay phep";
            // 
            // lblMaLoaiTS
            // 
            this.lblMaLoaiTS.AutoSize = true;
            this.lblMaLoaiTS.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaLoaiTS.Location = new System.Drawing.Point(31, 148);
            this.lblMaLoaiTS.Name = "lblMaLoaiTS";
            this.lblMaLoaiTS.Size = new System.Drawing.Size(82, 29);
            this.lblMaLoaiTS.TabIndex = 35;
            this.lblMaLoaiTS.Text = "Thang";
            // 
            // lblTenTS
            // 
            this.lblTenTS.AutoSize = true;
            this.lblTenTS.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenTS.Location = new System.Drawing.Point(31, 103);
            this.lblTenTS.Name = "lblTenTS";
            this.lblTenTS.Size = new System.Drawing.Size(154, 29);
            this.lblTenTS.TabIndex = 33;
            this.lblTenTS.Text = "Ma nhan vien";
            // 
            // lblNamSD
            // 
            this.lblNamSD.AutoSize = true;
            this.lblNamSD.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamSD.Location = new System.Drawing.Point(31, 196);
            this.lblNamSD.Name = "lblNamSD";
            this.lblNamSD.Size = new System.Drawing.Size(159, 29);
            this.lblNamSD.TabIndex = 34;
            this.lblNamSD.Text = "So ngay cong";
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.btnThoat.Location = new System.Drawing.Point(807, 277);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(143, 48);
            this.btnThoat.TabIndex = 32;
            this.btnThoat.Text = "Thoat";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.btnSua.Location = new System.Drawing.Point(807, 155);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(143, 52);
            this.btnSua.TabIndex = 31;
            this.btnSua.Text = "Sua";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnChen
            // 
            this.btnChen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.btnChen.Location = new System.Drawing.Point(807, 101);
            this.btnChen.Name = "btnChen";
            this.btnChen.Size = new System.Drawing.Size(143, 48);
            this.btnChen.TabIndex = 29;
            this.btnChen.Text = "Chen";
            this.btnChen.UseVisualStyleBackColor = true;
            this.btnChen.Click += new System.EventHandler(this.btnChen_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.btnXoa.Location = new System.Drawing.Point(807, 213);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(143, 49);
            this.btnXoa.TabIndex = 30;
            this.btnXoa.Text = "Xoa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtNgayCong
            // 
            this.txtNgayCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayCong.Location = new System.Drawing.Point(283, 196);
            this.txtNgayCong.Name = "txtNgayCong";
            this.txtNgayCong.Size = new System.Drawing.Size(443, 34);
            this.txtNgayCong.TabIndex = 44;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.button1.Location = new System.Drawing.Point(807, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 48);
            this.button1.TabIndex = 45;
            this.button1.Text = "Tao";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTienLuong
            // 
            this.txtTienLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienLuong.Location = new System.Drawing.Point(283, 300);
            this.txtTienLuong.Name = "txtTienLuong";
            this.txtTienLuong.Size = new System.Drawing.Size(443, 34);
            this.txtTienLuong.TabIndex = 46;
            // 
            // FrmChamCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 532);
            this.Controls.Add(this.txtTienLuong);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtNgayCong);
            this.Controls.Add(this.cboMaNV);
            this.Controls.Add(this.dataGridCV);
            this.Controls.Add(this.txtThang);
            this.Controls.Add(this.txtNgayPhep);
            this.Controls.Add(this.lblMaPB);
            this.Controls.Add(this.lblNuocSX);
            this.Controls.Add(this.lblMaLoaiTS);
            this.Controls.Add(this.lblTenTS);
            this.Controls.Add(this.lblNamSD);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnChen);
            this.Controls.Add(this.btnXoa);
            this.Name = "FrmChamCong";
            this.Text = "FrmChamCong";
            this.Load += new System.EventHandler(this.FrmChamCong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cboMaNV;
        private System.Windows.Forms.DataGridView dataGridCV;
        private System.Windows.Forms.NumericUpDown txtThang;
        private System.Windows.Forms.TextBox txtNgayPhep;
        private System.Windows.Forms.Label lblMaPB;
        private System.Windows.Forms.Label lblNuocSX;
        private System.Windows.Forms.Label lblMaLoaiTS;
        private System.Windows.Forms.Label lblTenTS;
        private System.Windows.Forms.Label lblNamSD;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnChen;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtNgayCong;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtTienLuong;
    }
}