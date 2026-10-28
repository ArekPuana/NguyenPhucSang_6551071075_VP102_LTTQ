namespace QLDuLieu
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblMaSinhVien;
        private System.Windows.Forms.Label lblTenSinhVien;
        private System.Windows.Forms.Label lblDiemTrungBinh;
        private System.Windows.Forms.TextBox txtMaSinhVien;
        private System.Windows.Forms.TextBox txtTenSinhVien;
        private System.Windows.Forms.TextBox txtDiemTrungBinh;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView dgvSinhVien;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblMaSinhVien = new Label();
            lblTenSinhVien = new Label();
            lblDiemTrungBinh = new Label();
            txtMaSinhVien = new TextBox();
            txtTenSinhVien = new TextBox();
            txtDiemTrungBinh = new TextBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            dgvSinhVien = new DataGridView();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // lblMaSinhVien
            // 
            lblMaSinhVien.AutoSize = true;
            lblMaSinhVien.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMaSinhVien.Location = new Point(7, 48);
            lblMaSinhVien.Margin = new Padding(4, 0, 4, 0);
            lblMaSinhVien.Name = "lblMaSinhVien";
            lblMaSinhVien.Size = new Size(125, 28);
            lblMaSinhVien.TabIndex = 0;
            lblMaSinhVien.Text = "Mã sinh viên:";
            // 
            // lblTenSinhVien
            // 
            lblTenSinhVien.AutoSize = true;
            lblTenSinhVien.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTenSinhVien.Location = new Point(7, 150);
            lblTenSinhVien.Margin = new Padding(4, 0, 4, 0);
            lblTenSinhVien.Name = "lblTenSinhVien";
            lblTenSinhVien.Size = new Size(126, 28);
            lblTenSinhVien.TabIndex = 1;
            lblTenSinhVien.Text = "Tên sinh viên:";
            // 
            // lblDiemTrungBinh
            // 
            lblDiemTrungBinh.AutoSize = true;
            lblDiemTrungBinh.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDiemTrungBinh.Location = new Point(7, 253);
            lblDiemTrungBinh.Margin = new Padding(4, 0, 4, 0);
            lblDiemTrungBinh.Name = "lblDiemTrungBinh";
            lblDiemTrungBinh.Size = new Size(159, 28);
            lblDiemTrungBinh.TabIndex = 2;
            lblDiemTrungBinh.Text = "Điểm trung bình:";
            // 
            // txtMaSinhVien
            // 
            txtMaSinhVien.Location = new Point(7, 80);
            txtMaSinhVien.Margin = new Padding(4);
            txtMaSinhVien.Name = "txtMaSinhVien";
            txtMaSinhVien.Size = new Size(225, 39);
            txtMaSinhVien.TabIndex = 3;
            // 
            // txtTenSinhVien
            // 
            txtTenSinhVien.Location = new Point(7, 186);
            txtTenSinhVien.Margin = new Padding(4);
            txtTenSinhVien.Name = "txtTenSinhVien";
            txtTenSinhVien.Size = new Size(225, 39);
            txtTenSinhVien.TabIndex = 4;
            // 
            // txtDiemTrungBinh
            // 
            txtDiemTrungBinh.Location = new Point(7, 285);
            txtDiemTrungBinh.Margin = new Padding(4);
            txtDiemTrungBinh.Name = "txtDiemTrungBinh";
            txtDiemTrungBinh.Size = new Size(225, 39);
            txtDiemTrungBinh.TabIndex = 5;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(7, 50);
            btnThem.Margin = new Padding(4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(168, 82);
            btnThem.TabIndex = 6;
            btnThem.Text = "➕ Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Enabled = false;
            btnSua.Location = new Point(210, 50);
            btnSua.Margin = new Padding(4);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(168, 82);
            btnSua.TabIndex = 7;
            btnSua.Text = "✏️ Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Enabled = false;
            btnXoa.Location = new Point(423, 50);
            btnXoa.Margin = new Padding(4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(168, 82);
            btnXoa.TabIndex = 8;
            btnXoa.Text = "🗑️ Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(625, 50);
            btnThoat.Margin = new Padding(4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(168, 82);
            btnThoat.TabIndex = 9;
            btnThoat.Text = "❌ Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // dgvSinhVien
            // 
            dgvSinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSinhVien.Location = new Point(38, 219);
            dgvSinhVien.Margin = new Padding(4);
            dgvSinhVien.Name = "dgvSinhVien";
            dgvSinhVien.RowHeadersWidth = 51;
            dgvSinhVien.Size = new Size(521, 338);
            dgvSinhVien.TabIndex = 10;
            dgvSinhVien.CellClick += dgvSinhVien_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblMaSinhVien);
            groupBox1.Controls.Add(txtDiemTrungBinh);
            groupBox1.Controls.Add(txtTenSinhVien);
            groupBox1.Controls.Add(lblDiemTrungBinh);
            groupBox1.Controls.Add(lblTenSinhVien);
            groupBox1.Controls.Add(txtMaSinhVien);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(599, 219);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(248, 338);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sinh viên";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnThem);
            groupBox2.Controls.Add(btnSua);
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(btnThoat);
            groupBox2.Location = new Point(38, 23);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(809, 157);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Các chức năng";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(875, 591);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dgvSinhVien);
            Margin = new Padding(4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý sinh viên";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}