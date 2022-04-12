namespace GUI.UserControls
{
    partial class ucNhapSanPham
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucNhapSanPham));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.pnNhapThongTin = new System.Windows.Forms.Panel();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDonGiaNhap = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.lblDaTaoPhieuNhap = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnTaoPhieu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgvPhieuNhap = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvCTPN = new System.Windows.Forms.DataGridView();
            this.btnLuu = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.pnNhapThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhap)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPN)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            this.splitContainer1.Panel1.Controls.Add(this.btnLuu);
            this.splitContainer1.Panel1.Controls.Add(this.panel3);
            this.splitContainer1.Panel1.Controls.Add(this.pnNhapThongTin);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnXoa);
            this.splitContainer1.Panel2.Controls.Add(this.btnXacNhan);
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1039, 622);
            this.splitContainer1.SplitterDistance = 429;
            this.splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(133)))), ((int)(((byte)(204)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(429, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập thông tin sản phẩm";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnNhapThongTin
            // 
            this.pnNhapThongTin.Controls.Add(this.txtSoLuong);
            this.pnNhapThongTin.Controls.Add(this.label2);
            this.pnNhapThongTin.Controls.Add(this.txtDonGiaNhap);
            this.pnNhapThongTin.Controls.Add(this.label9);
            this.pnNhapThongTin.Controls.Add(this.txtMaSP);
            this.pnNhapThongTin.Controls.Add(this.lblDaTaoPhieuNhap);
            this.pnNhapThongTin.Controls.Add(this.label3);
            this.pnNhapThongTin.Controls.Add(this.txtTenSP);
            this.pnNhapThongTin.Controls.Add(this.label6);
            this.pnNhapThongTin.Controls.Add(this.btnTaoPhieu);
            this.pnNhapThongTin.Controls.Add(this.btnThem);
            this.pnNhapThongTin.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnNhapThongTin.Location = new System.Drawing.Point(0, 61);
            this.pnNhapThongTin.Name = "pnNhapThongTin";
            this.pnNhapThongTin.Size = new System.Drawing.Size(429, 259);
            this.pnNhapThongTin.TabIndex = 2;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.BackColor = System.Drawing.Color.White;
            this.txtSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.ForeColor = System.Drawing.Color.Black;
            this.txtSoLuong.Location = new System.Drawing.Point(145, 165);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(231, 29);
            this.txtSoLuong.TabIndex = 64;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(68, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 68;
            this.label2.Text = "Số Lượng";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDonGiaNhap
            // 
            this.txtDonGiaNhap.BackColor = System.Drawing.Color.LightGray;
            this.txtDonGiaNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGiaNhap.ForeColor = System.Drawing.Color.Black;
            this.txtDonGiaNhap.Location = new System.Drawing.Point(145, 130);
            this.txtDonGiaNhap.Name = "txtDonGiaNhap";
            this.txtDonGiaNhap.ReadOnly = true;
            this.txtDonGiaNhap.Size = new System.Drawing.Size(231, 29);
            this.txtDonGiaNhap.TabIndex = 65;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(36, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 20);
            this.label9.TabIndex = 69;
            this.label9.Text = "Đơn Giá Nhập";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMaSP
            // 
            this.txtMaSP.BackColor = System.Drawing.Color.LightGray;
            this.txtMaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSP.ForeColor = System.Drawing.Color.Black;
            this.txtMaSP.Location = new System.Drawing.Point(145, 59);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.ReadOnly = true;
            this.txtMaSP.Size = new System.Drawing.Size(231, 29);
            this.txtMaSP.TabIndex = 66;
            // 
            // lblDaTaoPhieuNhap
            // 
            this.lblDaTaoPhieuNhap.AutoSize = true;
            this.lblDaTaoPhieuNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDaTaoPhieuNhap.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblDaTaoPhieuNhap.Location = new System.Drawing.Point(274, 26);
            this.lblDaTaoPhieuNhap.Name = "lblDaTaoPhieuNhap";
            this.lblDaTaoPhieuNhap.Size = new System.Drawing.Size(118, 16);
            this.lblDaTaoPhieuNhap.TabIndex = 70;
            this.lblDaTaoPhieuNhap.Text = "Đã tạo phiếu nhập!";
            this.lblDaTaoPhieuNhap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDaTaoPhieuNhap.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(90, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 71;
            this.label3.Text = "Mã SP";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTenSP
            // 
            this.txtTenSP.BackColor = System.Drawing.Color.LightGray;
            this.txtTenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSP.ForeColor = System.Drawing.Color.Black;
            this.txtTenSP.Location = new System.Drawing.Point(145, 94);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.ReadOnly = true;
            this.txtTenSP.Size = new System.Drawing.Size(231, 29);
            this.txtTenSP.TabIndex = 67;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(85, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 20);
            this.label6.TabIndex = 72;
            this.label6.Text = "Tên SP";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTaoPhieu
            // 
            this.btnTaoPhieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(145)))), ((int)(((byte)(249)))));
            this.btnTaoPhieu.FlatAppearance.BorderSize = 0;
            this.btnTaoPhieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaoPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoPhieu.ForeColor = System.Drawing.Color.White;
            this.btnTaoPhieu.Image = ((System.Drawing.Image)(resources.GetObject("btnTaoPhieu.Image")));
            this.btnTaoPhieu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaoPhieu.Location = new System.Drawing.Point(145, 17);
            this.btnTaoPhieu.Name = "btnTaoPhieu";
            this.btnTaoPhieu.Size = new System.Drawing.Size(123, 34);
            this.btnTaoPhieu.TabIndex = 62;
            this.btnTaoPhieu.Text = "Tạo Phiếu";
            this.btnTaoPhieu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTaoPhieu.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Gray;
            this.btnThem.Enabled = false;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(145, 200);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(92, 34);
            this.btnThem.TabIndex = 63;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSanPham.Location = new System.Drawing.Point(0, 61);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.Size = new System.Drawing.Size(600, 213);
            this.dgvSanPham.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.24171F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.75829F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(606, 537);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvSanPham);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 274);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(133)))), ((int)(((byte)(204)))));
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(600, 61);
            this.label4.TabIndex = 1;
            this.label4.Text = "Danh sách sản phẩm";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvPhieuNhap);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 283);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 251);
            this.panel2.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(133)))), ((int)(((byte)(204)))));
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(600, 49);
            this.label5.TabIndex = 3;
            this.label5.Text = "Danh sách phiếu nhập chưa về kho";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(236, 151);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(8, 8);
            this.dataGridView1.TabIndex = 4;
            // 
            // dgvPhieuNhap
            // 
            this.dgvPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhieuNhap.Location = new System.Drawing.Point(0, 49);
            this.dgvPhieuNhap.Name = "dgvPhieuNhap";
            this.dgvPhieuNhap.Size = new System.Drawing.Size(600, 202);
            this.dgvPhieuNhap.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvCTPN);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 320);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(429, 217);
            this.panel3.TabIndex = 3;
            // 
            // dgvCTPN
            // 
            this.dgvCTPN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTPN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCTPN.Location = new System.Drawing.Point(0, 0);
            this.dgvCTPN.Name = "dgvCTPN";
            this.dgvCTPN.ReadOnly = true;
            this.dgvCTPN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCTPN.Size = new System.Drawing.Size(429, 217);
            this.dgvCTPN.TabIndex = 2;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.Gray;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(228, 556);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(74, 34);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(333, 556);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(74, 34);
            this.button2.TabIndex = 4;
            this.button2.Text = "Hủy";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.Color.Gray;
            this.btnXacNhan.FlatAppearance.BorderSize = 0;
            this.btnXacNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.ForeColor = System.Drawing.Color.White;
            this.btnXacNhan.Location = new System.Drawing.Point(90, 559);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(157, 29);
            this.btnXacNhan.TabIndex = 1;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Gray;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(371, 559);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(113, 29);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // ucNhapSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.splitContainer1);
            this.Name = "ucNhapSanPham";
            this.Size = new System.Drawing.Size(1039, 622);
            this.Load += new System.EventHandler(this.ucNhapSanPham_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.pnNhapThongTin.ResumeLayout(false);
            this.pnNhapThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhap)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel pnNhapThongTin;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDonGiaNhap;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label lblDaTaoPhieuNhap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnTaoPhieu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvCTPN;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.DataGridView dgvPhieuNhap;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
